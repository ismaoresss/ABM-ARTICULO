using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TP2_WinForm.Negocio;
using Dominio;
using Negocio;
using System.IO;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;


namespace TP2_WinForm.VentanaFormulario
{
    public partial class AgregarArtículos : Form
    {
        private Articulos articulo = null;
        private OpenFileDialog archivo = null;
        public AgregarArtículos()
        {
            InitializeComponent();
        }

        public object ConfigurationManager { get; private set; }

        private void AgregarArtículos_Load(object sender, EventArgs e)
        {   
            MarcasNegocio negocioMarcas = new MarcasNegocio();
            cbomarca.DataSource = negocioMarcas.listarMarcas();
            cbomarca.ValueMember = "IdMarca";
            cbomarca.DisplayMember = "Descripcion";

            CategoriasNegocios negocioCategorias = new CategoriasNegocios();
            cbocategoria.DataSource = negocioCategorias.listarCategorias();
            cbocategoria.ValueMember = "IdCategoria";
            cbocategoria.DisplayMember = "Descripcion";
        }


        private void btnguardar_Click(object sender, EventArgs e)
        {
            Articulos nuevoArticulo = new Articulos();
            Imagenes nuevaImagen = new Imagenes();
            Negocio.ArticulosNegocio nuevoManager = new Negocio.ArticulosNegocio();
            ArticulosNegocio imagenes = new ArticulosNegocio();
            MemoryStream ms = new MemoryStream();

            try
            {
                if (nuevoManager.verificadorDeCodigos(nuevoArticulo.CodArticulo) == true)
                {
                    MessageBox.Show("El codigo ya existe. Ingrese otro");
                }
                else
                {
                    nuevoArticulo.CodArticulo = txtcodarticulo.Text;
                }

                if (string.IsNullOrEmpty(nuevoArticulo.CodArticulo))
                {
                    MessageBox.Show("El campo de código no puede quedar vacío. Ingrese uno por favor");
                    return;
                }

                nuevoArticulo.Nombre = txtnombre.Text;
                nuevoArticulo.Descripcion = txtdescripcion.Text;

                if (string.IsNullOrEmpty(nuevoArticulo.Nombre))
                {
                    MessageBox.Show("No se ha ingresado un nombre al artículo");
                    return;
                }

                if (cbocategoria.SelectedValue != null)
                {
                    nuevoArticulo.Categorias.IdCategoria = (int)cbocategoria.SelectedValue;
                }

                if (cbomarca.SelectedValue != null)
                {
                    nuevoArticulo.Marcas.IdMarca = (int)cbomarca.SelectedValue;
                }

                nuevoArticulo.Imagen = (string)txturlimagen.Text;

                decimal verificadorNumero;

                if (decimal.TryParse((txtprecio.Text), out verificadorNumero))
                {
                    nuevoArticulo.Precio = decimal.Parse(txtprecio.Text);
                }
                else
                {
                    MessageBox.Show("Ingresar sólo números en el precio por favor");
                    return;
                }
                

                //if (archivo != null && !(txturlimagen.Text.ToUpper().Contains("HTTP")))

                //    File.Copy(archivo.FileName, ConfigurationManager.AppSetting["Acceso rápido"] + archivo.SafeFileName);


                nuevoManager.AgregarArticulo(nuevoArticulo);
                imagenes.AgregarImagen(nuevoArticulo);
                MessageBox.Show("Artículo agregado exitosamente");


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

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void txtcodarticulo_Leave(object sender, EventArgs e)
        {
            ArticulosNegocio verificador = new ArticulosNegocio();
            if (verificador.verificadorDeCodigos(txtcodarticulo.Text) == true)
            {
                MessageBox.Show("Codigo existe.Ingrese otro");
                txtcodarticulo.Clear();
            }
            if (string.IsNullOrEmpty(txtcodarticulo.Text))
            {
                MessageBox.Show("El campo de codigo no puede quedar vacio. Ingrese un codigo por favor");
            }
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodarticulo.Text))
            {
                MessageBox.Show("No se ha ingresado un nombre al artículo");
                return;
            }
        }

        private void txtprecio_Leave(object sender, EventArgs e)
        {
           
        }

        private void txturlimagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txturlimagen.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                AgregariconoPc.Load(imagen);
            }
            catch (Exception)
            { AgregariconoPc.Load("https://i.pinimg.com/564x/a5/6e/f6/a56ef61429307a58fbcbb16139d623f6.jpg"); }
        }

        private void txtcodarticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Globales.decimales(txtprecio, e);
        }

        private void AgregariconoPc_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregarimg_Click(object sender, EventArgs e)
        {
            //ArticulosNegocio nego = new ArticulosNegocio();

            //d.InitialDirectory = "";
            //archivo.Filter = "Imagenes|*.jpg;*.png";
            //archivo.FilterIndex = 2;
            //archivo.Title = "Cargador de imagenes";
            //if (archivo.ShowDialog() == DialogResult.OK)
            //{
            //    AgregariconoPc.BackgroundImage = null;
            //    AgregariconoPc.Image = new Bitmap(archivo.FileName);
            //    cargarImagen(archivo.FileName);
                
            //}
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

