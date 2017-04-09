using BlackJack.Logica;
using BlackJack.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlackJack.Vistas
{
    public partial class FrmJuego : Form
    {
        private int suma;
        public FrmJuego()
        {

            InitializeComponent();
            suma = 0;
            limpiar();
            WebAPI.newGame();
            Iniciar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            WebAPI.newGame();
            Iniciar();


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

            Juego.ContadorCartas = 0;
            suma = 0;
        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            Carta carta = WebAPI.requestCard(Juego.Partida.Deck_Id);
            this.mostar(carta);
        }

        public void Iniciar() { 
        List<Carta> Lista = WebAPI.requestCardStartGame(Juego.Partida.Deck_Id);
            foreach (Carta item in Lista)
            {
                mostar(item);
    } }
    }
}
