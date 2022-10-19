namespace ManejoPresupuestos
{
    partial class frmProdPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdPedido));
            this.dtsDatos = new ManejoAdaptadores.DatosPresupuestos2();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.bindCategoriasSelector = new System.Windows.Forms.BindingSource(this.components);
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.idcategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindProductos = new System.Windows.Forms.BindingSource(this.components);
            this.groupNuevo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdGuardarProd = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.adpProductos = new ManejoAdaptadores.DatosPresupuestosTableAdapters.PRODUCTO_REQUERIDOTableAdapter();
            this.adpCategorias = new ManejoAdaptadores.DatosPresupuestosTableAdapters.CATEGORIA_PRODUCTOTableAdapter();
            this.cmdNuevoProducto = new System.Windows.Forms.Button();
            this.cmdEliminarProdPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdGuardarCambios = new System.Windows.Forms.Button();
            this.bindCategorias = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtsDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindCategoriasSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindProductos)).BeginInit();
            this.groupNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dtsDatos
            // 
            this.dtsDatos.DataSetName = "DatosPresupuestos";
            this.dtsDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboCategoria
            // 
            this.comboCategoria.DataSource = this.bindCategoriasSelector;
            this.comboCategoria.DisplayMember = "nombre";
            this.comboCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(99, 118);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(175, 28);
            this.comboCategoria.TabIndex = 0;
            this.comboCategoria.ValueMember = "id";
            // 
            // bindCategoriasSelector
            // 
            this.bindCategoriasSelector.DataMember = "CATEGORIA_PRODUCTO";
            this.bindCategoriasSelector.DataSource = this.dtsDatos;
            // 
            // gridProductos
            // 
            this.gridProductos.AllowUserToAddRows = false;
            this.gridProductos.AllowUserToDeleteRows = false;
            this.gridProductos.AutoGenerateColumns = false;
            this.gridProductos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcategoriaDataGridViewTextBoxColumn,
            this.idproductoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.gridProductos.DataSource = this.bindProductos;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridProductos.Location = new System.Drawing.Point(21, 152);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(509, 258);
            this.gridProductos.StandardTab = true;
            this.gridProductos.TabIndex = 2;
            this.gridProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProductos_CellDoubleClick);
            // 
            // idcategoriaDataGridViewTextBoxColumn
            // 
            this.idcategoriaDataGridViewTextBoxColumn.DataPropertyName = "id_categoria";
            this.idcategoriaDataGridViewTextBoxColumn.HeaderText = "id_categoria";
            this.idcategoriaDataGridViewTextBoxColumn.Name = "idcategoriaDataGridViewTextBoxColumn";
            this.idcategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idproductoDataGridViewTextBoxColumn
            // 
            this.idproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.HeaderText = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.Name = "idproductoDataGridViewTextBoxColumn";
            this.idproductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // bindProductos
            // 
            this.bindProductos.AllowNew = true;
            this.bindProductos.DataMember = "FK_PRODUCTO_BASICO_CATEGORIA_PRODUCTO1";
            this.bindProductos.DataSource = this.bindCategoriasSelector;
            // 
            // groupNuevo
            // 
            this.groupNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupNuevo.Controls.Add(this.label3);
            this.groupNuevo.Controls.Add(this.label2);
            this.groupNuevo.Controls.Add(this.cmdGuardarProd);
            this.groupNuevo.Controls.Add(this.txtCategoria);
            this.groupNuevo.Controls.Add(this.txtNombre);
            this.groupNuevo.Location = new System.Drawing.Point(62, 15);
            this.groupNuevo.Margin = new System.Windows.Forms.Padding(0);
            this.groupNuevo.Name = "groupNuevo";
            this.groupNuevo.Size = new System.Drawing.Size(468, 88);
            this.groupNuevo.TabIndex = 1;
            this.groupNuevo.TabStop = false;
            this.groupNuevo.Leave += new System.EventHandler(this.groupNuevo_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "CATEGORIA:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "PRODUCTO:";
            // 
            // cmdGuardarProd
            // 
            this.cmdGuardarProd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdGuardarProd.AutoSize = true;
            this.cmdGuardarProd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdGuardarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardarProd.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardarProd.Image")));
            this.cmdGuardarProd.Location = new System.Drawing.Point(424, 28);
            this.cmdGuardarProd.Name = "cmdGuardarProd";
            this.cmdGuardarProd.Size = new System.Drawing.Size(38, 38);
            this.cmdGuardarProd.TabIndex = 2;
            this.cmdGuardarProd.UseVisualStyleBackColor = true;
            this.cmdGuardarProd.Click += new System.EventHandler(this.cmdGuardarProd_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(104, 18);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(314, 26);
            this.txtCategoria.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(104, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(314, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // adpProductos
            // 
            this.adpProductos.ClearBeforeFill = true;
            // 
            // adpCategorias
            // 
            this.adpCategorias.ClearBeforeFill = true;
            // 
            // cmdNuevoProducto
            // 
            this.cmdNuevoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdNuevoProducto.AutoSize = true;
            this.cmdNuevoProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdNuevoProducto.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevoProducto.Image")));
            this.cmdNuevoProducto.Location = new System.Drawing.Point(21, 43);
            this.cmdNuevoProducto.Name = "cmdNuevoProducto";
            this.cmdNuevoProducto.Size = new System.Drawing.Size(38, 38);
            this.cmdNuevoProducto.TabIndex = 0;
            this.cmdNuevoProducto.UseVisualStyleBackColor = true;
            this.cmdNuevoProducto.Click += new System.EventHandler(this.cmdNuevoProducto_Click);
            // 
            // cmdEliminarProdPedido
            // 
            this.cmdEliminarProdPedido.AutoSize = true;
            this.cmdEliminarProdPedido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdEliminarProdPedido.Image = ((System.Drawing.Image)(resources.GetObject("cmdEliminarProdPedido.Image")));
            this.cmdEliminarProdPedido.Location = new System.Drawing.Point(536, 274);
            this.cmdEliminarProdPedido.Name = "cmdEliminarProdPedido";
            this.cmdEliminarProdPedido.Size = new System.Drawing.Size(38, 38);
            this.cmdEliminarProdPedido.TabIndex = 4;
            this.cmdEliminarProdPedido.UseVisualStyleBackColor = true;
            this.cmdEliminarProdPedido.Click += new System.EventHandler(this.cmdEliminarProdPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "CATEGORIA:";
            // 
            // cmdGuardarCambios
            // 
            this.cmdGuardarCambios.AutoSize = true;
            this.cmdGuardarCambios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardarCambios.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardarCambios.Image")));
            this.cmdGuardarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGuardarCambios.Location = new System.Drawing.Point(227, 416);
            this.cmdGuardarCambios.Name = "cmdGuardarCambios";
            this.cmdGuardarCambios.Padding = new System.Windows.Forms.Padding(3, 3, 0, 5);
            this.cmdGuardarCambios.Size = new System.Drawing.Size(143, 62);
            this.cmdGuardarCambios.TabIndex = 5;
            this.cmdGuardarCambios.Text = "GUARDAR";
            this.cmdGuardarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdGuardarCambios.UseVisualStyleBackColor = true;
            this.cmdGuardarCambios.Click += new System.EventHandler(this.cmdGuardarCambios_Click);
            // 
            // bindCategorias
            // 
            this.bindCategorias.DataMember = "CATEGORIA_PRODUCTO";
            this.bindCategorias.DataSource = this.dtsDatos;
            // 
            // frmProdPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 490);
            this.Controls.Add(this.groupNuevo);
            this.Controls.Add(this.cmdNuevoProducto);
            this.Controls.Add(this.cmdGuardarCambios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdEliminarProdPedido);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.comboCategoria);
            this.Name = "frmProdPedido";
            this.Text = "Productos para pedidos";
            this.Load += new System.EventHandler(this.frmProdPedido_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProdPedido_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtsDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindCategoriasSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindProductos)).EndInit();
            this.groupNuevo.ResumeLayout(false);
            this.groupNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ManejoAdaptadores.DatosPresupuestos2 dtsDatos;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.BindingSource bindCategoriasSelector;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.BindingSource bindProductos;
        private System.Windows.Forms.GroupBox groupNuevo;
        private System.Windows.Forms.TextBox txtNombre;
        private ManejoAdaptadores.DatosPresupuestosTableAdapters.PRODUCTO_REQUERIDOTableAdapter adpProductos;
        private ManejoAdaptadores.DatosPresupuestosTableAdapters.CATEGORIA_PRODUCTOTableAdapter adpCategorias;
        private System.Windows.Forms.Button cmdNuevoProducto;
        private System.Windows.Forms.Button cmdGuardarProd;
        private System.Windows.Forms.Button cmdEliminarProdPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdGuardarCambios;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.BindingSource bindCategorias;
    }
}