﻿using System;
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
            
            dgvArticulo.Columns["CodArticulo"].Visible = false;
            dgvArticulo.Columns["IdArticulo"].Visible = false;
            dgvArticulo.Columns["IdCategoria"].Visible = false;
            dgvArticulo.Columns["IdMarca"].Visible = false;
            dgvArticulo.Columns["Imagen"].Visible = false;
            dgvArticulo.Columns["Marcas"].Visible = false;
            dgvArticulo.Columns["Categorias"].Visible = false;
            AgregariconoPc.Load(listaArticulos[0].Imagen.ImagenUrl);
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            Articulos seleccionado = (Articulos)dgvArticulo.CurrentRow.DataBoundItem;
            txtArticuloCodigo.Text = seleccionado.CodArticulo;
            txtArticuloNombre.Text = seleccionado.Nombre;
            
            //txtArticuloNombre.Text = dgvArticulo.CurrentRow.Cells[2].Value.ToString();
            txtArticuloMarca.Text = seleccionado.Marcas.Descripcion;
            txtArticuloDescripcion.Text = seleccionado.Descripcion;
            txtArticuloCategoria.Text = seleccionado.Categorias.Descripcion;

            txtArticuloPrecio.Text = seleccionado.Precio.ToString();
            txtArticuloCodigo.Text = seleccionado.CodArticulo;
            txtArticuloImagenUrl.Text = seleccionado.Imagen.ImagenUrl;





            cargarImagen(seleccionado.Imagen.ImagenUrl);
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


    }
}
