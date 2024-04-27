using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_WinForm;
using TP2_WinForm.Negocio;
using Dominio;
using Negocio;


namespace TP2_WinForm.VentanaFormulario
{
    public partial class MenuPrincipal : Form
    {
        private List<Articulos> ListaArticulos;
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tsmContacto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicación desarrollada por Ismael Oreste, Pedro Bernabé Quirós y Facundo Nahuel Pino.");
        }

        private void tsmAgregarArticulo_Click(object sender, EventArgs e)
        {
            AgregarArtículos ventana = new AgregarArtículos();

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(AgregarArtículos))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            
            ventana.ShowDialog();
        }

        private void tsmListarArticulos_Click(object sender, EventArgs e)
        {
            ListadoArticulos ventana = new ListadoArticulos();
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ListadoArticulos))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            
           ventana.ShowDialog();
        }

        private void tsmBuscarArticulo_Click(object sender, EventArgs e)
        {
            BuscarArticulo ventana = new BuscarArticulo();
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(BuscarArticulo))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            ventana.ShowDialog();
        }

        private void tsmModificarArticulo_Click(object sender, EventArgs e)
        {
            Modificar_artículos ventana = new Modificar_artículos();

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Modificar_artículos))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            ventana.ShowDialog();
        }

        private void tsmDetallarArticulo_Click(object sender, EventArgs e)
        {
            DetalleArticulo ventana = new DetalleArticulo();
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(DetalleArticulo))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            ventana.ShowDialog();
        }

        private void tsmEliminarArticulo_Click(object sender, EventArgs e)
        {
            Eliminar ventana = new Eliminar();
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Eliminar))
                {
                    MessageBox.Show("No es posible abrir otra ventana");
                    return;
                }
            }
            ventana.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            ArticulosNegocio Articulo = new ArticulosNegocio();
            Globales.DiseñoDtv(ref dgvListaArt);
            ListaArticulos = Articulo.ListarArticulos();
            dgvListaArt.DataSource = ListaArticulos;
            Globales.OcultarColumnas(ref dgvListaArt);

        }
        
        private void tsbLinkedinMaxi_Click(object sender, EventArgs e)
        {

        }

        private void dgvListaArt_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvListaArt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelArticulos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
