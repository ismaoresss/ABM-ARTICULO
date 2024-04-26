using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using TP2_WinForm.Clases;
using TP2_WinForm.Negocio;
using Dominio;
using Negocio;

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
            listaArticulos = negocio.ListarArticulos();
            dgvArticulo.DataSource = negocio.ListarArticulos();
            Globales.DiseñoDtv(ref dgvArticulo);

            dgvArticulo.Columns["IdArticulo"].Visible = false;
            dgvArticulo.Columns["Imagen"].Visible = false;

            AgregariconoPc.Load(listaArticulos[0].Imagen);
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            Articulos seleccionado = (Articulos)dgvArticulo.CurrentRow.DataBoundItem;
            txtArticuloCodigo.Text = seleccionado.CodArticulo;
            txtArticuloNombre.Text = seleccionado.Nombre;
            txtArticuloDescripcion.Text = seleccionado.Descripcion;
            txtArticuloMarca.Text = seleccionado.Marcas.Descripcion;
            txtArticuloCategoria.Text = seleccionado.Categorias.Descripcion;
            txtArticuloPrecio.Text = seleccionado.Precio.ToString();
            txtArticuloImagenUrl.Text = seleccionado.Imagen;

            //txtArticuloNombre.Text = dgvArticulo.CurrentRow.Cells[2].Value.ToString();

            cargarImagen(seleccionado.Imagen);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                AgregariconoPc.Load(imagen);
            }
            catch (Exception im)
            {
                AgregariconoPc.Load("https://demofree.sirv.com/products/123456/123456.jpg?profile=error-example");
            }
        }

        private void txtArticuloCodigo_Leave(object sender, EventArgs e)
        {
            ArticulosNegocio verificador = new ArticulosNegocio();  
            if(verificador.verificadorDeCodigos(txtArticuloCodigo.Text)==true)
            {
                MessageBox.Show("Codigo existe.Ingrese otro");
                txtArticuloCodigo.Clear();
            }
            if(string.IsNullOrEmpty(txtArticuloCodigo.Text) ) 
            {
                MessageBox.Show("El campo de codigo no puede quedar vacio. Ingrese un codigo por favor");
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
