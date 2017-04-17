using BlackJack.Modelo;
using Facebook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack.Vistas
{
    public partial class MDIPrincipal : Form
    {
        private Jugador jugador;
        private string _accessToken;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        public MDIPrincipal(Jugador jugador , string access)
        {
            InitializeComponent();
            this.jugador = jugador;
            this._accessToken = access;
        }




        private void jugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJuego f = new FrmJuego(jugador);
            f.Show();
        }

        private void helpMenu_Click(object sender, EventArgs e)
        {
            FrmAyuda f = new FrmAyuda();
            f.Show();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPerfil perfil = new FrmPerfil(jugador);
            perfil.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(_accessToken);
            frm.Show();
            this.Hide();


        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1(_accessToken);
            Application.Exit();

        }
    }
}
