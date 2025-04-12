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
            // creo lista de categorias para luego remplazarlas en el articulo por su nombre
            bd.setearConsulta("SELECT * FROM CATEGORIAS");
            bd.ejecutarLectura();
            var listaCategorias = new Dictionary<int, string>();
            while (bd.Lector.Read()) listaCategorias.Add(Convert.ToInt32(bd.Lector["Id"]), bd.Lector["Descripcion"].ToString());
            bd.cerrarConexion();

            // creo lista de marcas para luego remplazarlas por su nombre en articulo
            bd.setearConsulta("SELECT * FROM MARCAS");
            bd.ejecutarLectura();
            var listaMarcas = new Dictionary<int, string>();
            while (bd.Lector.Read()) listaMarcas.Add(Convert.ToInt32(bd.Lector["Id"]), bd.Lector["Descripcion"].ToString());
            bd.cerrarConexion();

            // traigo todos los articulos para mapear todas las propiedades anteriores y mostrar el resultado en tabla
            bd.setearConsulta("SELECT * FROM ARTICULOS");
            bd.ejecutarLectura();

            // limpiar tabla de resultados previos
            dataGridViewArticulos.Rows.Clear();

            while (bd.Lector.Read())
            {
                int idMarca = Convert.ToInt32(bd.Lector["IdMarca"]);
                int idCategoria = Convert.ToInt32(bd.Lector["IdCategoria"]);

                string nombreMarca = listaMarcas.ContainsKey(idMarca) ? listaMarcas[idMarca] : "-- Sin Marca --";
                string nombreCategoria = listaCategorias.ContainsKey(idCategoria) ? listaCategorias[idCategoria] : "-- Sin Categoria --";

                // los datos SI O SI se ponen en la grid por como estan declaradas las tablas, mismo orden
                // bd.Lector[key] lo que hace es agarrar el ultimo resultado traido de la bbdd y segund la key pone ese value
                dataGridViewArticulos.Rows.Add(
                    bd.Lector["Codigo"].ToString(),
                    bd.Lector["Nombre"].ToString(),
                    nombreMarca, nombreCategoria,
                    bd.Lector["Descripcion"].ToString(),
                    bd.Lector["Precio"].ToString(),
                    bd.Lector["Id"].ToString()
                );
            }

            bd.cerrarConexion();
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