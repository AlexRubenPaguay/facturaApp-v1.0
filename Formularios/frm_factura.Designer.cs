namespace FACTURA_APP
{
    partial class frm_factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_factura));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_cargarProducto = new System.Windows.Forms.Button();
            this.txt_cantidadRegistrado = new System.Windows.Forms.TextBox();
            this.txt_precioRegistrado = new System.Windows.Forms.TextBox();
            this.cb_ivaRegistrado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_productoRegistrado = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_productosSinRegisro = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_cantidadSinRegistro = new System.Windows.Forms.TextBox();
            this.txt_precioSinRegistro = new System.Windows.Forms.TextBox();
            this.cb_ivaSinRegistro = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvw_productos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_eliminarProducto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_iva15 = new System.Windows.Forms.TextBox();
            this.txt_base15 = new System.Windows.Forms.TextBox();
            this.txt_baseCero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_productos)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(685, 223);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.btn_cargarProducto);
            this.tabPage1.Controls.Add(this.txt_cantidadRegistrado);
            this.tabPage1.Controls.Add(this.txt_precioRegistrado);
            this.tabPage1.Controls.Add(this.cb_ivaRegistrado);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cb_productoRegistrado);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(677, 194);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Productos Registrados";
            // 
            // btn_cargarProducto
            // 
            this.btn_cargarProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cargarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cargarProducto.FlatAppearance.BorderSize = 2;
            this.btn_cargarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargarProducto.ForeColor = System.Drawing.Color.Black;
            this.btn_cargarProducto.Location = new System.Drawing.Point(6, 151);
            this.btn_cargarProducto.Name = "btn_cargarProducto";
            this.btn_cargarProducto.Size = new System.Drawing.Size(665, 37);
            this.btn_cargarProducto.TabIndex = 8;
            this.btn_cargarProducto.Text = "CARGAR PRODUCTO";
            this.btn_cargarProducto.UseVisualStyleBackColor = false;
            this.btn_cargarProducto.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_cantidadRegistrado
            // 
            this.txt_cantidadRegistrado.Location = new System.Drawing.Point(208, 81);
            this.txt_cantidadRegistrado.Name = "txt_cantidadRegistrado";
            this.txt_cantidadRegistrado.Size = new System.Drawing.Size(100, 22);
            this.txt_cantidadRegistrado.TabIndex = 7;
            // 
            // txt_precioRegistrado
            // 
            this.txt_precioRegistrado.Location = new System.Drawing.Point(208, 47);
            this.txt_precioRegistrado.Name = "txt_precioRegistrado";
            this.txt_precioRegistrado.ReadOnly = true;
            this.txt_precioRegistrado.Size = new System.Drawing.Size(100, 22);
            this.txt_precioRegistrado.TabIndex = 6;
            // 
            // cb_ivaRegistrado
            // 
            this.cb_ivaRegistrado.FormattingEnabled = true;
            this.cb_ivaRegistrado.Location = new System.Drawing.Point(208, 114);
            this.cb_ivaRegistrado.Name = "cb_ivaRegistrado";
            this.cb_ivaRegistrado.Size = new System.Drawing.Size(121, 24);
            this.cb_ivaRegistrado.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "IVA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // cb_productoRegistrado
            // 
            this.cb_productoRegistrado.FormattingEnabled = true;
            this.cb_productoRegistrado.Location = new System.Drawing.Point(208, 9);
            this.cb_productoRegistrado.Name = "cb_productoRegistrado";
            this.cb_productoRegistrado.Size = new System.Drawing.Size(380, 24);
            this.cb_productoRegistrado.TabIndex = 0;
            this.cb_productoRegistrado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.txt_productosSinRegisro);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.txt_cantidadSinRegistro);
            this.tabPage2.Controls.Add(this.txt_precioSinRegistro);
            this.tabPage2.Controls.Add(this.cb_ivaSinRegistro);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(677, 194);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Productos no Registrados";
            // 
            // txt_productosSinRegisro
            // 
            this.txt_productosSinRegisro.Location = new System.Drawing.Point(206, 12);
            this.txt_productosSinRegisro.Name = "txt_productosSinRegisro";
            this.txt_productosSinRegisro.Size = new System.Drawing.Size(383, 22);
            this.txt_productosSinRegisro.TabIndex = 17;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(6, 154);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(665, 37);
            this.button5.TabIndex = 16;
            this.button5.Text = "CARGAR PRODUCTO";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_cantidadSinRegistro
            // 
            this.txt_cantidadSinRegistro.Location = new System.Drawing.Point(208, 81);
            this.txt_cantidadSinRegistro.Name = "txt_cantidadSinRegistro";
            this.txt_cantidadSinRegistro.Size = new System.Drawing.Size(100, 22);
            this.txt_cantidadSinRegistro.TabIndex = 15;
            // 
            // txt_precioSinRegistro
            // 
            this.txt_precioSinRegistro.Location = new System.Drawing.Point(208, 47);
            this.txt_precioSinRegistro.Name = "txt_precioSinRegistro";
            this.txt_precioSinRegistro.Size = new System.Drawing.Size(100, 22);
            this.txt_precioSinRegistro.TabIndex = 14;
            // 
            // cb_ivaSinRegistro
            // 
            this.cb_ivaSinRegistro.FormattingEnabled = true;
            this.cb_ivaSinRegistro.Location = new System.Drawing.Point(208, 114);
            this.cb_ivaSinRegistro.Name = "cb_ivaSinRegistro";
            this.cb_ivaSinRegistro.Size = new System.Drawing.Size(121, 24);
            this.cb_ivaSinRegistro.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(105, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "IVA:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(105, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "Cantidad:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(105, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Precio:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(105, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 20);
            this.label15.TabIndex = 9;
            this.label15.Text = "Producto";
            // 
            // dgvw_productos
            // 
            this.dgvw_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvw_productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvw_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvw_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvw_productos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvw_productos.Location = new System.Drawing.Point(16, 273);
            this.dgvw_productos.Name = "dgvw_productos";
            this.dgvw_productos.ReadOnly = true;
            this.dgvw_productos.RowHeadersWidth = 51;
            this.dgvw_productos.RowTemplate.Height = 24;
            this.dgvw_productos.Size = new System.Drawing.Size(681, 150);
            this.dgvw_productos.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Producto";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Iva";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Subtotal sin Iva";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btn_eliminarProducto
            // 
            this.btn_eliminarProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_eliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_eliminarProducto.FlatAppearance.BorderSize = 2;
            this.btn_eliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarProducto.Location = new System.Drawing.Point(16, 424);
            this.btn_eliminarProducto.Name = "btn_eliminarProducto";
            this.btn_eliminarProducto.Size = new System.Drawing.Size(681, 37);
            this.btn_eliminarProducto.TabIndex = 2;
            this.btn_eliminarProducto.Text = "ELIMINAR PRODUCTO";
            this.btn_eliminarProducto.UseVisualStyleBackColor = false;
            this.btn_eliminarProducto.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(444, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "FACTURA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(703, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "FACTURA No: ";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Blue;
            this.textBox3.Location = new System.Drawing.Point(857, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(169, 30);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_subtotal);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_total);
            this.panel1.Controls.Add(this.txt_iva15);
            this.panel1.Controls.Add(this.txt_base15);
            this.panel1.Controls.Add(this.txt_baseCero);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(703, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 188);
            this.panel1.TabIndex = 6;
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(194, 88);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.ReadOnly = true;
            this.txt_subtotal.Size = new System.Drawing.Size(100, 22);
            this.txt_subtotal.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Subtotal";
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(194, 156);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(100, 22);
            this.txt_total.TabIndex = 7;
            // 
            // txt_iva15
            // 
            this.txt_iva15.Location = new System.Drawing.Point(194, 124);
            this.txt_iva15.Name = "txt_iva15";
            this.txt_iva15.ReadOnly = true;
            this.txt_iva15.Size = new System.Drawing.Size(100, 22);
            this.txt_iva15.TabIndex = 6;
            // 
            // txt_base15
            // 
            this.txt_base15.Location = new System.Drawing.Point(194, 51);
            this.txt_base15.Name = "txt_base15";
            this.txt_base15.ReadOnly = true;
            this.txt_base15.Size = new System.Drawing.Size(100, 22);
            this.txt_base15.TabIndex = 5;
            // 
            // txt_baseCero
            // 
            this.txt_baseCero.Location = new System.Drawing.Point(194, 11);
            this.txt_baseCero.Name = "txt_baseCero";
            this.txt_baseCero.ReadOnly = true;
            this.txt_baseCero.Size = new System.Drawing.Size(100, 22);
            this.txt_baseCero.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "TOTAL:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "IVA 15%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Base Impuesto 15%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Base Impuesto 0%";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Location = new System.Drawing.Point(54, 20);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(94, 114);
            this.btn_imprimir.TabIndex = 7;
            this.btn_imprimir.Text = "IMPRIMIR";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(194, 20);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(97, 114);
            this.btn_guardar.TabIndex = 8;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_imprimir);
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Location = new System.Drawing.Point(703, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 143);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // frm_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 476);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_eliminarProducto);
            this.Controls.Add(this.dgvw_productos);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_productos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_productoRegistrado;
        private System.Windows.Forms.TextBox txt_cantidadRegistrado;
        private System.Windows.Forms.TextBox txt_precioRegistrado;
        private System.Windows.Forms.ComboBox cb_ivaRegistrado;
        private System.Windows.Forms.Button btn_cargarProducto;
        private System.Windows.Forms.DataGridView dgvw_productos;
        private System.Windows.Forms.Button btn_eliminarProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_iva15;
        private System.Windows.Forms.TextBox txt_base15;
        private System.Windows.Forms.TextBox txt_baseCero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_cantidadSinRegistro;
        private System.Windows.Forms.TextBox txt_precioSinRegistro;
        private System.Windows.Forms.ComboBox cb_ivaSinRegistro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_productosSinRegisro;
    }
}

