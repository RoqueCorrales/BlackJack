using BlackJack.Modelo;
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
        private int childFormNumber = 0;
        private Jugador jugador;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        public MDIPrincipal(Jugador jugador)
        {
            InitializeComponent();
            this.jugador = jugador;
        }




        private void jugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJuego f = new FrmJuego();
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

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
