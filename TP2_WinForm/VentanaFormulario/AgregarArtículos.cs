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
using System.Configuration;
using System.IO;

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

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Articulos articulo = new Articulos();
            try
            {
                articulo.CodArticulo = txtcodarticulo.Text;
                articulo.Nombre = txtnombre.Text;
                articulo.Descripcion = txtdescripcion.Text;
                articulo.Marcas = (Marcas)cbomarca.SelectedItem;
                articulo.Categorias = (Categorias)cbocategoria.SelectedItem;
                articulo.Imagen.ImagenUrl = txturlimagen.Text;

                ArticulosNegocio negocio = new ArticulosNegocio();
                negocio.AgregarArticulo(articulo);
                MessageBox.Show("Agregado exitosamente");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



            /*
            
            try
            {
                if (articulo == null)
                    articulo = new Articulos();

                articulo.CodArticulo = txtcodarticulo.Text;
                articulo.Nombre = txtnombre.Text;
                articulo.Descripcion = txtdescripcion.Text;
                articulo.Marcas = (Marcas)cbomarca.SelectedItem;
                articulo.Categorias = (Categorias)cbocategoria.SelectedItem;
                articulo.Imagen.ImagenUrl = txturlimagen.Text;



                /*
                if (articulo.IdArticulo != 0)
                {
                 //   negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.AgregarArticulo(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }
           
                ////Guardo imagen si la levantó localmente:
                //if (archivo != null && !(txturlimagen.Text.ToUpper().Contains("HTTP")))
                //    File.Copy(archivo.FileName,ConfigurationManager["images-folder"] + archivo.SafeFileName);
                
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            */
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
