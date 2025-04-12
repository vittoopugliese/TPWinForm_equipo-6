namespace TPWinForm_equipo_6
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonMarcas = new System.Windows.Forms.Button();
            this.buttonCategorias = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.dataGridViewArticulos = new System.Windows.Forms.DataGridView();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.buttonDetalleArt = new System.Windows.Forms.Button();
            this.buttonEliminarArt = new System.Windows.Forms.Button();
            this.buttonEditarArt = new System.Windows.Forms.Button();
            this.buttonNuevoArt = new System.Windows.Forms.Button();
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.labelFiltroDescripcion = new System.Windows.Forms.Label();
            this.labelFiltroCategoria = new System.Windows.Forms.Label();
            this.labelFiltroMarca = new System.Windows.Forms.Label();
            this.labelFiltroNombre = new System.Windows.Forms.Label();
            this.labelFiltroCodigo = new System.Windows.Forms.Label();
            this.buttonBuscarArticulos = new System.Windows.Forms.Button();
            this.textBoxFiltroDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxFiltroCategoria = new System.Windows.Forms.TextBox();
            this.textBoxFiltroMarca = new System.Windows.Forms.TextBox();
            this.textBoxFiltroNombre = new System.Windows.Forms.TextBox();
            this.textBoxFiltroCodigo = new System.Windows.Forms.TextBox();
            this.labelTituloArticulos = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulos)).BeginInit();
            this.groupBoxFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.Control;
            this.panelMenu.Controls.Add(this.buttonMarcas);
            this.panelMenu.Controls.Add(this.buttonCategorias);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(189, 660);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonMarcas
            // 
            this.buttonMarcas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMarcas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonMarcas.Location = new System.Drawing.Point(0, 330);
            this.buttonMarcas.Name = "buttonMarcas";
            this.buttonMarcas.Size = new System.Drawing.Size(189, 330);
            this.buttonMarcas.TabIndex = 3;
            this.buttonMarcas.Text = "Marcas";
            this.buttonMarcas.UseVisualStyleBackColor = false;
            this.buttonMarcas.Click += new System.EventHandler(this.buttonMarcas_Click);
            // 
            // buttonCategorias
            // 
            this.buttonCategorias.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategorias.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonCategorias.Location = new System.Drawing.Point(0, 0);
            this.buttonCategorias.Name = "buttonCategorias";
            this.buttonCategorias.Size = new System.Drawing.Size(189, 330);
            this.buttonCategorias.TabIndex = 2;
            this.buttonCategorias.Text = "Categorias";
            this.buttonCategorias.UseVisualStyleBackColor = false;
            this.buttonCategorias.Click += new System.EventHandler(this.buttonCategorias_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.Controls.Add(this.dataGridViewArticulos);
            this.panelContenido.Controls.Add(this.buttonExportar);
            this.panelContenido.Controls.Add(this.buttonDetalleArt);
            this.panelContenido.Controls.Add(this.buttonEliminarArt);
            this.panelContenido.Controls.Add(this.buttonEditarArt);
            this.panelContenido.Controls.Add(this.buttonNuevoArt);
            this.panelContenido.Controls.Add(this.groupBoxFiltros);
            this.panelContenido.Controls.Add(this.labelTituloArticulos);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelContenido.Location = new System.Drawing.Point(189, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1018, 660);
            this.panelContenido.TabIndex = 1;
            // 
            // dataGridViewArticulos
            // 
            this.dataGridViewArticulos.AllowUserToAddRows = false;
            this.dataGridViewArticulos.AllowUserToDeleteRows = false;
            this.dataGridViewArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArticulos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewArticulos.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewArticulos.Location = new System.Drawing.Point(9, 171);
            this.dataGridViewArticulos.Name = "dataGridViewArticulos";
            this.dataGridViewArticulos.ReadOnly = true;
            this.dataGridViewArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArticulos.Size = new System.Drawing.Size(994, 477);
            this.dataGridViewArticulos.TabIndex = 7;
            this.dataGridViewArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonExportar
            // 
            this.buttonExportar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonExportar.Location = new System.Drawing.Point(894, 126);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(109, 39);
            this.buttonExportar.TabIndex = 6;
            this.buttonExportar.Text = "Exportar";
            this.buttonExportar.UseVisualStyleBackColor = false;
            // 
            // buttonDetalleArt
            // 
            this.buttonDetalleArt.BackColor = System.Drawing.Color.Gold;
            this.buttonDetalleArt.Location = new System.Drawing.Point(354, 126);
            this.buttonDetalleArt.Name = "buttonDetalleArt";
            this.buttonDetalleArt.Size = new System.Drawing.Size(109, 39);
            this.buttonDetalleArt.TabIndex = 5;
            this.buttonDetalleArt.Text = "Ver Detalle";
            this.buttonDetalleArt.UseVisualStyleBackColor = false;
            // 
            // buttonEliminarArt
            // 
            this.buttonEliminarArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.buttonEliminarArt.Location = new System.Drawing.Point(239, 126);
            this.buttonEliminarArt.Name = "buttonEliminarArt";
            this.buttonEliminarArt.Size = new System.Drawing.Size(109, 39);
            this.buttonEliminarArt.TabIndex = 4;
            this.buttonEliminarArt.Text = "Eliminar";
            this.buttonEliminarArt.UseVisualStyleBackColor = false;
            // 
            // buttonEditarArt
            // 
            this.buttonEditarArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.buttonEditarArt.Location = new System.Drawing.Point(124, 126);
            this.buttonEditarArt.Name = "buttonEditarArt";
            this.buttonEditarArt.Size = new System.Drawing.Size(109, 39);
            this.buttonEditarArt.TabIndex = 3;
            this.buttonEditarArt.Text = "Editar";
            this.buttonEditarArt.UseVisualStyleBackColor = false;
            // 
            // buttonNuevoArt
            // 
            this.buttonNuevoArt.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonNuevoArt.Location = new System.Drawing.Point(9, 126);
            this.buttonNuevoArt.Name = "buttonNuevoArt";
            this.buttonNuevoArt.Size = new System.Drawing.Size(109, 39);
            this.buttonNuevoArt.TabIndex = 2;
            this.buttonNuevoArt.Text = "Nuevo";
            this.buttonNuevoArt.UseVisualStyleBackColor = false;
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxFiltros.Controls.Add(this.labelFiltroDescripcion);
            this.groupBoxFiltros.Controls.Add(this.labelFiltroCategoria);
            this.groupBoxFiltros.Controls.Add(this.labelFiltroMarca);
            this.groupBoxFiltros.Controls.Add(this.labelFiltroNombre);
            this.groupBoxFiltros.Controls.Add(this.labelFiltroCodigo);
            this.groupBoxFiltros.Controls.Add(this.buttonBuscarArticulos);
            this.groupBoxFiltros.Controls.Add(this.textBoxFiltroDescripcion);
            this.groupBoxFiltros.Controls.Add(this.textBoxFiltroCategoria);
            this.groupBoxFiltros.Controls.Add(this.textBoxFiltroMarca);
            this.groupBoxFiltros.Controls.Add(this.textBoxFiltroNombre);
            this.groupBoxFiltros.Controls.Add(this.textBoxFiltroCodigo);
            this.groupBoxFiltros.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBoxFiltros.Location = new System.Drawing.Point(9, 29);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(994, 91);
            this.groupBoxFiltros.TabIndex = 1;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros";
            this.groupBoxFiltros.Enter += new System.EventHandler(this.groupBoxFiltros_Enter);
            // 
            // labelFiltroDescripcion
            // 
            this.labelFiltroDescripcion.AutoSize = true;
            this.labelFiltroDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFiltroDescripcion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelFiltroDescripcion.Location = new System.Drawing.Point(6, 53);
            this.labelFiltroDescripcion.Name = "labelFiltroDescripcion";
            this.labelFiltroDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labelFiltroDescripcion.TabIndex = 8;
            this.labelFiltroDescripcion.Text = "Descripcion:";
            // 
            // labelFiltroCategoria
            // 
            this.labelFiltroCategoria.AutoSize = true;
            this.labelFiltroCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFiltroCategoria.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelFiltroCategoria.Location = new System.Drawing.Point(716, 27);
            this.labelFiltroCategoria.Name = "labelFiltroCategoria";
            this.labelFiltroCategoria.Size = new System.Drawing.Size(55, 13);
            this.labelFiltroCategoria.TabIndex = 7;
            this.labelFiltroCategoria.Text = "Categoria:";
            // 
            // labelFiltroMarca
            // 
            this.labelFiltroMarca.AutoSize = true;
            this.labelFiltroMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFiltroMarca.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelFiltroMarca.Location = new System.Drawing.Point(488, 27);
            this.labelFiltroMarca.Name = "labelFiltroMarca";
            this.labelFiltroMarca.Size = new System.Drawing.Size(40, 13);
            this.labelFiltroMarca.TabIndex = 6;
            this.labelFiltroMarca.Text = "Marca:";
            // 
            // labelFiltroNombre
            // 
            this.labelFiltroNombre.AutoSize = true;
            this.labelFiltroNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFiltroNombre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelFiltroNombre.Location = new System.Drawing.Point(253, 27);
            this.labelFiltroNombre.Name = "labelFiltroNombre";
            this.labelFiltroNombre.Size = new System.Drawing.Size(47, 13);
            this.labelFiltroNombre.TabIndex = 5;
            this.labelFiltroNombre.Text = "Nombre:";
            // 
            // labelFiltroCodigo
            // 
            this.labelFiltroCodigo.AutoSize = true;
            this.labelFiltroCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFiltroCodigo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelFiltroCodigo.Location = new System.Drawing.Point(6, 27);
            this.labelFiltroCodigo.Name = "labelFiltroCodigo";
            this.labelFiltroCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelFiltroCodigo.TabIndex = 2;
            this.labelFiltroCodigo.Text = "Codigo:";
            // 
            // buttonBuscarArticulos
            // 
            this.buttonBuscarArticulos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBuscarArticulos.Location = new System.Drawing.Point(850, 49);
            this.buttonBuscarArticulos.Name = "buttonBuscarArticulos";
            this.buttonBuscarArticulos.Size = new System.Drawing.Size(101, 23);
            this.buttonBuscarArticulos.TabIndex = 4;
            this.buttonBuscarArticulos.Text = "Buscar!";
            this.buttonBuscarArticulos.UseVisualStyleBackColor = true;
            this.buttonBuscarArticulos.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxFiltroDescripcion
            // 
            this.textBoxFiltroDescripcion.Location = new System.Drawing.Point(73, 50);
            this.textBoxFiltroDescripcion.Name = "textBoxFiltroDescripcion";
            this.textBoxFiltroDescripcion.Size = new System.Drawing.Size(774, 20);
            this.textBoxFiltroDescripcion.TabIndex = 3;
            this.textBoxFiltroDescripcion.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxFiltroCategoria
            // 
            this.textBoxFiltroCategoria.Location = new System.Drawing.Point(777, 24);
            this.textBoxFiltroCategoria.Name = "textBoxFiltroCategoria";
            this.textBoxFiltroCategoria.Size = new System.Drawing.Size(174, 20);
            this.textBoxFiltroCategoria.TabIndex = 2;
            this.textBoxFiltroCategoria.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxFiltroMarca
            // 
            this.textBoxFiltroMarca.Location = new System.Drawing.Point(534, 24);
            this.textBoxFiltroMarca.Name = "textBoxFiltroMarca";
            this.textBoxFiltroMarca.Size = new System.Drawing.Size(174, 20);
            this.textBoxFiltroMarca.TabIndex = 1;
            this.textBoxFiltroMarca.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxFiltroNombre
            // 
            this.textBoxFiltroNombre.Location = new System.Drawing.Point(306, 24);
            this.textBoxFiltroNombre.Name = "textBoxFiltroNombre";
            this.textBoxFiltroNombre.Size = new System.Drawing.Size(174, 20);
            this.textBoxFiltroNombre.TabIndex = 1;
            this.textBoxFiltroNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxFiltroCodigo
            // 
            this.textBoxFiltroCodigo.Location = new System.Drawing.Point(73, 24);
            this.textBoxFiltroCodigo.Name = "textBoxFiltroCodigo";
            this.textBoxFiltroCodigo.Size = new System.Drawing.Size(174, 20);
            this.textBoxFiltroCodigo.TabIndex = 1;
            this.textBoxFiltroCodigo.TextChanged += new System.EventHandler(this.textBoxFiltroCodigo_TextChanged);
            // 
            // labelTituloArticulos
            // 
            this.labelTituloArticulos.AutoSize = true;
            this.labelTituloArticulos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelTituloArticulos.Location = new System.Drawing.Point(6, 9);
            this.labelTituloArticulos.Name = "labelTituloArticulos";
            this.labelTituloArticulos.Size = new System.Drawing.Size(105, 13);
            this.labelTituloArticulos.TabIndex = 1;
            this.labelTituloArticulos.Text = "Gestión De Artículos";
            this.labelTituloArticulos.Click += new System.EventHandler(this.labelTituloArticulos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1207, 660);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Catálogo - Sistema de Administración";
            this.panelMenu.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulos)).EndInit();
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonMarcas;
        private System.Windows.Forms.Button buttonCategorias;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label labelTituloArticulos;
        private System.Windows.Forms.GroupBox groupBoxFiltros;
        private System.Windows.Forms.TextBox textBoxFiltroMarca;
        private System.Windows.Forms.TextBox textBoxFiltroNombre;
        private System.Windows.Forms.TextBox textBoxFiltroCodigo;
        private System.Windows.Forms.TextBox textBoxFiltroCategoria;
        private System.Windows.Forms.TextBox textBoxFiltroDescripcion;
        private System.Windows.Forms.Button buttonBuscarArticulos;
        private System.Windows.Forms.Label labelFiltroCategoria;
        private System.Windows.Forms.Label labelFiltroMarca;
        private System.Windows.Forms.Label labelFiltroNombre;
        private System.Windows.Forms.Label labelFiltroCodigo;
        private System.Windows.Forms.Label labelFiltroDescripcion;
        private System.Windows.Forms.Button buttonExportar;
        private System.Windows.Forms.Button buttonDetalleArt;
        private System.Windows.Forms.Button buttonEliminarArt;
        private System.Windows.Forms.Button buttonEditarArt;
        private System.Windows.Forms.Button buttonNuevoArt;
        private System.Windows.Forms.DataGridView dataGridViewArticulos;
    }
}

