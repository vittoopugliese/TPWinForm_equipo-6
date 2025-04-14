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
        private List<Imagen> imagenes;
        private ImagenNegocio imagenNegocio;
        public frmArticuloDetalle(Articulo articuloSeleccionado)
        {
            InitializeComponent();

            imagenNegocio = new ImagenNegocio();
            articulo = articuloSeleccionado;

            textBoxIdDetalle.Text = articulo.Id.ToString();
            textBoxNombreDetalle.Text = articulo.Nombre;
            textBoxMarcaDetalle.Text = articulo.Marca.Descripcion;
            textBoxCategoriaDetalle.Text = articulo.Categoria.Descripcion;
            textBoxPrecioDetalle.Text = articulo.Precio.ToString();
            textBoxCodigoDetalle.Text = articulo.Codigo.ToString();
            textBoxIdCategoriaDetalle.Text = articulo.IdCategoria.ToString();
            textBoxIdMarcaDetalle.Text = articulo.IdMarca.ToString();
            textBoxDescripcionDetalle.Text = articulo.Descripcion.ToString();

            imagenes = imagenNegocio.ListarPorArticulo(articulo.Id);

            if (imagenes != null && imagenes.Count > 0) {
                Console.WriteLine(imagenes[0].imagenUrl);
                try
                {
                    pictureBoxImagenPrincipalDetalle.LoadAsync(imagenes[0].imagenUrl);
                } 
                catch (Exception ex){
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
