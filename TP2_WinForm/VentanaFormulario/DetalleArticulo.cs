using Dominio;
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
using TP2_WinForm.Negocio;

namespace TP2_WinForm.VentanaFormulario
{
    public partial class DetalleArticulo : Form
    {
        private List<Articulos> ListaArticulos;
        public DetalleArticulo()
        {
            InitializeComponent();
        }

        private void btnguardarcambiospersonal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DetalleArticulo_Load(object sender, EventArgs e)
        {
            ArticulosNegocio Articulo = new ArticulosNegocio();
            Globales.DiseñoDtv(ref datalistadoDetalle);
            Globales.DiseñoDtv(ref datalistadoDetalletotal);
            ListaArticulos = Articulo.ListarArticulos();
            datalistadoDetalle.DataSource = ListaArticulos;

            datalistadoDetalle.Columns[0].Visible = false;
            datalistadoDetalle.Columns[3].Visible = false;
            datalistadoDetalle.Columns[4].Visible = false;
            datalistadoDetalle.Columns[5].Visible = false;
            datalistadoDetalle.Columns[6].Visible = false;
            datalistadoDetalle.Columns[7].Visible = false;

        }

        private void btnDetallar_Click(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = datalistadoDetalle.CurrentRow;
            Articulos arteligido = (Articulos)seleccion.DataBoundItem;

            datalistadoDetalletotal.DataSource= new List<Articulos> { arteligido };
            AgregariconoPc.ImageLocation = arteligido.Imagen;
            Globales.OcultarColumnas(ref datalistadoDetalletotal);
        }
    }
}
