
namespace FACTURACION_INVENTARIO
{
    partial class FrmProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducto));
            this.dataGridViewProducto = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActulizar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.CmbProveedores = new System.Windows.Forms.ComboBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducto
            // 
            this.dataGridViewProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducto.Location = new System.Drawing.Point(5, 338);
            this.dataGridViewProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewProducto.Name = "dataGridViewProducto";
            this.dataGridViewProducto.RowHeadersWidth = 51;
            this.dataGridViewProducto.Size = new System.Drawing.Size(1173, 294);
            this.dataGridViewProducto.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(765, 699);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 39);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(909, 699);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 39);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActulizar
            // 
            this.btnActulizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActulizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnActulizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActulizar.ForeColor = System.Drawing.Color.White;
            this.btnActulizar.Location = new System.Drawing.Point(1053, 699);
            this.btnActulizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActulizar.Name = "btnActulizar";
            this.btnActulizar.Size = new System.Drawing.Size(136, 39);
            this.btnActulizar.TabIndex = 32;
            this.btnActulizar.Text = "Actualizar";
            this.btnActulizar.UseVisualStyleBackColor = false;
            this.btnActulizar.Click += new System.EventHandler(this.btnActulizar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(605, 699);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(152, 39);
            this.btnSeleccionar.TabIndex = 35;
            this.btnSeleccionar.Text = "seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.txtUnidadMedida);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(29, 203);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1149, 116);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del producto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(768, 55);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(343, 28);
            this.txtCodigo.TabIndex = 25;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(192, 55);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(132, 28);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(391, 55);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(132, 28);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Location = new System.Drawing.Point(576, 55);
            this.txtUnidadMedida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(132, 28);
            this.txtUnidadMedida.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Precio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(764, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 22);
            this.label12.TabIndex = 26;
            this.label12.Text = "Codigo de serie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(609, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 22);
            this.label10.TabIndex = 21;
            this.label10.Text = "Medida";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.txtproducto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpFechaCaducidad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpFechaIngreso);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.CmbCategoria);
            this.groupBox1.Controls.Add(this.CmbProveedores);
            this.groupBox1.Controls.Add(this.txtNota);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(29, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1149, 138);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del producto";
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(27, 76);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(132, 28);
            this.txtproducto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Categoria";
            // 
            // dtpFechaCaducidad
            // 
            this.dtpFechaCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCaducidad.Location = new System.Drawing.Point(967, 76);
            this.dtpFechaCaducidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaCaducidad.Name = "dtpFechaCaducidad";
            this.dtpFechaCaducidad.Size = new System.Drawing.Size(125, 28);
            this.dtpFechaCaducidad.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Proveedor";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(817, 76);
            this.dtpFechaIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(125, 28);
            this.dtpFechaIngreso.TabIndex = 29;
            this.dtpFechaIngreso.ValueChanged += new System.EventHandler(this.dtpFechaIngreso_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(635, 50);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 22);
            this.label11.TabIndex = 22;
            this.label11.Text = "Nota del producto";
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Location = new System.Drawing.Point(187, 75);
            this.CmbCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(132, 30);
            this.CmbCategoria.TabIndex = 23;
            // 
            // CmbProveedores
            // 
            this.CmbProveedores.FormattingEnabled = true;
            this.CmbProveedores.Location = new System.Drawing.Point(332, 76);
            this.CmbProveedores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbProveedores.Name = "CmbProveedores";
            this.CmbProveedores.Size = new System.Drawing.Size(132, 30);
            this.CmbProveedores.TabIndex = 24;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(639, 76);
            this.txtNota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(132, 28);
            this.txtNota.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(485, 76);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(132, 28);
            this.txtDescripcion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(813, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 22);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fecha ingreso ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(963, 52);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "Fecha Vencimiento";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Controls.Add(this.btnRestaurar);
            this.panel2.Controls.Add(this.btnMinimizar);
            this.panel2.Controls.Add(this.btnMaximizar);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(-5, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1199, 38);
            this.panel2.TabIndex = 36;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1131, 7);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 7;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1100, 7);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.TabStop = false;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1131, 7);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 5;
            this.btnMaximizar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1162, 7);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(503, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(305, 36);
            this.label13.TabIndex = 1;
            this.label13.Text = "Formulario Producto";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1195, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActulizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridViewProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActulizar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaCaducidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CmbCategoria;
        private System.Windows.Forms.ComboBox CmbProveedores;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label13;
    }
}