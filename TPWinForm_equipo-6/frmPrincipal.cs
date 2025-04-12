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

        public frmPrincipal()
        {
            InitializeComponent();
            CargarArticulos();
        }

        private void CargarArticulos()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                List<Articulo> listaArticulos = negocio.Listar();

                dataGridViewArticulos.DataSource = listaArticulos;

                dataGridViewArticulos.Columns["Id"].Visible = false;
                dataGridViewArticulos.Columns["IdMarca"].Visible = false;
                dataGridViewArticulos.Columns["IdCategoria"].Visible = false;

                dataGridViewArticulos.Columns["Codigo"].HeaderText = "Código";
                dataGridViewArticulos.Columns["Descripcion"].HeaderText = "Descripción";
                dataGridViewArticulos.Columns["Marca"].HeaderText = "Marca";
                dataGridViewArticulos.Columns["Categoria"].HeaderText = "Categoría";
                dataGridViewArticulos.Columns["Precio"].HeaderText = "Precio";

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
        private void labelTituloArticulos_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBoxFiltroCodigo_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
        }
        private void groupBoxFiltros_Enter(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}