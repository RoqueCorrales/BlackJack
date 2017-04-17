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
        private Modelo.DATA data;
        public FrmPerfil()
        {
            InitializeComponent();
            data = new Modelo.DATA();
        }

        public FrmPerfil(Jugador jugador)
        {
            InitializeComponent();
            data = new Modelo.DATA();
            
            jugador = data.SelectLogin(jugador.idfacebook);
            
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
            txtTotalJugadas.Text = jugador.partidasjugadas.ToString();
            txtGanadas.Text = jugador.partidasganadas.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
