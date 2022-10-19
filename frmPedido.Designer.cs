namespace ManejoPresupuestos
{
    partial class frmPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNotaPedido = new System.Windows.Forms.TextBox();
            this.bindPedidos = new System.Windows.Forms.BindingSource(this.components);
            this.dtsDatos = new ManejoAdaptadores.DatosPresupuestos2();
            this.label7 = new System.Windows.Forms.Label();
            this.gridProdPedido = new System.Windows.Forms.DataGridView();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpcional = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindProdPedidos = new System.Windows.Forms.BindingSource(this.components);
            this.cmdGuardarPedido = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.cmdCrearPresupueso = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colFechaModif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAclaraciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorDolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaCreado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpresupuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpedidoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindPresuPedidos = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listDirecciones = new System.Windows.Forms.ListBox();
            this.listTelefonos = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.optCliente = new System.Windows.Forms.RadioButton();
            this.optPersona = new System.Windows.Forms.RadioButton();
            this.optPanel = new System.Windows.Forms.RadioButton();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cmdEditarProdPedido = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdEliminarProdPedido = new System.Windows.Forms.Button();
            this.cmdNuevoProdPedido = new System.Windows.Forms.Button();
            this.groupNuevo = new System.Windows.Forms.GroupBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.chkEsOpcional = new System.Windows.Forms.CheckBox();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.bindCategorias = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdSelProducto = new System.Windows.Forms.Button();
            this.txtNotaProdPedido = new System.Windows.Forms.TextBox();
            this.bindProductos = new System.Windows.Forms.BindingSource(this.components);
            this.bindPersonas = new System.Windows.Forms.BindingSource(this.components);
            this.bindDirecciones = new System.Windows.Forms.BindingSource(this.components);
            this.bindTelefonos = new System.Windows.Forms.BindingSource(this.components);
            this.bindAbonados = new System.Windows.Forms.BindingSource(this.components);
            this.adpProdBasicos = new ManejoAdaptadores.DatosPresupuestosTableAdapters.PRODUCTO_REQUERIDOTableAdapter();
            this.adpCategorias = new ManejoAdaptadores.DatosPresupuestosTableAdapters.CATEGORIA_PRODUCTOTableAdapter();
            this.adpPersonas = new ManejoAdaptadores.DatosPresupuestosTableAdapters.PERSONATableAdapter();
            this.adpPedidos = new ManejoAdaptadores.DatosPresupuestosTableAdapters.PEDIDOSTableAdapter();
            this.adpAbonados = new ManejoAdaptadores.DatosPresupuestosTableAdapters.PANELTableAdapter();
            this.adpDires = new ManejoAdaptadores.DatosPresupuestosTableAdapters.DIRECCIONTableAdapter();
            this.adpTelefonos = new ManejoAdaptadores.DatosPresupuestosTableAdapters.TELEFONOTableAdapter();
            this.adpProdPedidos = new ManejoAdaptadores.DatosPresupuestosTableAdapters.PRODxPEDIDOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindProdPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPresuPedidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDirecciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindTelefonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindAbonados)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "telefono:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "direccion:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "direccion del\r\ntrabajo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "cliente:";
            // 
            // txtNotaPedido
            // 
            this.txtNotaPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotaPedido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindPedidos, "nota", true));
            this.txtNotaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotaPedido.Location = new System.Drawing.Point(69, 221);
            this.txtNotaPedido.Multiline = true;
            this.txtNotaPedido.Name = "txtNotaPedido";
            this.txtNotaPedido.Size = new System.Drawing.Size(291, 83);
            this.txtNotaPedido.TabIndex = 5;
            // 
            // bindPedidos
            // 
            this.bindPedidos.DataMember = "PEDIDOS";
            this.bindPedidos.DataSource = this.dtsDatos;
            // 
            // dtsDatos
            // 
            this.dtsDatos.DataSetName = "DatosPresupuestos";
            this.dtsDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "nota:";
            // 
            // gridProdPedido
            // 
            this.gridProdPedido.AllowUserToAddRows = false;
            this.gridProdPedido.AllowUserToDeleteRows = false;
            this.gridProdPedido.AllowUserToOrderColumns = true;
            this.gridProdPedido.AutoGenerateColumns = false;
            this.gridProdPedido.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProdPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridProdPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCantidad,
            this.colProducto,
            this.colOpcional,
            this.nota,
            this.idpedidoDataGridViewTextBoxColumn});
            this.gridProdPedido.DataSource = this.bindProdPedidos;
            this.gridProdPedido.Location = new System.Drawing.Point(6, 109);
            this.gridProdPedido.Name = "gridProdPedido";
            this.gridProdPedido.ReadOnly = true;
            this.gridProdPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProdPedido.Size = new System.Drawing.Size(400, 132);
            this.gridProdPedido.TabIndex = 2;
            this.gridProdPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdPedido_CellDoubleClick);
            this.gridProdPedido.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProdPedido_CellContentClick);
            // 
            // colCantidad
            // 
            this.colCantidad.DataPropertyName = "cantidad";
            this.colCantidad.HeaderText = "cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 50;
            // 
            // colProducto
            // 
            this.colProducto.DataPropertyName = "producto";
            this.colProducto.HeaderText = "producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            this.colProducto.Width = 160;
            // 
            // colOpcional
            // 
            this.colOpcional.DataPropertyName = "es_opcional";
            this.colOpcional.HeaderText = "opcional";
            this.colOpcional.Name = "colOpcional";
            this.colOpcional.ReadOnly = true;
            this.colOpcional.Width = 50;
            // 
            // nota
            // 
            this.nota.DataPropertyName = "nota";
            this.nota.HeaderText = "nota";
            this.nota.Name = "nota";
            this.nota.ReadOnly = true;
            this.nota.Width = 250;
            // 
            // idpedidoDataGridViewTextBoxColumn
            // 
            this.idpedidoDataGridViewTextBoxColumn.DataPropertyName = "id_pedido";
            this.idpedidoDataGridViewTextBoxColumn.HeaderText = "id_pedido";
            this.idpedidoDataGridViewTextBoxColumn.Name = "idpedidoDataGridViewTextBoxColumn";
            this.idpedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpedidoDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindProdPedidos
            // 
            this.bindProdPedidos.AllowNew = false;
            this.bindProdPedidos.DataMember = "FK_PRODxPEDIDO_PEDIDOS";
            this.bindProdPedidos.DataSource = this.bindPedidos;
            // 
            // cmdGuardarPedido
            // 
            this.cmdGuardarPedido.Location = new System.Drawing.Point(124, 374);
            this.cmdGuardarPedido.Name = "cmdGuardarPedido";
            this.cmdGuardarPedido.Size = new System.Drawing.Size(129, 60);
            this.cmdGuardarPedido.TabIndex = 1;
            this.cmdGuardarPedido.Text = "guardar pedido";
            this.cmdGuardarPedido.UseVisualStyleBackColor = true;
            this.cmdGuardarPedido.Click += new System.EventHandler(this.cmdGuardarPedido_Click);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(280, 374);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(129, 60);
            this.button7.TabIndex = 2;
            this.button7.Text = "verificar stock";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // cmdCrearPresupueso
            // 
            this.cmdCrearPresupueso.Enabled = false;
            this.cmdCrearPresupueso.Location = new System.Drawing.Point(435, 374);
            this.cmdCrearPresupueso.Name = "cmdCrearPresupueso";
            this.cmdCrearPresupueso.Size = new System.Drawing.Size(129, 60);
            this.cmdCrearPresupueso.TabIndex = 3;
            this.cmdCrearPresupueso.Text = "crear presupuesto";
            this.cmdCrearPresupueso.UseVisualStyleBackColor = true;
            this.cmdCrearPresupueso.Click += new System.EventHandler(this.cmdCrearPresupueso_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(592, 374);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(129, 60);
            this.button9.TabIndex = 4;
            this.button9.Text = "salir";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFechaModif,
            this.colTitulo,
            this.colTotal,
            this.colAclaraciones,
            this.colValorDolar,
            this.colIVA,
            this.colFechaCreado,
            this.idpresupuestoDataGridViewTextBoxColumn,
            this.idpedidoDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.bindPresuPedidos;
            this.dataGridView2.Location = new System.Drawing.Point(401, 279);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(400, 83);
            this.dataGridView2.TabIndex = 8;
            // 
            // colFechaModif
            // 
            this.colFechaModif.HeaderText = "modificado";
            this.colFechaModif.Name = "colFechaModif";
            this.colFechaModif.ReadOnly = true;
            this.colFechaModif.Width = 60;
            // 
            // colTitulo
            // 
            this.colTitulo.HeaderText = "titulo presupuesto";
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.ReadOnly = true;
            this.colTitulo.Width = 140;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "total $";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 70;
            // 
            // colAclaraciones
            // 
            this.colAclaraciones.HeaderText = "aclaraciones";
            this.colAclaraciones.Name = "colAclaraciones";
            this.colAclaraciones.ReadOnly = true;
            // 
            // colValorDolar
            // 
            this.colValorDolar.HeaderText = "valor dolar";
            this.colValorDolar.Name = "colValorDolar";
            this.colValorDolar.ReadOnly = true;
            this.colValorDolar.Width = 50;
            // 
            // colIVA
            // 
            this.colIVA.HeaderText = "%iva";
            this.colIVA.Name = "colIVA";
            this.colIVA.ReadOnly = true;
            this.colIVA.Width = 40;
            // 
            // colFechaCreado
            // 
            this.colFechaCreado.HeaderText = "creado";
            this.colFechaCreado.Name = "colFechaCreado";
            this.colFechaCreado.ReadOnly = true;
            this.colFechaCreado.Width = 60;
            // 
            // idpresupuestoDataGridViewTextBoxColumn
            // 
            this.idpresupuestoDataGridViewTextBoxColumn.DataPropertyName = "id_presupuesto";
            this.idpresupuestoDataGridViewTextBoxColumn.HeaderText = "id_presupuesto";
            this.idpresupuestoDataGridViewTextBoxColumn.Name = "idpresupuestoDataGridViewTextBoxColumn";
            this.idpresupuestoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpresupuestoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idpedidoDataGridViewTextBoxColumn1
            // 
            this.idpedidoDataGridViewTextBoxColumn1.DataPropertyName = "id_pedido";
            this.idpedidoDataGridViewTextBoxColumn1.HeaderText = "id_pedido";
            this.idpedidoDataGridViewTextBoxColumn1.Name = "idpedidoDataGridViewTextBoxColumn1";
            this.idpedidoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idpedidoDataGridViewTextBoxColumn1.Visible = false;
            // 
            // bindPresuPedidos
            // 
            this.bindPresuPedidos.DataMember = "FK_PRESUPUESTOS_PEDIDOS";
            this.bindPresuPedidos.DataSource = this.bindPedidos;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "presupuestos:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindPedidos, "fecha_pedido", true));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(291, 24);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "fecha:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(69, 189);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(291, 24);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDireccion.Enter += new System.EventHandler(this.txtDireccion_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle pedido";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNotaPedido, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.listDirecciones, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtDireccion, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listTelefonos, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCliente, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(365, 309);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listDirecciones
            // 
            this.listDirecciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listDirecciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDirecciones.FormattingEnabled = true;
            this.listDirecciones.ItemHeight = 18;
            this.listDirecciones.Location = new System.Drawing.Point(69, 141);
            this.listDirecciones.Name = "listDirecciones";
            this.listDirecciones.ScrollAlwaysVisible = true;
            this.listDirecciones.Size = new System.Drawing.Size(291, 40);
            this.listDirecciones.TabIndex = 3;
            this.listDirecciones.TabStop = false;
            // 
            // listTelefonos
            // 
            this.listTelefonos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listTelefonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTelefonos.FormattingEnabled = true;
            this.listTelefonos.ItemHeight = 18;
            this.listTelefonos.Location = new System.Drawing.Point(69, 93);
            this.listTelefonos.Name = "listTelefonos";
            this.listTelefonos.ScrollAlwaysVisible = true;
            this.listTelefonos.Size = new System.Drawing.Size(291, 40);
            this.listTelefonos.TabIndex = 2;
            this.listTelefonos.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.optCliente);
            this.panel1.Controls.Add(this.optPersona);
            this.panel1.Controls.Add(this.optPanel);
            this.panel1.Location = new System.Drawing.Point(117, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 22);
            this.panel1.TabIndex = 0;
            // 
            // optCliente
            // 
            this.optCliente.AutoSize = true;
            this.optCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optCliente.Location = new System.Drawing.Point(118, 3);
            this.optCliente.Name = "optCliente";
            this.optCliente.Size = new System.Drawing.Size(73, 16);
            this.optCliente.TabIndex = 2;
            this.optCliente.Text = "ClienteViejo";
            this.optCliente.UseVisualStyleBackColor = true;
            this.optCliente.CheckedChanged += new System.EventHandler(this.optCliente_CheckedChanged);
            // 
            // optPersona
            // 
            this.optPersona.AutoSize = true;
            this.optPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optPersona.Location = new System.Drawing.Point(55, 3);
            this.optPersona.Name = "optPersona";
            this.optPersona.Size = new System.Drawing.Size(57, 16);
            this.optPersona.TabIndex = 1;
            this.optPersona.Text = "Persona";
            this.optPersona.UseVisualStyleBackColor = true;
            this.optPersona.CheckedChanged += new System.EventHandler(this.optPersona_CheckedChanged);
            // 
            // optPanel
            // 
            this.optPanel.AutoSize = true;
            this.optPanel.Checked = true;
            this.optPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optPanel.Location = new System.Drawing.Point(3, 3);
            this.optPanel.Name = "optPanel";
            this.optPanel.Size = new System.Drawing.Size(46, 16);
            this.optPanel.TabIndex = 0;
            this.optPanel.TabStop = true;
            this.optPanel.Text = "Panel";
            this.optPanel.UseVisualStyleBackColor = true;
            this.optPanel.CheckedChanged += new System.EventHandler(this.optPanel_CheckedChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(69, 61);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(291, 24);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCliente.Enter += new System.EventHandler(this.txtPanel_Enter);
            // 
            // cmdEditarProdPedido
            // 
            this.cmdEditarProdPedido.AutoSize = true;
            this.cmdEditarProdPedido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdEditarProdPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEditarProdPedido.Image = ((System.Drawing.Image)(resources.GetObject("cmdEditarProdPedido.Image")));
            this.cmdEditarProdPedido.Location = new System.Drawing.Point(412, 131);
            this.cmdEditarProdPedido.Name = "cmdEditarProdPedido";
            this.cmdEditarProdPedido.Size = new System.Drawing.Size(38, 38);
            this.cmdEditarProdPedido.TabIndex = 3;
            this.cmdEditarProdPedido.UseVisualStyleBackColor = true;
            this.cmdEditarProdPedido.Click += new System.EventHandler(this.cmdEditarProdPedido_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdEliminarProdPedido);
            this.groupBox2.Controls.Add(this.cmdNuevoProdPedido);
            this.groupBox2.Controls.Add(this.cmdEditarProdPedido);
            this.groupBox2.Controls.Add(this.groupNuevo);
            this.groupBox2.Controls.Add(this.gridProdPedido);
            this.groupBox2.Location = new System.Drawing.Point(395, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox2.Size = new System.Drawing.Size(464, 248);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Pedido";
            // 
            // cmdEliminarProdPedido
            // 
            this.cmdEliminarProdPedido.AutoSize = true;
            this.cmdEliminarProdPedido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdEliminarProdPedido.Image = ((System.Drawing.Image)(resources.GetObject("cmdEliminarProdPedido.Image")));
            this.cmdEliminarProdPedido.Location = new System.Drawing.Point(412, 175);
            this.cmdEliminarProdPedido.Name = "cmdEliminarProdPedido";
            this.cmdEliminarProdPedido.Size = new System.Drawing.Size(38, 38);
            this.cmdEliminarProdPedido.TabIndex = 4;
            this.cmdEliminarProdPedido.UseVisualStyleBackColor = true;
            this.cmdEliminarProdPedido.Click += new System.EventHandler(this.cmdEliminarProdPedido_Click);
            // 
            // cmdNuevoProdPedido
            // 
            this.cmdNuevoProdPedido.AutoSize = true;
            this.cmdNuevoProdPedido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdNuevoProdPedido.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevoProdPedido.Image")));
            this.cmdNuevoProdPedido.Location = new System.Drawing.Point(6, 41);
            this.cmdNuevoProdPedido.Name = "cmdNuevoProdPedido";
            this.cmdNuevoProdPedido.Size = new System.Drawing.Size(38, 38);
            this.cmdNuevoProdPedido.TabIndex = 0;
            this.cmdNuevoProdPedido.UseVisualStyleBackColor = true;
            this.cmdNuevoProdPedido.Click += new System.EventHandler(this.cmdNuevoProdPedido_Click);
            // 
            // groupNuevo
            // 
            this.groupNuevo.Controls.Add(this.txtProducto);
            this.groupNuevo.Controls.Add(this.txtCantidad);
            this.groupNuevo.Controls.Add(this.chkEsOpcional);
            this.groupNuevo.Controls.Add(this.comboCategoria);
            this.groupNuevo.Controls.Add(this.label13);
            this.groupNuevo.Controls.Add(this.label9);
            this.groupNuevo.Controls.Add(this.label12);
            this.groupNuevo.Controls.Add(this.label8);
            this.groupNuevo.Controls.Add(this.cmdSelProducto);
            this.groupNuevo.Controls.Add(this.txtNotaProdPedido);
            this.groupNuevo.Enabled = false;
            this.groupNuevo.Location = new System.Drawing.Point(50, 13);
            this.groupNuevo.Name = "groupNuevo";
            this.groupNuevo.Size = new System.Drawing.Size(406, 90);
            this.groupNuevo.TabIndex = 1;
            this.groupNuevo.TabStop = false;
            this.groupNuevo.Leave += new System.EventHandler(this.groupNuevo_Leave);
            // 
            // txtProducto
            // 
            this.txtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProducto.Location = new System.Drawing.Point(172, 27);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(185, 20);
            this.txtProducto.TabIndex = 2;
            this.txtProducto.Enter += new System.EventHandler(this.txtProducto_Enter);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(129, 27);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(39, 20);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control2_KeyPress);
            // 
            // chkEsOpcional
            // 
            this.chkEsOpcional.AutoSize = true;
            this.chkEsOpcional.Location = new System.Drawing.Point(293, 62);
            this.chkEsOpcional.Name = "chkEsOpcional";
            this.chkEsOpcional.Size = new System.Drawing.Size(66, 17);
            this.chkEsOpcional.TabIndex = 4;
            this.chkEsOpcional.Text = "opcional";
            this.chkEsOpcional.UseVisualStyleBackColor = true;
            this.chkEsOpcional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control2_KeyPress);
            // 
            // comboCategoria
            // 
            this.comboCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCategoria.DataSource = this.bindCategorias;
            this.comboCategoria.DisplayMember = "nombre";
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(7, 26);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(117, 21);
            this.comboCategoria.TabIndex = 0;
            this.comboCategoria.ValueMember = "id";
            this.comboCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control2_KeyPress);
            // 
            // bindCategorias
            // 
            this.bindCategorias.DataMember = "CATEGORIA_PRODUCTO";
            this.bindCategorias.DataSource = this.dtsDatos;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 26);
            this.label13.TabIndex = 1;
            this.label13.Text = "nota\r\naclaracion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(127, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "cant.:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "categoria:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "producto:";
            // 
            // cmdSelProducto
            // 
            this.cmdSelProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdSelProducto.AutoSize = true;
            this.cmdSelProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdSelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelProducto.Image = ((System.Drawing.Image)(resources.GetObject("cmdSelProducto.Image")));
            this.cmdSelProducto.Location = new System.Drawing.Point(362, 30);
            this.cmdSelProducto.Name = "cmdSelProducto";
            this.cmdSelProducto.Size = new System.Drawing.Size(38, 38);
            this.cmdSelProducto.TabIndex = 5;
            this.cmdSelProducto.UseVisualStyleBackColor = true;
            this.cmdSelProducto.Click += new System.EventHandler(this.cmdSelProducto_Click);
            // 
            // txtNotaProdPedido
            // 
            this.txtNotaProdPedido.Location = new System.Drawing.Point(75, 53);
            this.txtNotaProdPedido.Multiline = true;
            this.txtNotaProdPedido.Name = "txtNotaProdPedido";
            this.txtNotaProdPedido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotaProdPedido.Size = new System.Drawing.Size(211, 32);
            this.txtNotaProdPedido.TabIndex = 3;
            this.txtNotaProdPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control2_KeyPress);
            // 
            // bindProductos
            // 
            this.bindProductos.DataMember = "FK_PRODUCTO_BASICO_CATEGORIA_PRODUCTO1";
            this.bindProductos.DataSource = this.bindCategorias;
            // 
            // bindPersonas
            // 
            this.bindPersonas.DataMember = "PERSONA";
            this.bindPersonas.DataSource = this.dtsDatos;
            // 
            // bindDirecciones
            // 
            this.bindDirecciones.DataMember = "DIRECCION";
            this.bindDirecciones.DataSource = this.dtsDatos;
            // 
            // bindTelefonos
            // 
            this.bindTelefonos.DataMember = "TELEFONO";
            this.bindTelefonos.DataSource = this.dtsDatos;
            // 
            // bindAbonados
            // 
            this.bindAbonados.DataMember = "PANEL";
            this.bindAbonados.DataSource = this.dtsDatos;
            // 
            // adpProdBasicos
            // 
            this.adpProdBasicos.ClearBeforeFill = true;
            // 
            // adpCategorias
            // 
            this.adpCategorias.ClearBeforeFill = true;
            // 
            // adpPersonas
            // 
            this.adpPersonas.ClearBeforeFill = true;
            // 
            // adpPedidos
            // 
            this.adpPedidos.ClearBeforeFill = true;
            // 
            // adpAbonados
            // 
            this.adpAbonados.ClearBeforeFill = true;
            // 
            // adpDires
            // 
            this.adpDires.ClearBeforeFill = true;
            // 
            // adpTelefonos
            // 
            this.adpTelefonos.ClearBeforeFill = true;
            // 
            // adpProdPedidos
            // 
            this.adpProdPedidos.ClearBeforeFill = true;
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 470);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.cmdCrearPresupueso);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.cmdGuardarPedido);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPedido";
            this.Text = "2";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPedido_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bindPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindProdPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPresuPedidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupNuevo.ResumeLayout(false);
            this.groupNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDirecciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindTelefonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindAbonados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNotaPedido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridProdPedido;
        private System.Windows.Forms.Button cmdGuardarPedido;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button cmdCrearPresupueso;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listDirecciones;
        private System.Windows.Forms.ListBox listTelefonos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton optCliente;
        private System.Windows.Forms.RadioButton optPersona;
        private System.Windows.Forms.RadioButton optPanel;
        private System.Windows.Forms.Button cmdEditarProdPedido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdEliminarProdPedido;
        private System.Windows.Forms.Button cmdNuevoProdPedido;
        private System.Windows.Forms.GroupBox groupNuevo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.CheckBox chkEsOpcional;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdSelProducto;
        private System.Windows.Forms.TextBox txtNotaProdPedido;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.BindingSource bindProductos;
        private ManejoAdaptadores.DatosPresupuestos2 dtsDatos;
        private System.Windows.Forms.BindingSource bindCategorias;
        private System.Windows.Forms.BindingSource bindPedidos;
        private System.Windows.Forms.BindingSource bindPersonas;
        private System.Windows.Forms.BindingSource bindDirecciones;
        private System.Windows.Forms.BindingSource bindTelefonos;
        private System.Windows.Forms.BindingSource bindAbonados;
        private System.Windows.Forms.BindingSource bindProdPedidos;
        private System.Windows.Forms.BindingSource bindPresuPedidos;
        private ManejoAdaptadores.DatosPresupuestosTableAdapters.PRODUCTO_REQUERIDOTableAdapter adpProdBasicos;
        private ManejoAdaptadores.DatosPresupuestosTableAdapters.CATEGORIA_PRODUCTOTableAdapter adpCategorias;
        private ManejoAdaptadores.DatosPresupuestosTableAdapters.PERSONATableAdapter adpPersonas;
        private ManejoAdaptadores.DatosPresupuestosTableAdapters.PEDIDOSTableAdapter adpPedidos;
        private ManejoAdaptadores.DatosPresupuestosTableAdapters.PANELTableAdapter adpAbonados;
        private ManejoAdaptadores.DatosPresupuestosTableAdapters.DIRECCIONTableAdapter adpDires;
        private ManejoAdaptadores.DatosPresupuestosTableAdapters.TELEFONOTableAdapter adpTelefonos;
        private ManejoAdaptadores.DatosPresupuestosTableAdapters.PRODxPEDIDOTableAdapter adpProdPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colOpcional;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaModif;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAclaraciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorDolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaCreado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpresupuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpedidoDataGridViewTextBoxColumn1;
    }
}