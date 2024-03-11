
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
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "formulario producto";
            // 
            // dataGridViewProducto
            // 
            this.dataGridViewProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducto.Location = new System.Drawing.Point(4, 275);
            this.dataGridViewProducto.Name = "dataGridViewProducto";
            this.dataGridViewProducto.Size = new System.Drawing.Size(880, 239);
            this.dataGridViewProducto.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(574, 568);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 32);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(682, 568);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 32);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActulizar
            // 
            this.btnActulizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActulizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActulizar.Location = new System.Drawing.Point(790, 568);
            this.btnActulizar.Name = "btnActulizar";
            this.btnActulizar.Size = new System.Drawing.Size(102, 32);
            this.btnActulizar.TabIndex = 32;
            this.btnActulizar.Text = "Actualizar";
            this.btnActulizar.UseVisualStyleBackColor = true;
            this.btnActulizar.Click += new System.EventHandler(this.btnActulizar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(454, 568);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(114, 32);
            this.btnSeleccionar.TabIndex = 35;
            this.btnSeleccionar.Text = "seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.txtUnidadMedida);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(22, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(862, 94);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del producto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(576, 45);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(258, 24);
            this.txtCodigo.TabIndex = 25;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(144, 45);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 24);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(293, 45);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 24);
            this.txtCantidad.TabIndex = 8;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Location = new System.Drawing.Point(432, 45);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(100, 24);
            this.txtUnidadMedida.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Precio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(573, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 18);
            this.label12.TabIndex = 26;
            this.label12.Text = "Codigo de serie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(457, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Medida";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(22, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 112);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del producto";
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(20, 62);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(100, 24);
            this.txtproducto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Categoria";
            // 
            // dtpFechaCaducidad
            // 
            this.dtpFechaCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCaducidad.Location = new System.Drawing.Point(725, 62);
            this.dtpFechaCaducidad.Name = "dtpFechaCaducidad";
            this.dtpFechaCaducidad.Size = new System.Drawing.Size(95, 24);
            this.dtpFechaCaducidad.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Proveedor";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(613, 62);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(95, 24);
            this.dtpFechaIngreso.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(476, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Nota del producto";
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Location = new System.Drawing.Point(140, 61);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(100, 26);
            this.CmbCategoria.TabIndex = 23;
            // 
            // CmbProveedores
            // 
            this.CmbProveedores.FormattingEnabled = true;
            this.CmbProveedores.Location = new System.Drawing.Point(249, 62);
            this.CmbProveedores.Name = "CmbProveedores";
            this.CmbProveedores.Size = new System.Drawing.Size(100, 26);
            this.CmbProveedores.TabIndex = 24;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(479, 62);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 24);
            this.txtNota.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(364, 62);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 24);
            this.txtDescripcion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(610, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fecha ingreso ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(722, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Fecha Vencimiento";
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 612);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnActulizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridViewProducto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
    }
}