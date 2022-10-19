namespace ManejoPresupuestos
{
    partial class frmProducto
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bindProductos = new System.Windows.Forms.BindingSource(this.components);
            this.dtsDatos = new ManejoAdaptadores.DatosPresupuestos2();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.idproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreRapido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUltPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioDOlar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGanancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUltProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIvaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorDolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIvaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUtilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindProducto2 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreRapido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateFechaUltCompra = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.bindProveedores = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmdQuitarFecha = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmdNuevoProducto = new System.Windows.Forms.Button();
            this.adpProductos = new ManejoAdaptadores.DatosPresupuestosTableAdapters.PRODUCTOSTableAdapter();
            this.adpProveedores = new ManejoAdaptadores.DatosPresupuestosTableAdapters.PROVEEDORESTableAdapter();
            this.gridProveedores = new System.Windows.Forms.DataGridView();
            this.idproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechalistadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciocostopesosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_costo_dolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindProvXprod = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmdSeleccionar = new System.Windows.Forms.Button();
            this.adpProdxProv = new ManejoAdaptadores.DatosPresupuestosTableAdapters.PRODxPROVEEDORTableAdapter();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.gridPresXProd = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_venta_pesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindPresXProd = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdMarcarFavorito = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindProducto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindProveedores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindProvXprod)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPresXProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPresXProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "codigo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindProductos, "id_producto", true));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(67, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(219, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bindProductos
            // 
            this.bindProductos.DataMember = "PRODUCTOS";
            this.bindProductos.DataSource = this.dtsDatos;
            this.bindProductos.Sort = "";
            this.bindProductos.PositionChanged += new System.EventHandler(this.bindProductos_PositionChanged);
            // 
            // dtsDatos
            // 
            this.dtsDatos.DataSetName = "DatosPresupuestos";
            this.dtsDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridProductos
            // 
            this.gridProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProductos.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductoDataGridViewTextBoxColumn,
            this.colBarra,
            this.descripcion,
            this.colNombreRapido,
            this.colStock,
            this.colMarca,
            this.colModelo,
            this.colUltPartida,
            this.colPrecioCosto,
            this.colPrecioDOlar,
            this.colGanancia,
            this.colUltProveedor,
            this.colIvaCompra,
            this.colValorDolar,
            this.colIvaVenta,
            this.colUtilidad});
            this.gridProductos.DataSource = this.bindProducto2;
            this.gridProductos.Location = new System.Drawing.Point(13, 44);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.RowHeadersWidth = 25;
            this.gridProductos.Size = new System.Drawing.Size(325, 317);
            this.gridProductos.TabIndex = 0;
            this.gridProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idproductoDataGridViewTextBoxColumn
            // 
            this.idproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.idproductoDataGridViewTextBoxColumn.Name = "idproductoDataGridViewTextBoxColumn";
            this.idproductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idproductoDataGridViewTextBoxColumn.Width = 40;
            // 
            // colBarra
            // 
            this.colBarra.DataPropertyName = "codigo_barra";
            this.colBarra.HeaderText = "barra";
            this.colBarra.Name = "colBarra";
            this.colBarra.Width = 40;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // colNombreRapido
            // 
            this.colNombreRapido.DataPropertyName = "nombre_rapido";
            this.colNombreRapido.HeaderText = "nombre rapido";
            this.colNombreRapido.Name = "colNombreRapido";
            // 
            // colStock
            // 
            this.colStock.DataPropertyName = "cantidad";
            this.colStock.HeaderText = "stock";
            this.colStock.Name = "colStock";
            this.colStock.Width = 35;
            // 
            // colMarca
            // 
            this.colMarca.DataPropertyName = "marca";
            this.colMarca.HeaderText = "marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.Width = 80;
            // 
            // colModelo
            // 
            this.colModelo.DataPropertyName = "modelo";
            this.colModelo.HeaderText = "modelo";
            this.colModelo.Name = "colModelo";
            this.colModelo.Width = 70;
            // 
            // colUltPartida
            // 
            this.colUltPartida.DataPropertyName = "ultima_partida";
            this.colUltPartida.HeaderText = "ult. partida";
            this.colUltPartida.Name = "colUltPartida";
            this.colUltPartida.Width = 60;
            // 
            // colPrecioCosto
            // 
            this.colPrecioCosto.DataPropertyName = "precio_costo_pesos";
            this.colPrecioCosto.HeaderText = "precio $";
            this.colPrecioCosto.Name = "colPrecioCosto";
            this.colPrecioCosto.Width = 50;
            // 
            // colPrecioDOlar
            // 
            this.colPrecioDOlar.DataPropertyName = "precio_costo_dolar";
            this.colPrecioDOlar.HeaderText = "precio u$s";
            this.colPrecioDOlar.Name = "colPrecioDOlar";
            this.colPrecioDOlar.Width = 50;
            // 
            // colGanancia
            // 
            this.colGanancia.DataPropertyName = "porc_ganancia_predef";
            this.colGanancia.HeaderText = "% ganancia";
            this.colGanancia.Name = "colGanancia";
            this.colGanancia.Width = 40;
            // 
            // colUltProveedor
            // 
            this.colUltProveedor.DataPropertyName = "ultimo_proveedor";
            this.colUltProveedor.HeaderText = "ult. proveedor";
            this.colUltProveedor.Name = "colUltProveedor";
            // 
            // colIvaCompra
            // 
            this.colIvaCompra.DataPropertyName = "porc_iva_costo";
            this.colIvaCompra.HeaderText = "ivaCompra";
            this.colIvaCompra.Name = "colIvaCompra";
            this.colIvaCompra.Width = 40;
            // 
            // colValorDolar
            // 
            this.colValorDolar.DataPropertyName = "valor_dolar";
            this.colValorDolar.HeaderText = "valor dolar";
            this.colValorDolar.Name = "colValorDolar";
            this.colValorDolar.Width = 40;
            // 
            // colIvaVenta
            // 
            this.colIvaVenta.DataPropertyName = "porc_iva_venta_predef";
            this.colIvaVenta.HeaderText = "ivaVenta";
            this.colIvaVenta.Name = "colIvaVenta";
            this.colIvaVenta.Width = 40;
            // 
            // colUtilidad
            // 
            this.colUtilidad.DataPropertyName = "_utilidad";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "-";
            this.colUtilidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.colUtilidad.HeaderText = "utilidad $";
            this.colUtilidad.Name = "colUtilidad";
            this.colUtilidad.ReadOnly = true;
            this.colUtilidad.Width = 50;
            // 
            // bindProducto2
            // 
            this.bindProducto2.DataMember = "PRODUCTOS";
            this.bindProducto2.DataSource = this.dtsDatos;
            this.bindProducto2.Sort = "id_producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "nombre\r\nrapido:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNombreRapido
            // 
            this.txtNombreRapido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreRapido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindProductos, "nombre_rapido", true));
            this.txtNombreRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRapido.Location = new System.Drawing.Point(67, 76);
            this.txtNombreRapido.Name = "txtNombreRapido";
            this.txtNombreRapido.Size = new System.Drawing.Size(219, 26);
            this.txtNombreRapido.TabIndex = 1;
            this.txtNombreRapido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombreRapido.TextChanged += new System.EventHandler(this.txtNombreRapido_TextChanged);
            this.txtNombreRapido.Click += new System.EventHandler(this.TextBox_Click);
            this.txtNombreRapido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.txtNombreRapido.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "marca:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMarca
            // 
            this.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindProductos, "marca", true));
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(67, 155);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(219, 26);
            this.txtMarca.TabIndex = 3;
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtNombreRapido_TextChanged);
            this.txtMarca.Click += new System.EventHandler(this.TextBox_Click);
            this.txtMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.txtMarca.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "modelo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtModelo
            // 
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindProductos, "modelo", true));
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(67, 184);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(219, 26);
            this.txtModelo.TabIndex = 4;
            this.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtNombreRapido_TextChanged);
            this.txtModelo.Click += new System.EventHandler(this.TextBox_Click);
            this.txtModelo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.txtModelo.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "fecha:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "stocj:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateFechaUltCompra
            // 
            this.dateFechaUltCompra.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaUltCompra.CustomFormat = "\'ELIJA FECHA\'";
            this.dateFechaUltCompra.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindProductos, "ultima_partida", true));
            this.dateFechaUltCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaUltCompra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFechaUltCompra.Location = new System.Drawing.Point(151, 24);
            this.dateFechaUltCompra.Name = "dateFechaUltCompra";
            this.dateFechaUltCompra.Size = new System.Drawing.Size(103, 26);
            this.dateFechaUltCompra.TabIndex = 0;
            this.dateFechaUltCompra.TabStop = false;
            this.dateFechaUltCompra.ValueChanged += new System.EventHandler(this.dateFechaUltCompra_ValueChanged);
            this.dateFechaUltCompra.CloseUp += new System.EventHandler(this.dateFechaUltCompra_CloseUp);
            this.dateFechaUltCompra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "codigo\r\nbarra:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoBarra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindProductos, "codigo_barra", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "-"));
            this.txtCodigoBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarra.Location = new System.Drawing.Point(67, 47);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(219, 26);
            this.txtCodigoBarra.TabIndex = 0;
            this.txtCodigoBarra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoBarra.TextChanged += new System.EventHandler(this.txtNombreRapido_TextChanged);
            this.txtCodigoBarra.Click += new System.EventHandler(this.TextBox_Click);
            this.txtCodigoBarra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.txtCodigoBarra.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "iva\r\ncompra:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "iva\r\nventa:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "ultimo\r\nproveedor:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindProductos, "ultimo_proveedor", true));
            this.comboBox3.DataSource = this.bindProveedores;
            this.comboBox3.DisplayMember = "descripcion";
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(67, 59);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(187, 28);
            this.comboBox3.TabIndex = 2;
            this.comboBox3.TabStop = false;
            this.comboBox3.ValueMember = "id_proveedor";
            this.comboBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // bindProveedores
            // 
            this.bindProveedores.AllowNew = true;
            this.bindProveedores.DataMember = "PROVEEDORES";
            this.bindProveedores.DataSource = this.dtsDatos;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(261, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 3;
            this.button1.TabStop = false;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 26);
            this.label12.TabIndex = 0;
            this.label12.Text = "costo\r\ns/iva:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(149, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 26);
            this.label15.TabIndex = 0;
            this.label15.Text = "porcent.\r\nganancia:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(160, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 26);
            this.label16.TabIndex = 0;
            this.label16.Text = "valor\r\ndolar $:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.Location = new System.Drawing.Point(331, 626);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(170, 52);
            this.button6.TabIndex = 6;
            this.button6.Text = "guardar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Location = new System.Drawing.Point(659, 626);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(169, 52);
            this.button9.TabIndex = 7;
            this.button9.Text = "salir";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(14, 492);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 124);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "valores por defecto a aplicar";
            // 
            // textBox11
            // 
            this.textBox11.AutoCompleteCustomSource.AddRange(new string[] {
            "10,5",
            "21"});
            this.textBox11.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox11.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindProductos, "porc_iva_venta_predef", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "\'% \'0.00"));
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(67, 22);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(76, 26);
            this.textBox11.TabIndex = 0;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox11.Click += new System.EventHandler(this.TextBox_Click);
            this.textBox11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.textBox11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            this.textBox11.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // textBox10
            // 
            this.textBox10.AutoCompleteCustomSource.AddRange(new string[] {
            "10,5",
            "21"});
            this.textBox10.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox10.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindProductos, "porc_ganancia_predef", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "\'% \'0.00"));
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(209, 22);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(78, 26);
            this.textBox10.TabIndex = 1;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox10.Click += new System.EventHandler(this.TextBox_Click);
            this.textBox10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.textBox10.Leave += new System.EventHandler(this.TextBoxVariable_TextChanged);
            this.textBox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            this.textBox10.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindProductos, "_ventaIvaIncluido", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(133, 62);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(99, 26);
            this.textBox4.TabIndex = 3;
            this.textBox4.TabStop = false;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindProductos, "_utilidad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C2"));
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(133, 92);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(99, 26);
            this.textBox6.TabIndex = 3;
            this.textBox6.TabStop = false;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(62, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 26);
            this.label18.TabIndex = 0;
            this.label18.Text = "precio venta\r\niva incluido:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "utilidad:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.cmdQuitarFecha);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.dateFechaUltCompra);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(14, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ultima compra a proveedor";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindProductos, "valor_dolar", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(208, 122);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(78, 26);
            this.textBox7.TabIndex = 4;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.Click += new System.EventHandler(this.TextBox_Click);
            this.textBox7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            this.textBox7.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindProductos, "precio_costo_dolar", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "\'u$s\' 0.00"));
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(67, 122);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(75, 26);
            this.textBox9.TabIndex = 2;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox9.Click += new System.EventHandler(this.TextBox_Click);
            this.textBox9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.textBox9.Leave += new System.EventHandler(this.TextBoxVariable_TextChanged);
            this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            this.textBox9.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindProductos, "_costoIvaIncluido", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(132, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(99, 26);
            this.textBox3.TabIndex = 3;
            this.textBox3.TabStop = false;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindProductos, "precio_costo_pesos", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(67, 93);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(75, 26);
            this.textBox8.TabIndex = 1;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.Click += new System.EventHandler(this.TextBox_Click);
            this.textBox8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.textBox8.Leave += new System.EventHandler(this.TextBoxVariable_TextChanged);
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            this.textBox8.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // textBox12
            // 
            this.textBox12.AutoCompleteCustomSource.AddRange(new string[] {
            "10,5",
            "21"});
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindProductos, "ultima_partida", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "-", "dd/MM/yy"));
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(67, 26);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(75, 22);
            this.textBox12.TabIndex = 0;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox12.Click += new System.EventHandler(this.TextBox_Click);
            this.textBox12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.textBox12.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // textBox2
            // 
            this.textBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "10,5",
            "21"});
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindProductos, "porc_iva_costo", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "\'% \'0.00"));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(208, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 26);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Click += new System.EventHandler(this.TextBox_Click);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            this.textBox2.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // cmdQuitarFecha
            // 
            this.cmdQuitarFecha.AutoSize = true;
            this.cmdQuitarFecha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdQuitarFecha.Location = new System.Drawing.Point(262, 26);
            this.cmdQuitarFecha.Name = "cmdQuitarFecha";
            this.cmdQuitarFecha.Size = new System.Drawing.Size(24, 23);
            this.cmdQuitarFecha.TabIndex = 1;
            this.cmdQuitarFecha.TabStop = false;
            this.cmdQuitarFecha.Text = "X";
            this.cmdQuitarFecha.UseVisualStyleBackColor = true;
            this.cmdQuitarFecha.Click += new System.EventHandler(this.cmdQuitarFecha_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(61, 159);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 26);
            this.label17.TabIndex = 0;
            this.label17.Text = "precio costo\r\niva incluido:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtModelo);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtMarca);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox13);
            this.groupBox3.Controls.Add(this.txtDescripcion);
            this.groupBox3.Controls.Add(this.txtNombreRapido);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtCodigoBarra);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(15, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 251);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // textBox13
            // 
            this.textBox13.AutoCompleteCustomSource.AddRange(new string[] {
            "10,5",
            "21"});
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindProductos, "cantidad", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(132, 214);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(99, 26);
            this.textBox13.TabIndex = 5;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox13.Click += new System.EventHandler(this.TextBox_Click);
            this.textBox13.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.textBox13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            this.textBox13.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AcceptsReturn = true;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindProductos, "descripcion", true));
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(67, 104);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(219, 48);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtNombreRapido_TextChanged);
            this.txtDescripcion.Click += new System.EventHandler(this.TextBox_Click);
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            this.txtDescripcion.Enter += new System.EventHandler(this.TextBox_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 26);
            this.label13.TabIndex = 0;
            this.label13.Text = "descrip-\r\ncion:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmdNuevoProducto
            // 
            this.cmdNuevoProducto.Location = new System.Drawing.Point(180, 626);
            this.cmdNuevoProducto.Name = "cmdNuevoProducto";
            this.cmdNuevoProducto.Size = new System.Drawing.Size(141, 23);
            this.cmdNuevoProducto.TabIndex = 3;
            this.cmdNuevoProducto.Text = "nuevo";
            this.cmdNuevoProducto.UseVisualStyleBackColor = true;
            this.cmdNuevoProducto.Click += new System.EventHandler(this.cmdNuevoProducto_Click);
            // 
            // adpProductos
            // 
            this.adpProductos.ClearBeforeFill = true;
            // 
            // adpProveedores
            // 
            this.adpProveedores.ClearBeforeFill = true;
            // 
            // gridProveedores
            // 
            this.gridProveedores.AllowUserToAddRows = false;
            this.gridProveedores.AllowUserToDeleteRows = false;
            this.gridProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProveedores.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproveedorDataGridViewTextBoxColumn,
            this.idproductoDataGridViewTextBoxColumn1,
            this.fechalistadoDataGridViewTextBoxColumn,
            this.colProveedor,
            this.preciocostopesosDataGridViewTextBoxColumn,
            this.precio_costo_dolar});
            this.gridProveedores.DataSource = this.bindProvXprod;
            this.gridProveedores.Location = new System.Drawing.Point(10, 15);
            this.gridProveedores.Name = "gridProveedores";
            this.gridProveedores.ReadOnly = true;
            this.gridProveedores.RowHeadersWidth = 25;
            this.gridProveedores.Size = new System.Drawing.Size(448, 144);
            this.gridProveedores.TabIndex = 0;
            // 
            // idproveedorDataGridViewTextBoxColumn
            // 
            this.idproveedorDataGridViewTextBoxColumn.DataPropertyName = "id_proveedor";
            this.idproveedorDataGridViewTextBoxColumn.HeaderText = "id_proveedor";
            this.idproveedorDataGridViewTextBoxColumn.Name = "idproveedorDataGridViewTextBoxColumn";
            this.idproveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idproveedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // idproductoDataGridViewTextBoxColumn1
            // 
            this.idproductoDataGridViewTextBoxColumn1.DataPropertyName = "id_producto";
            this.idproductoDataGridViewTextBoxColumn1.HeaderText = "id_producto";
            this.idproductoDataGridViewTextBoxColumn1.Name = "idproductoDataGridViewTextBoxColumn1";
            this.idproductoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idproductoDataGridViewTextBoxColumn1.Visible = false;
            // 
            // fechalistadoDataGridViewTextBoxColumn
            // 
            this.fechalistadoDataGridViewTextBoxColumn.DataPropertyName = "fecha_listado";
            dataGridViewCellStyle4.Format = "dd/MM/yy";
            this.fechalistadoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.fechalistadoDataGridViewTextBoxColumn.HeaderText = "FechaListado";
            this.fechalistadoDataGridViewTextBoxColumn.Name = "fechalistadoDataGridViewTextBoxColumn";
            this.fechalistadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechalistadoDataGridViewTextBoxColumn.Width = 60;
            // 
            // colProveedor
            // 
            this.colProveedor.DataPropertyName = "_proveedor";
            this.colProveedor.HeaderText = "proveedor";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.ReadOnly = true;
            this.colProveedor.Width = 150;
            // 
            // preciocostopesosDataGridViewTextBoxColumn
            // 
            this.preciocostopesosDataGridViewTextBoxColumn.DataPropertyName = "precio_costo_pesos";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = "-";
            this.preciocostopesosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.preciocostopesosDataGridViewTextBoxColumn.HeaderText = "Precio $";
            this.preciocostopesosDataGridViewTextBoxColumn.Name = "preciocostopesosDataGridViewTextBoxColumn";
            this.preciocostopesosDataGridViewTextBoxColumn.ReadOnly = true;
            this.preciocostopesosDataGridViewTextBoxColumn.Width = 60;
            // 
            // precio_costo_dolar
            // 
            this.precio_costo_dolar.DataPropertyName = "precio_costo_dolar";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = "-";
            this.precio_costo_dolar.DefaultCellStyle = dataGridViewCellStyle6;
            this.precio_costo_dolar.HeaderText = "Precio u$s";
            this.precio_costo_dolar.Name = "precio_costo_dolar";
            this.precio_costo_dolar.ReadOnly = true;
            this.precio_costo_dolar.Width = 60;
            // 
            // bindProvXprod
            // 
            this.bindProvXprod.DataMember = "FK_PRODxPROVEEDOR_PRODUCTOS";
            this.bindProvXprod.DataSource = this.bindProducto2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.gridProveedores);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox4.Size = new System.Drawing.Size(497, 166);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Proveedores que lo tienen";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(462, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(462, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.gridProductos);
            this.groupBox5.Controls.Add(this.cmdSeleccionar);
            this.groupBox5.Location = new System.Drawing.Point(155, 3);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(347, 407);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Listado existentes";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label14.Location = new System.Drawing.Point(13, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(325, 21);
            this.label14.TabIndex = 5;
            this.label14.Text = "<< dobleclick para cargar >>";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdSeleccionar
            // 
            this.cmdSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdSeleccionar.Location = new System.Drawing.Point(130, 371);
            this.cmdSeleccionar.Name = "cmdSeleccionar";
            this.cmdSeleccionar.Size = new System.Drawing.Size(97, 25);
            this.cmdSeleccionar.TabIndex = 1;
            this.cmdSeleccionar.Text = "<< cargar";
            this.cmdSeleccionar.UseVisualStyleBackColor = true;
            this.cmdSeleccionar.Click += new System.EventHandler(this.cmdSeleccionar_Click);
            // 
            // adpProdxProv
            // 
            this.adpProdxProv.ClearBeforeFill = true;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(180, 655);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(141, 23);
            this.cmdCancelar.TabIndex = 4;
            this.cmdCancelar.Text = "cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 425);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(505, 195);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(497, 166);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "x Proveedor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(497, 166);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "x Presupuesto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.gridPresXProd);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox6.Size = new System.Drawing.Size(497, 166);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Presupuesto en los que aparece";
            // 
            // gridPresXProd
            // 
            this.gridPresXProd.AllowUserToAddRows = false;
            this.gridPresXProd.AllowUserToDeleteRows = false;
            this.gridPresXProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPresXProd.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPresXProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridPresXProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPresXProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn11,
            this.cantidad,
            this.dataGridViewTextBoxColumn13,
            this.precio_venta_pesos});
            this.gridPresXProd.DataSource = this.bindPresXProd;
            this.gridPresXProd.Location = new System.Drawing.Point(10, 15);
            this.gridPresXProd.Name = "gridPresXProd";
            this.gridPresXProd.ReadOnly = true;
            this.gridPresXProd.RowHeadersWidth = 25;
            this.gridPresXProd.Size = new System.Drawing.Size(474, 144);
            this.gridPresXProd.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id_producto";
            this.dataGridViewTextBoxColumn9.HeaderText = "id_producto";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "_cliente";
            this.dataGridViewTextBoxColumn11.HeaderText = "cliente";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 40;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "precio_costo_pesos";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = "-";
            this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn13.HeaderText = "costo $";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 60;
            // 
            // precio_venta_pesos
            // 
            this.precio_venta_pesos.DataPropertyName = "precio_venta_pesos";
            this.precio_venta_pesos.HeaderText = "venta $";
            this.precio_venta_pesos.Name = "precio_venta_pesos";
            this.precio_venta_pesos.ReadOnly = true;
            this.precio_venta_pesos.Width = 60;
            // 
            // bindPresXProd
            // 
            this.bindPresXProd.DataMember = "FK_PRODxPRESUPUESTO_PRODUCTOS";
            this.bindPresXProd.DataSource = this.bindProducto2;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(343, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 29);
            this.button4.TabIndex = 2;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(343, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 29);
            this.button5.TabIndex = 1;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.DataSource = this.bindProvXprod;
            this.dataGridView1.Location = new System.Drawing.Point(10, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.Size = new System.Drawing.Size(327, 131);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_proveedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_proveedor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_producto";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fecha_listado";
            dataGridViewCellStyle10.Format = "dd/MM/yy";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn3.HeaderText = "FechaListado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "_proveedor";
            this.dataGridViewTextBoxColumn4.HeaderText = "proveedor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "proc_iva_costo";
            this.dataGridViewTextBoxColumn5.HeaderText = "IVA";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 40;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "precio_costo_pesos";
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = "-";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn6.HeaderText = "Precio $";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "precio_costo_pesos";
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = "-";
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn7.HeaderText = "Precio u$s";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 60;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.78571F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(327, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(505, 620);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.cmdMarcarFavorito);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 151);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(146, 122);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // cmdMarcarFavorito
            // 
            this.cmdMarcarFavorito.Location = new System.Drawing.Point(3, 3);
            this.cmdMarcarFavorito.Name = "cmdMarcarFavorito";
            this.cmdMarcarFavorito.Size = new System.Drawing.Size(140, 55);
            this.cmdMarcarFavorito.TabIndex = 0;
            this.cmdMarcarFavorito.Text = "marcar\r\nfavorito";
            this.cmdMarcarFavorito.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(3, 64);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 55);
            this.button8.TabIndex = 0;
            this.button8.Text = "marcar\r\nfavorito";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(14, 626);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(160, 52);
            this.button7.TabIndex = 5;
            this.button7.Text = "usar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindProductos, "es_favorito", true));
            this.checkBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(109, 260);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 28);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "es favorito ♥";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmProducto
            // 
            this.AcceptButton = this.cmdNuevoProducto;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 689);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdNuevoProducto);
            this.Controls.Add(this.button6);
            this.Name = "frmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "producto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindProducto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindProveedores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindProvXprod)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPresXProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPresXProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreRapido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateFechaUltCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdNuevoProducto;
        private System.Windows.Forms.BindingSource bindProductos;
        private ManejoAdaptadores.DatosPresupuestos2 dtsDatos;
        private ManejoAdaptadores.DatosPresupuestosTableAdapters.PRODUCTOSTableAdapter adpProductos;
        private System.Windows.Forms.BindingSource bindProveedores;
        private System.Windows.Forms.BindingSource bindProducto2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private ManejoAdaptadores.DatosPresupuestosTableAdapters.PROVEEDORESTableAdapter adpProveedores;
        private System.Windows.Forms.DataGridView gridProveedores;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.BindingSource bindProvXprod;
        private ManejoAdaptadores.DatosPresupuestosTableAdapters.PRODxPROVEEDORTableAdapter adpProdxProv;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdQuitarFecha;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView gridPresXProd;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource bindPresXProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechalistadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciocostopesosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_costo_dolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_venta_pesos;
        private System.Windows.Forms.Button cmdSeleccionar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreRapido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUltPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioDOlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGanancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUltProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIvaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorDolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIvaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUtilidad;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button cmdMarcarFavorito;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}