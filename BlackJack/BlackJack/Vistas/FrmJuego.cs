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
        string cartaOculta;
        private Jugador jugador;
        public Controlador.WebApi api;
        private Controlador.Data dataCon = new Data();
        private Modelo.DATA data;
        private PartidaJugada par;
        private Boolean hayGanador;
        public FrmJuego()
        {

            InitializeComponent();
            totalDealear = 0;
            totalJugador = 0;


            log = new Logica.Logica();
            data = new Modelo.DATA();
            barajaDealer = new Baraja();
            barajaJuador = new Baraja();
            api = new Controlador.WebApi();
            cartaOculta = @"C:\Users\Josue\Desktop\Proyecto Git\BlackJack\Imagenessa\naipe.jpg";
            limpiar();
            fotoPerfil.LoadAsync(jugador.foto);
            WebApi.newGame();
            txtTotalJugadas.Text = jugador.partidasjugadas.ToString();
            txtGanadas.Text = jugador.partidasganadas.ToString();
            btnCarta.Visible = false;
            btnQuedarse.Visible = false;
            par = new PartidaJugada();


        }
        public FrmJuego(Jugador jugador)
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
            fotoPerfil.LoadAsync(jugador.foto);
            data = new Modelo.DATA();
            this.jugador = logeadoJugado(jugador);
            txtTotalJugadas.Text = this.jugador.partidasjugadas.ToString();
            txtGanadas.Text = this.jugador.partidasganadas.ToString();
            btnCarta.Visible = false;
            btnQuedarse.Visible = false;
            par = new PartidaJugada();
            hayGanador = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            WebApi.newGame();
            Iniciar();
            IniciarDealear();
            btnNuevo.Visible = false;
            btnQuedarse.Visible = true;
            btnCarta.Visible = true;


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
            lblId.Text = "";
            hayGanador = false;
            lblPuntajeJugador.Text ="";

        }
        public PartidaJugada prepararPartidaJugada()
        {
            PartidaJugada p = new PartidaJugada();
            p.fecha = DateTime.Now;
            p.idjugador = jugador.idfacebook;
            p.deck_id = Juego.Partida.deck_Id;

            return p;
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


        private void btnCarta_Click(object sender, EventArgs e)
        {
            Carta carta = WebApi.requestCard(Juego.Partida.deck_Id);
            this.mostar(carta);
            txtTotal.Text = Juego.Partida.remaining.ToString();
            totalJugador = log.totalCartas(carta, barajaJuador.cartas);
            lblPuntajeJugador.Text = totalJugador.ToString();
            // barajaJuador.cartas.Add(carta);

            if (totalJugador > 21)
            {
                c1.ImageLocation = barajaDealer.cartas[0].Image;
                MessageBox.Show("Has Perdido, Dealer gana con un total de : " + totalDealear);
                jugador.partidasjugadas = jugador.partidasjugadas + 1;
                txtTotalJugadas.Text = jugador.partidasjugadas.ToString();
                Accion(jugador);
                par = prepararPartidaJugada();
                par.ganaste = false;
                // dataCon.insertarPartidaJugada(par);
                btnQuedarse.Visible = false;
                btnCarta.Visible = false;
                btnNuevo.Visible = true;
                hayGanador = true;
            }


        }

        public void Iniciar()
        {


            if (MessageBox.Show("Quiere rebarajar el maso ?", "Rebarajar Maso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                rebarajar();
            }
            List<Carta> Lista = WebApi.requestCardStartGame(Juego.Partida.deck_Id);
            lblId.Text = Juego.Partida.deck_Id;
            foreach (Carta item in Lista)
            {
                mostar(item);

                totalJugador = log.totalCartas(item, barajaJuador.cartas);

                txtTotal.Text = Juego.Partida.remaining.ToString();
                lblPuntajeJugador.Text = totalJugador.ToString();
            }

        }
        public void IniciarDealear()
        {
            List<Carta> Lista = WebApi.requestCardStartGame(Juego.Partida.deck_Id);
            foreach (Carta item in Lista)
            {
                mostrarDealear(item);

                totalDealear = log.totalCartas(item, barajaDealer.cartas);

                txtTotal.Text = Juego.Partida.remaining.ToString();
            }

        }



        private void cartaCinco_Click(object sender, EventArgs e)
        {

        }

        private void btnQuedarse_Click(object sender, EventArgs e)
        {

            quedarse();

        }

        public void quedarse()
        {
            while (totalDealear <= totalJugador && totalDealear != 21)
            {
                Carta carta = WebApi.requestCard(Juego.Partida.deck_Id);
                mostrarDealear(carta);
                totalDealear = log.totalCartas(carta, barajaDealer.cartas);

                txtTotal.Text = Juego.Partida.remaining.ToString();
                btnQuedarse.Visible = false;
                btnCarta.Visible = false;



            }
            if (totalDealear > totalJugador && totalDealear <= 21)
            {
                c1.ImageLocation = barajaDealer.cartas[0].Image;
                MessageBox.Show("Has Perdido, Dealer gana con un total de : " + totalDealear);
                jugador.partidasjugadas = jugador.partidasjugadas + 1;
                txtTotalJugadas.Text = jugador.partidasjugadas.ToString();
                Accion(jugador);
                par = prepararPartidaJugada();
                par.ganaste = false;
                // dataCon.insertarPartidaJugada(par);


                btnQuedarse.Visible = false;
                btnCarta.Visible = false;
                btnNuevo.Visible = true;
                hayGanador = true;

            }
            else if (totalJugador == totalDealear)
            {
                c1.ImageLocation = barajaDealer.cartas[0].Image;
                MessageBox.Show("Partida Empatada, Con un total de : " + totalJugador);
                jugador.partidasjugadas = jugador.partidasjugadas + 1;
                txtTotalJugadas.Text = jugador.partidasjugadas.ToString();
                Accion(jugador);
                par = prepararPartidaJugada();
                par.ganaste = false;
                //  dataCon.insertarPartidaJugada(par);

                btnQuedarse.Visible = false;
                btnCarta.Visible = false;
                btnNuevo.Visible = true;
                hayGanador = true;
            }
            else
            {
                c1.ImageLocation = barajaDealer.cartas[0].Image;
                MessageBox.Show("Has Ganado, Con un total de : " + totalJugador);
                jugador.partidasjugadas = jugador.partidasjugadas + 1;
                jugador.partidasganadas = jugador.partidasganadas + 1;
                txtTotalJugadas.Text = jugador.partidasjugadas.ToString();
                txtGanadas.Text = jugador.partidasganadas.ToString();
                Accion(jugador);
                par = prepararPartidaJugada();
                par.ganaste = true;
                //  dataCon.insertarPartidaJugada(par);

                btnQuedarse.Visible = false;
                btnCarta.Visible = false;
                btnNuevo.Visible = true;
                hayGanador = true;
            }
        }

        private void btnRebajar_Click(object sender, EventArgs e)
        {
            rebarajar();
        }

        public void rebarajar()
        {
            WebApi.reshuffleCards(Juego.Partida.deck_Id);
            lblId.Text = Juego.Partida.deck_Id;
            txtTotal.Text = Juego.Partida.remaining.ToString();
            MessageBox.Show("Cartas revueltas.");
        }


        public void Accion(Jugador jugador)
        {
            if (data.SelectID(jugador.idfacebook))
            {
                data.InsterJugador(jugador);
            }
            else
            {
                data.UpdateJugador(jugador);
            }
        }
        public Jugador logeadoJugado(Jugador jugador)
        {
            Jugador a = new Jugador();
            a = data.SelectLogin(jugador.idfacebook);
            if (a.nombre == null)
            {

                return jugador;
            }
            else
            {

                return a;
            }
        }

        private void FrmJuego_FormClosing(object sender, FormClosingEventArgs e)
        {
            if((barajaJuador.cartas.Count >=2 )&& (hayGanador == false))
            {
                quedarse();
            }
            
            
        }
    }
}
