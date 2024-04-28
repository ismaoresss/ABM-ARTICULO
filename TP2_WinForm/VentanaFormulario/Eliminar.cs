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
            Globales.DiseñoDtv(ref datalistadoArticulosEliminar);
            Globales.OcultarColumnas(ref datalistadoArticulosEliminar);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio articulo = new ArticulosNegocio();
            Articulos seleccionado;
            try
            {
                DialogResult result = MessageBox.Show("¿Estas seguro de Eliminar este Registro?", "Eliminar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                seleccionado = datalistadoArticulosEliminar.CurrentRow.DataBoundItem as Articulos;
                articulo.eliminar(seleccionado.IdArticulo);
                MessageBox.Show("Articulo eliminado");

                listaArticulo = articulo.ListarArticulos();
                datalistadoArticulosEliminar.DataSource = listaArticulo;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

                //Actualiza el listado de articulos con los nuevos articulos
                ListadoArticulos listado = new ListadoArticulos();
                listado.cargarArticulosEnListado();
            }
        }

        private void btnguardarcambiospersonal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
