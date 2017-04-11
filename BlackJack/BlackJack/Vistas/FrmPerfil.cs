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
    public partial class FrmPerfil : Form
    {
        Jugador jugador;
        public FrmPerfil()
        {
            InitializeComponent();
        }

        public FrmPerfil(Jugador jugador)
        {
            InitializeComponent();
            this.jugador = jugador;

            lblNombre.Text = jugador.nombre;
            lblApellido.Text = jugador.apellido;
            if (jugador.genero.Equals("male"))
            {
                lblGenero.Text = "Hombre";
            }else
            {
                lblGenero.Text = "Mujer";
            }
            
            fotoPerfil.LoadAsync(jugador.foto);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
