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
    public partial class Modificar_artículos : Form
    {
        private List<Articulos> listaArticulos;

        public Modificar_artículos()
        {
            InitializeComponent();
        }

        private void Modificar_artículos_Load(object sender, EventArgs e)
        {
            Globales.DiseñoDtv(ref dgvArticulos);

            cargarArticulos();

            /*
            Articulos articulo = new Articulos();
            articulo = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

            CategoriasNegocios categoriasNegocios = new CategoriasNegocios();
            MarcasNegocio marcasNegocio = new MarcasNegocio();

            try
            {
                cboCategoria.DataSource = categoriasNegocios.listarCategorias();
                cboCategoria.ValueMember = "IdCategoria";
                cboCategoria.DisplayMember = "Descripcion";
                cboMarca.DataSource = marcasNegocio.listarMarcas();
                cboMarca.ValueMember = "IdMarca";
                cboMarca.DisplayMember = "Descripcion";


                txtCodArticulo.Text = articulo.CodArticulo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                txtPrecio.Text = articulo.Precio.ToString();
                txtImagen.Text = articulo.Imagen.ToString();
                cargarImagen(articulo.Imagen);
                cboMarca.SelectedValue = articulo.Marcas.IdMarcas;
                cboCategoria.SelectedValue = articulo.Categorias.IdCategoria;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            */
        }

        public void cargarArticulos()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            listaArticulos = negocio.ListarArticulos();
            dgvArticulos.DataSource = negocio.ListarArticulos();
            Globales.DiseñoDtv(ref dgvArticulos);
            dgvArticulos.Columns["IdArticulo"].Visible = false;
            dgvArticulos.Columns["Imagen"].Visible = false;
            AgregariconoPc.Load(listaArticulos[0].Imagen);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                AgregariconoPc.Load(imagen);
            }
            catch (Exception ex)
            {
                AgregariconoPc.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/a/ac/Escudo_del_C_A_River_Plate.svg/1200px-Escudo_del_C_A_River_Plate.svg.png");
            }
        }

        private void dgvArticulos_Leave(object sender, EventArgs e)
        {
           /*
            Articulos articuloo = new Articulos();
            articuloo = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

            return articuloo;
            */
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {

            Articulos articulo = new Articulos();
            articulo = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;

            CategoriasNegocios categoriasNegocios = new CategoriasNegocios();
            MarcasNegocio marcasNegocio = new MarcasNegocio();

            try
            {
                cboCategoria.DataSource = categoriasNegocios.listarCategorias();
                cboCategoria.ValueMember = "IdCategoria";
                cboCategoria.DisplayMember = "Descripcion";
                cboMarca.DataSource = marcasNegocio.listarMarcas();
                cboMarca.ValueMember = "IdMarca";
                cboMarca.DisplayMember = "Descripcion";

                txtCodArticulo.Text = articulo.CodArticulo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                txtPrecio.Text = articulo.Precio.ToString();
                txtImagen.Text = articulo.Imagen.ToString();
                cargarImagen(articulo.Imagen);
                cboMarca.SelectedValue = articulo.Marcas.IdMarca;
                cboCategoria.SelectedValue = articulo.Categorias.IdCategoria;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio articulosNegocio = new ArticulosNegocio();
            Articulos articulo = new Articulos();  
            try
            {
                if(articulosNegocio.verificadorDeCodigos(articulo.CodArticulo)==true && articulo.CodArticulo != txtCodArticulo.Text)
                {
                    MessageBox.Show("El codigo ya existe. Ingrese otro");
                }
                else
                {
                  articulo.CodArticulo = txtCodArticulo.Text;
                }
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marcas = (Marcas) cboMarca.SelectedItem;
                articulo.Categorias = (Categorias) cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Imagen = txtImagen.Text;

                articulosNegocio.ModificarArticulo(articulo);
                MessageBox.Show("Modificado exitosamente");

                Close ();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
