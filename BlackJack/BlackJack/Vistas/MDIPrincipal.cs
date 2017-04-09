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

        public MDIPrincipal()
        {
            InitializeComponent();
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
    }
}
