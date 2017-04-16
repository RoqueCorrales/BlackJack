using BlackJack.Logica;
using BlackJack.Modelo;
using BlackJack.Controlador;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlackJack.Vistas
{
    public partial class FrmJuego : Form
    {
        public BlackJack.Logica.Logica log;
        private int totalJugador;
        private int totalDealear;
        private Baraja barajaJuador;
        private Baraja barajaDealer;
        string cartaOculta ;
        private Jugador jugador;
        public Controlador.WebApi api;
        private int jugadasJugador;
        private int ganadasJugador;
        public FrmJuego()
        {

            InitializeComponent();
            totalDealear = 0;
            totalJugador = 0;
            ganadasJugador = 0;
            jugadasJugador = 0;
            
            log = new Logica.Logica();
            barajaDealer = new Baraja();
            barajaJuador = new Baraja();
            api = new Controlador.WebApi();
            cartaOculta = @"C:\Users\roke1\Desktop\Utn\4 cuatri\Progra 3\BlackJack\Imagenessa\naipe.jpg";
            limpiar();
            fotoPerfil.LoadAsync(jugador.foto);
            WebApi.newGame();
            
            

           
        }
        public FrmJuego( Jugador jugador)
        {
            InitializeComponent();
            totalDealear = 0;
            totalJugador = 0;
            log = new Logica.Logica();
            barajaDealer = new Baraja();
            barajaJuador = new Baraja();
            cartaOculta = @"C:\Users\roke1\Desktop\Utn\4 cuatri\Progra 3\BlackJack\Imagenessa\naipe.jpg";
            limpiar();
            WebApi.newGame();
            this.jugador = new Jugador();
            fotoPerfil.LoadAsync(jugador.foto);
            ganadasJugador = 0;
            jugadasJugador = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            WebApi.newGame();
            Iniciar();
            IniciarDealear();
            btnNuevo.Visible = false;


        }
        private void mostar(Carta c)
        {
            switch (Juego.ContadorCartas)
            {
                case 0:
                    CartaUno.ImageLocation = c.Image;
                    Juego.ContadorCartas++;
                    break;
                case 1:
                    cartaDos.ImageLocation = c.Image;
                    Juego.ContadorCartas++;
                    break;
                case 2:
                    cartaTres.ImageLocation = c.Image;
                    Juego.ContadorCartas++;
                    break;
                case 3:
                    cartaCuatro.ImageLocation = c.Image;
                    Juego.ContadorCartas++;
                    break;
                case 4:
                    cartaCinco.ImageLocation = c.Image;
                    Juego.ContadorCartas++;
                    break;

            }
        }
        private void limpiar()
        {
            CartaUno.Image = null;
            cartaDos.Image = null;
            cartaTres.Image = null;
            cartaCuatro.Image = null;
            cartaCinco.Image = null;
            c1.Image = null;
            c2.Image = null;
            c3.Image = null;
            c4.Image = null;
            c5.Image = null;
            totalDealear = 0;
            totalJugador = 0;
            barajaDealer = new Baraja();
            barajaJuador = new Baraja();
            Juego.ContadorCartas = 0;
            btnCarta.Visible = true;
            btnQuedarse.Visible = true;
            btnNuevo.Visible = true;
         
        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            Carta carta = WebApi.requestCard(Juego.Partida.deck_Id);
            this.mostar(carta);
            txtTotal.Text = Juego.Partida.remaining.ToString();
            totalJugador = totalJugador + log.sumar(carta, totalJugador,barajaJuador.cartas);
            barajaJuador.cartas.Add(carta);

            if(totalJugador > 21)
            {
                c1.ImageLocation = barajaDealer.cartas[0].Image;
                MessageBox.Show("Has Perdido, Dealer gana con un total de : " + totalDealear);
                btnQuedarse.Visible = false;
                btnCarta.Visible = false;
                btnNuevo.Visible = true;
            }


        }

        public void Iniciar() { 
        List<Carta> Lista = WebApi.requestCardStartGame(Juego.Partida.deck_Id);
            foreach (Carta item in Lista)
            {
                mostar(item);
               
                totalJugador = totalJugador + log.sumar(item, totalJugador,barajaJuador.cartas);
                barajaJuador.cartas.Add(item);
                txtTotal.Text = Juego.Partida.remaining.ToString();
            }

        }
        public void IniciarDealear()
        {
            List<Carta> Lista = WebApi.requestCardStartGame(Juego.Partida.deck_Id);
            foreach (Carta item in Lista)
            {
                mostrarDealear(item);
               
                totalDealear = totalDealear + log.sumar(item, totalDealear,barajaDealer.cartas);
                barajaDealer.cartas.Add(item);
                txtTotal.Text = Juego.Partida.remaining.ToString();
            }

        }


        private void mostrarDealear(Carta c)
        {
            switch (barajaDealer.cartas.Count)
            {
                case 0:
                    c1.Image = System.Drawing.Image.FromFile(cartaOculta);
                   
                    break;
                case 1:
                    c2.ImageLocation = c.Image;
                    break;
                case 2:
                    c3.ImageLocation = c.Image;
                    break;
                case 3:
                    c4.ImageLocation = c.Image;
                    break;
                case 4:
                    c5.ImageLocation = c.Image;
                    break;
              
            }
        }

        private void cartaCinco_Click(object sender, EventArgs e)
        {

        }
        
        private void btnQuedarse_Click(object sender, EventArgs e)
        {
           
            while(totalDealear <= totalJugador)
            {
                Carta carta = WebApi.requestCard(Juego.Partida.deck_Id);
                mostrarDealear(carta);
                totalDealear = totalDealear + log.sumar(carta, totalDealear,barajaDealer.cartas);
                barajaDealer.cartas.Add(carta);
                txtTotal.Text = Juego.Partida.remaining.ToString();
                btnQuedarse.Visible = false;
                btnCarta.Visible = false;

                

            }
            if(totalDealear> totalJugador && totalDealear <= 21){
                c1.ImageLocation = barajaDealer.cartas[0].Image;
                MessageBox.Show("Has Perdido, Dealer gana con un total de : " + totalDealear);
                jugador.partidasJugadas = jugadasJugador + 1; 
                //Base Datos

                btnQuedarse.Visible = false;
                btnCarta.Visible = false;
                btnNuevo.Visible = true;

            }
            else if(totalJugador == totalDealear)
            {
                c1.ImageLocation = barajaDealer.cartas[0].Image;
                MessageBox.Show("Partida Empatada, Con un total de : " + totalJugador);
                jugador.partidasJugadas = jugadasJugador + 1;
                // Base Datos

                btnQuedarse.Visible = false;
                btnCarta.Visible = false;
                btnNuevo.Visible = true;
            }
            else
            {
                c1.ImageLocation = barajaDealer.cartas[0].Image;
                MessageBox.Show("Has Ganado, Con un total de : " + totalJugador);
                jugador.partidasJugadas = jugadasJugador + 1;
                jugador.partidasGanadas = ganadasJugador + 1;
                btnQuedarse.Visible = false;
                btnCarta.Visible = false;
                btnNuevo.Visible = true;
            }

        }

        private void btnRebajar_Click(object sender, EventArgs e)
        {
            WebApi.reshuffleCards(Juego.Partida.deck_Id);
            MessageBox.Show("Cartas revueltas.");
        }
    }
}
