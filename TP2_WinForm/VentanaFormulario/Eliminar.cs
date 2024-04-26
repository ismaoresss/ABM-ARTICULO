using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_WinForm.Negocio;
using Dominio;
using Negocio;

namespace TP2_WinForm.VentanaFormulario
{
    public partial class Eliminar : Form
    {
        private List<Articulos> listaArticulo;
        public Eliminar()
        {
            InitializeComponent();
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            ArticulosNegocio articuloNeg = new ArticulosNegocio();
            listaArticulo = articuloNeg.listaParaImagenes();
            datalistadoArticulosEliminar.DataSource = listaArticulo;
            datalistadoArticulosEliminar.Columns[0].Visible = false;
            datalistadoArticulosEliminar.Columns[6].Visible = false;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio articulo = new ArticulosNegocio();
            Articulos seleccionado;
            try
            {
                seleccionado = datalistadoArticulosEliminar.CurrentRow.DataBoundItem as Articulos;
                articulo.eliminar(seleccionado.IdArticulo);
                MessageBox.Show("Articulo eliminado");

                listaArticulo = articulo.ListarArticulos();
                datalistadoArticulosEliminar.DataSource = listaArticulo;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnguardarcambiospersonal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
