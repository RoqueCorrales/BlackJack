using BlackJack.Logica;
using BlackJack.Modelo;
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
        public FrmJuego()
        {

            InitializeComponent();
            totalDealear = 0;
            totalJugador = 0;
            log = new Logica.Logica();
            barajaDealer = new Baraja();
            barajaJuador = new Baraja();
            cartaOculta = @"C:\Users\Josue\Desktop\Proyecto Git\BlackJack\Imagenessa\naipe.jpg";
            limpiar();
            WebAPI.newGame();

           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            WebAPI.newGame();
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
            Carta carta = WebAPI.requestCard(Juego.Partida.Deck_Id);
            this.mostar(carta);
            txtTotal.Text = Juego.Partida.Remaining.ToString();
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
        List<Carta> Lista = WebAPI.requestCardStartGame(Juego.Partida.Deck_Id);
            foreach (Carta item in Lista)
            {
                mostar(item);
               
                totalJugador = totalJugador + log.sumar(item, totalJugador,barajaJuador.cartas);
                barajaJuador.cartas.Add(item);
                txtTotal.Text = Juego.Partida.Remaining.ToString();
            }

        }
        public void IniciarDealear()
        {
            List<Carta> Lista = WebAPI.requestCardStartGame(Juego.Partida.Deck_Id);
            foreach (Carta item in Lista)
            {
                mostrarDealear(item);
               
                totalDealear = totalDealear + log.sumar(item, totalDealear,barajaDealer.cartas);
                barajaDealer.cartas.Add(item);
                txtTotal.Text = Juego.Partida.Remaining.ToString();
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
                Carta carta = WebAPI.requestCard(Juego.Partida.Deck_Id);
                mostrarDealear(carta);
                totalDealear = totalDealear + log.sumar(carta, totalDealear,barajaDealer.cartas);
                barajaDealer.cartas.Add(carta);
                txtTotal.Text = Juego.Partida.Remaining.ToString();
                btnQuedarse.Visible = false;
                btnCarta.Visible = false;

                

            }
            if(totalDealear> totalJugador && totalDealear <= 21){
                c1.ImageLocation = barajaDealer.cartas[0].Image;
                MessageBox.Show("Has Perdido, Dealer gana con un total de : " + totalDealear);
                btnQuedarse.Visible = false;
                btnCarta.Visible = false;
                btnNuevo.Visible = true;

            }
            else if(totalJugador == totalDealear)
            {
                c1.ImageLocation = barajaDealer.cartas[0].Image;
                MessageBox.Show("Partida Empatada, Con un total de : " + totalJugador);
                btnQuedarse.Visible = false;
                btnCarta.Visible = false;
                btnNuevo.Visible = true;
            }
            else
            {
                c1.ImageLocation = barajaDealer.cartas[0].Image;
                MessageBox.Show("Has Ganado, Con un total de : " + totalJugador);
                btnQuedarse.Visible = false;
                btnCarta.Visible = false;
                btnNuevo.Visible = true;
            }

        }

        private void btnRebajar_Click(object sender, EventArgs e)
        {
            WebAPI.reshuffleCards(Juego.Partida.Deck_Id);
            MessageBox.Show("Cartas revueltas.");
        }
    }
}
