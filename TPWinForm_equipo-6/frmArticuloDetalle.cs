using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_6
{
    public partial class frmArticuloDetalle : Form
    {
        private Articulo articulo;
        public frmArticuloDetalle(Articulo articuloSeleccionado)
        {
            InitializeComponent();
            articulo = articuloSeleccionado;
            textBoxNombreDetalle.Text = articulo.Nombre;
            textBoxMarcaDetalle.Text = articulo.Marca.Descripcion;
            textBoxCategoriaDetalle.Text = articulo.Categoria.Descripcion;
            textBoxPrecioDetalle.Text = articulo.Precio.ToString();
            textBoxCodigoDetalle.Text = articulo.Codigo.ToString();
            textBoxIdCategoriaDetalle.Text = articulo.IdCategoria.ToString();
            textBoxIdMarcaDetalle.Text = articulo.IdMarca.ToString();
            textBoxDescripcionDetalle.Text = articulo.Descripcion.ToString();
        }
    }
}
