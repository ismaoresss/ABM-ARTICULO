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
    public partial class BuscarArticulo : Form
    {
        private List<Articulos> ListaArticulos;
        

        public BuscarArticulo()
        {
            InitializeComponent();
        }

        private void lbl_BuscarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void lbl_buscarPor_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnvolverArticulo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbl_Buscar_Click(object sender, EventArgs e)
        {

        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            //Criterio de filtracion: Nombre o Codigo de Articulo con al menos 2 caracteres
            List<Articulos> listaFiltrada;
            string filtro = txt_buscar.Text.ToLower();

            if(filtro.Length >= 2)
            {
                listaFiltrada = ListaArticulos.FindAll(X => X.Nombre.ToLower().Contains(filtro) || X.CodArticulo.ToLower().Contains(filtro));
            }
            else
            {
                listaFiltrada = ListaArticulos;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;

            //Ocultar columnas
            dgvArticulos.Columns["IdArticulo"].Visible = false;
            dgvArticulos.Columns["Imagen"].Visible = false;

        }

        private void BuscarArticulo_Load(object sender, EventArgs e)
        {
            ArticulosNegocio Articulo = new ArticulosNegocio();
            Globales.DiseñoDtv(ref dgvArticulos);
            ListaArticulos = Articulo.ListarArticulos();

            dgvArticulos.DataSource = ListaArticulos;

            //Ocultar columnas
            dgvArticulos.Columns["IdArticulo"].Visible = false;
            dgvArticulos.Columns["Imagen"].Visible = false;
        }

    }
}
