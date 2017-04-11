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
        string cartaOculta = @"C:\Users\roke1\Desktop\Utn\4 cuatri\Progra 3\BlackJack\Imagenessa\naipe.jpg";
        public FrmJuego()
        {

            InitializeComponent();
            totalDealear = 0;
            totalJugador = 0;
            log = new Logica.Logica();
            barajaDealer = new Baraja();
            barajaJuador = new Baraja();

            limpiar();
            WebAPI.newGame();

           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            WebAPI.newGame();
            Iniciar();
            IniciarDealear();


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

            Juego.ContadorCartas = 0;
         
        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            Carta carta = WebAPI.requestCard(Juego.Partida.Deck_Id);
            this.mostar(carta);
            txtTotal.Text = Juego.Partida.Remaining.ToString();
            
        }

        public void Iniciar() { 
        List<Carta> Lista = WebAPI.requestCardStartGame(Juego.Partida.Deck_Id);
            foreach (Carta item in Lista)
            {
                mostar(item);
                barajaJuador.cartas.Add(item);
                totalJugador = totalJugador + log.sumar(item, totalJugador);
                txtTotal.Text = Juego.Partida.Remaining.ToString();
            }

        }
        public void IniciarDealear()
        {
            List<Carta> Lista = WebAPI.requestCardStartGame(Juego.Partida.Deck_Id);
            foreach (Carta item in Lista)
            {
                mostrarDealear(item);
                barajaDealer.cartas.Add(item);
                totalDealear = totalDealear + log.sumar(item, totalDealear);
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
    }
}
