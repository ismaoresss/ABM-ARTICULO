using Negocio;
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
    public partial class Modificar_artículos : Form
    {
        public Modificar_artículos()
        {
            InitializeComponent();
        }

        private void Modificar_artículos_Load(object sender, EventArgs e)
        {
            Globales.DiseñoDtv(ref datalistadoArticulo);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
