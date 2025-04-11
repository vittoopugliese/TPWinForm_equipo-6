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
    public partial class Form1 : Form
    {
        // paneles de cada boton
        private Panel panelArticulos;
        private Panel panelCategorias;
        private Panel panelMarcas;
        private Panel panelConfiguracion;

        private BaseDeDatos bd = new BaseDeDatos();

        private string panelActual = "Articulos";
        public Form1()
        {
            InitializeComponent();
            CrearPaneles();
            ActivarBoton(buttonArticulos);
            MostrarPanel("Articulos");
            CargarArticulos();
        }
        private void CrearPaneles()
        {
            panelArticulos = panelContenido;

            panelCategorias = new Panel();
            panelCategorias.BackColor = SystemColors.ControlLight;
            panelCategorias.Dock = DockStyle.Fill;
            panelCategorias.Location = new Point(189, 0);
            panelCategorias.Name = "panelCategorias";
            panelCategorias.Size = new Size(1018, 660);
            panelCategorias.Visible = false;
            Label labelTituloCategorias = new Label();
            labelTituloCategorias.AutoSize = true;
            labelTituloCategorias.ForeColor = SystemColors.HotTrack;
            labelTituloCategorias.Location = new Point(6, 9);
            labelTituloCategorias.Name = "labelTituloCategorias";
            labelTituloCategorias.Size = new Size(105, 13);
            labelTituloCategorias.Text = "Gestión De Categorías";
            panelCategorias.Controls.Add(labelTituloCategorias);

            panelMarcas = new Panel();
            panelMarcas.BackColor = SystemColors.ControlLight;
            panelMarcas.Dock = DockStyle.Fill;
            panelMarcas.Location = new Point(189, 0);
            panelMarcas.Name = "panelMarcas";
            panelMarcas.Size = new Size(1018, 660);
            panelMarcas.Visible = false;
            Label labelTituloMarcas = new Label();
            labelTituloMarcas.AutoSize = true;
            labelTituloMarcas.ForeColor = SystemColors.HotTrack;
            labelTituloMarcas.Location = new Point(6, 9);
            labelTituloMarcas.Name = "labelTituloMarcas";
            labelTituloMarcas.Size = new Size(105, 13);
            labelTituloMarcas.Text = "Gestión De Marcas";
            panelMarcas.Controls.Add(labelTituloMarcas);

            panelConfiguracion = new Panel();
            panelConfiguracion.BackColor = SystemColors.ControlLight;
            panelConfiguracion.Dock = DockStyle.Fill;
            panelConfiguracion.Location = new Point(189, 0);
            panelConfiguracion.Name = "panelConfiguracion";
            panelConfiguracion.Size = new Size(1018, 660);
            panelConfiguracion.Visible = false;
            Label labelTituloConfiguracion = new Label();
            labelTituloConfiguracion.AutoSize = true;
            labelTituloConfiguracion.ForeColor = SystemColors.HotTrack;
            labelTituloConfiguracion.Location = new Point(6, 9);
            labelTituloConfiguracion.Name = "labelTituloConfiguracion";
            labelTituloConfiguracion.Size = new Size(105, 13);
            labelTituloConfiguracion.Text = "Configuración Del Sistema";
            panelConfiguracion.Controls.Add(labelTituloConfiguracion);

            this.Controls.Add(panelCategorias);
            this.Controls.Add(panelMarcas);
            this.Controls.Add(panelConfiguracion);
        }
        private void MostrarPanel(string nombrePanel) {
            if (nombrePanel == panelActual) return;

            panelArticulos.Visible = false;
            panelCategorias.Visible = false;
            panelMarcas.Visible = false;
            panelConfiguracion.Visible = false;

            switch (nombrePanel) {
                case "Articulos":
                    panelArticulos.Visible = true;
                    break;
                case "Categorias":
                    panelCategorias.Visible = true;
                    break;
                case "Marcas":
                    panelMarcas.Visible = true;
                    break;
                case "Configuracion":
                    panelConfiguracion.Visible = true;
                    break;
            };

            panelActual = nombrePanel;
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

        private void Articulos_Click(object sender, EventArgs e)
        {
            ActivarBoton(buttonArticulos);
            MostrarPanel("Articulos");
        }
        private void buttonCategorias_Click(object sender, EventArgs e)
        {
            ActivarBoton(buttonCategorias);
            MostrarPanel("Categorias");
        }
        private void buttonMarcas_Click(object sender, EventArgs e)
        {
            ActivarBoton(buttonMarcas);
            MostrarPanel("Marcas");
        }
        private void buttonConfiguracion_Click(object sender, EventArgs e)
        {
            ActivarBoton(buttonConfiguracion);
            MostrarPanel("Configuracion");
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
        private void ActivarBoton(Button botonActivo)
        {
            foreach (Control ctrl in panelMenu.Controls)
            {
                if (ctrl is Button)
                {
                    ctrl.BackColor = SystemColors.ControlDark;
                    ctrl.ForeColor = SystemColors.Highlight;
                    ctrl.Font = new Font("Segoe UI", 9);
                }
            }
            ;
            botonActivo.BackColor = Color.FromArgb(0, 120, 215);
            botonActivo.ForeColor = Color.White;
            botonActivo.Font = new Font("Segoe UI", 9, FontStyle.Bold);
        }
    }
}