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
        private ArticuloNegocio articuloNegocio;

        private List<Imagen> imagenes;
        private ImagenNegocio imagenNegocio;

        public frmArticuloDetalle(Articulo articuloSeleccionado)
        {
            // Constructor de EDICION ...
            InitializeComponent();

            imagenNegocio = new ImagenNegocio();
            articuloNegocio = new ArticuloNegocio();

            articulo = articuloSeleccionado;

            buttonEfectuarEdicionDetalle.Text = "Efectuar Edición";

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

            if (imagenes != null && imagenes.Count > 0)
            {
                Console.WriteLine(imagenes[0].imagenUrl);
                try
                {
                    pictureBoxImagenPrincipalDetalle.LoadAsync(imagenes[0].imagenUrl);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public frmArticuloDetalle()
        {
            // Constructor de CREACION ...
            InitializeComponent();

            imagenNegocio = new ImagenNegocio();
            articuloNegocio = new ArticuloNegocio();

            buttonEfectuarEdicionDetalle.Text = "Crear Nuevo";
        }

        private void buttonEfectuarEdicionDetalle_Click(object sender, EventArgs e)
        {
            // validar antes de entrar al try todas los posibles errores o faltas de completar algun campo
            try
            {
                Articulo nuevoArticulo = new Articulo();

                nuevoArticulo.Codigo = textBoxCodigoDetalle.Text;
                nuevoArticulo.Nombre = textBoxNombreDetalle.Text;
                nuevoArticulo.Descripcion = textBoxDescripcionDetalle.Text;
                nuevoArticulo.Precio = decimal.Parse(textBoxPrecioDetalle.Text);
                // falta hacer el dropdown de categorias y marcas, y que luego
                // agarre esa marca o categoria y obtenga su ID y agregarselo al nuevoArticulo
                nuevoArticulo.IdMarca = int.Parse(textBoxIdMarcaDetalle.Text);
                nuevoArticulo.IdCategoria = int.Parse(textBoxIdCategoriaDetalle.Text);

                if (buttonEfectuarEdicionDetalle.Text == "Efectuar Edición")
                {
                    nuevoArticulo.Id = articulo.Id;
                    articuloNegocio.EditarArticuloExistente(nuevoArticulo);

                    MessageBox.Show("Artículo modificado correctamente");
                }
                else
                {
                    articuloNegocio.CrearNuevoArticulo(nuevoArticulo);

                    MessageBox.Show("Artículo creado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios" + ex.Message);
            }
            finally
            {
                // cierra el ShowDialog()
                this.Close();
            }
        }

        private void buttonDescartarDetalle_Click(object sender, EventArgs e)
        {
            // descartar edicion solo cierra el dialogo jeje
            this.Close();
        }
    }
}
