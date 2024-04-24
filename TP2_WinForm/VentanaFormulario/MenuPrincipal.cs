using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_WinForm.VentanaFormulario
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tsmContacto_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Aplicación desarrollada por Ismael Oreste, Pedro Bernaves Quiros y Facundo Nahuel Pino ");
        }
    }
}
