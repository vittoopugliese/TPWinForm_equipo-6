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
    public partial class frmPrincipal : Form
    {
        private BaseDeDatos bd = new BaseDeDatos();
        private Articulo articuloSeleccionado = null;

        public frmPrincipal()
        {
            InitializeComponent();
            CargarArticulos();
        }

        private void CargarArticulos()
        {
            try
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                List<Articulo> listaArticulos = articuloNegocio.Listar();

                dataGridViewArticulos.DataSource = listaArticulos;

                dataGridViewArticulos.Columns["Id"].Visible = false;
                dataGridViewArticulos.Columns["IdMarca"].Visible = false;
                dataGridViewArticulos.Columns["IdCategoria"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los artículos: " + ex.Message);
            }
        }

        private void buttonCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias categorias = new frmCategorias();
            categorias.ShowDialog();
        }

        private void buttonMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas marcas = new frmMarcas();
            marcas.ShowDialog();
        }

        private void dataGridViewArticulos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridViewArticulos.Rows[e.RowIndex].Selected = true;
                articuloSeleccionado = (Articulo)dataGridViewArticulos.CurrentRow.DataBoundItem;
            }
        }

        private void buttonDetalleArt_Click(object sender, EventArgs e)
        {
            if (articuloSeleccionado != null)
            {
                frmArticuloDetalle detalle = new frmArticuloDetalle(articuloSeleccionado);
                detalle.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un artículo para ver sus detalles.");
            }
        }
    }
}