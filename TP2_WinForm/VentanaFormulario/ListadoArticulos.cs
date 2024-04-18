using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_WinForm.Clases;
using TP2_WinForm.Negocio;

namespace TP2_WinForm.VentanaFormulario
{
    public partial class ListadoArticulos : Form
    {
        private List<Articulos> listaArticulos;
        public ListadoArticulos()
        {
            InitializeComponent();
        }

        private void ListadoArticulos_Load(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            listaArticulos = negocio.listar();
            dgvArticulo.DataSource = negocio.listar();
            dgvArticulo.Columns["IdArticulo"].Visible = false;
            dgvArticulo.Columns["CodArticulo"].Visible = false;
            dgvArticulo.Columns["IdCategoria"].Visible = false;
            dgvArticulo.Columns["IdMarca"].Visible = false;
            dgvArticulo.Columns["Imagen"].Visible = false;
            pbxArticulo.Load(listaArticulos[0].Imagen.ImagenUrl);
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            Articulos seleccionado = (Articulos)dgvArticulo.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen.ImagenUrl);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception im)
            {
                pbxArticulo.Load("https://demofree.sirv.com/products/123456/123456.jpg?profile=error-example");
            }
        }
    }
}
