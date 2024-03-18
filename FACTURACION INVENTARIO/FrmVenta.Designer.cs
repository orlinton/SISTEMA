
namespace FACTURACION_INVENTARIO
{
    partial class FrmVenta
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCrearVenta = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.dataGridViewCarrito = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCantidadVenta = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.dateTimeventa = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario de ventas";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(167, 63);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(118, 20);
            this.txtEmpleado.TabIndex = 3;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(167, 16);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(118, 21);
            this.cmbCliente.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(340, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Codigo Empleado";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(116, 380);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(108, 20);
            this.txtEfectivo.TabIndex = 16;
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Efectivo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(552, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(607, 393);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(108, 20);
            this.txtTotal.TabIndex = 18;
            // 
            // btnCrearVenta
            // 
            this.btnCrearVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearVenta.Location = new System.Drawing.Point(749, 429);
            this.btnCrearVenta.Name = "btnCrearVenta";
            this.btnCrearVenta.Size = new System.Drawing.Size(135, 28);
            this.btnCrearVenta.TabIndex = 20;
            this.btnCrearVenta.Text = "Crear venta";
            this.btnCrearVenta.UseVisualStyleBackColor = true;
            this.btnCrearVenta.Click += new System.EventHandler(this.btnCrearVenta_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(278, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Cambio";
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(381, 383);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(108, 20);
            this.txtCambio.TabIndex = 25;
            // 
            // dataGridViewCarrito
            // 
            this.dataGridViewCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.cantidad,
            this.precio_unitario,
            this.subtotal});
            this.dataGridViewCarrito.Location = new System.Drawing.Point(7, 417);
            this.dataGridViewCarrito.Name = "dataGridViewCarrito";
            this.dataGridViewCarrito.Size = new System.Drawing.Size(445, 183);
            this.dataGridViewCarrito.TabIndex = 27;
            this.dataGridViewCarrito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarrito_CellContentClick);
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "Producto";
            this.id_producto.Name = "id_producto";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // precio_unitario
            // 
            this.precio_unitario.HeaderText = "Precio";
            this.precio_unitario.Name = "precio_unitario";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Total";
            this.subtotal.Name = "subtotal";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(749, 385);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 28);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmpleado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(25, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 100);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACION VENTA";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtCantidadVenta);
            this.groupBox3.Controls.Add(this.txtSubtotal);
            this.groupBox3.Location = new System.Drawing.Point(25, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(836, 86);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(508, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Subtotal";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(268, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(333, 23);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(108, 20);
            this.txtPrecio.TabIndex = 26;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Cantidad";
            // 
            // txtCantidadVenta
            // 
            this.txtCantidadVenta.Location = new System.Drawing.Point(107, 19);
            this.txtCantidadVenta.Name = "txtCantidadVenta";
            this.txtCantidadVenta.Size = new System.Drawing.Size(108, 20);
            this.txtCantidadVenta.TabIndex = 24;
            this.txtCantidadVenta.TextChanged += new System.EventHandler(this.txtCantidadVenta_TextChanged);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(591, 25);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(108, 20);
            this.txtSubtotal.TabIndex = 28;
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(390, 40);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(108, 20);
            this.txtproducto.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(303, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Producto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(591, 40);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(108, 20);
            this.txtCantidad.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(504, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Cantidad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIdProducto);
            this.groupBox2.Controls.Add(this.btnBuscarProducto);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtproducto);
            this.groupBox2.Location = new System.Drawing.Point(25, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(836, 90);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PRODUCTO";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(390, 14);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(30, 20);
            this.txtIdProducto.TabIndex = 33;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.Location = new System.Drawing.Point(210, 33);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(77, 30);
            this.btnBuscarProducto.TabIndex = 32;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(94, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(108, 20);
            this.txtCodigo.TabIndex = 24;
            // 
            // dateTimeventa
            // 
            this.dateTimeventa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeventa.Location = new System.Drawing.Point(405, 63);
            this.dateTimeventa.Name = "dateTimeventa";
            this.dateTimeventa.Size = new System.Drawing.Size(103, 20);
            this.dateTimeventa.TabIndex = 32;
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 612);
            this.Controls.Add(this.dateTimeventa);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridViewCarrito);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.btnCrearVenta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVenta";
            this.Text = "FrmVenta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCrearVenta;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.DataGridView dataGridViewCarrito;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCantidadVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.DateTimePicker dateTimeventa;
    }
}