namespace ManejoPresupuestos
{
    partial class frmListaProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.cmdNuevoProducto = new System.Windows.Forms.Button();
            this.cmdEliminarProducto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.chkSoloFavoritos = new System.Windows.Forms.CheckBox();
            this.cmdUsar = new System.Windows.Forms.Button();
            this.dtsDatos = new ManejoAdaptadores.DatosPresupuestos2();
            this.cmdFavorito = new System.Windows.Forms.Button();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreRapido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUltProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ventaIvaIncluido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioDOlar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProductos
            // 
            this.gridProductos.AllowUserToAddRows = false;
            this.gridProductos.AllowUserToDeleteRows = false;
            this.gridProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.colBarra,
            this.colCategoria,
            this.colMarca,
            this.colModelo,
            this.descripcion,
            this.colNombreRapido,
            this.colUltProveedor,
            this._ventaIvaIncluido,
            this.colPrecioCosto,
            this.colPrecioDOlar,
            this.colStock});
            this.gridProductos.Location = new System.Drawing.Point(12, 56);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ReadOnly = true;
            this.gridProductos.RowHeadersWidth = 50;
            this.gridProductos.RowTemplate.Height = 30;
            this.gridProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductos.Size = new System.Drawing.Size(818, 369);
            this.gridProductos.TabIndex = 1;
            this.gridProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProductos_CellDoubleClick);
            this.gridProductos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridProductos_CellFormatting);
            // 
            // cmdNuevoProducto
            // 
            this.cmdNuevoProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdNuevoProducto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevoProducto.Location = new System.Drawing.Point(836, 215);
            this.cmdNuevoProducto.Name = "cmdNuevoProducto";
            this.cmdNuevoProducto.Size = new System.Drawing.Size(115, 31);
            this.cmdNuevoProducto.TabIndex = 4;
            this.cmdNuevoProducto.Text = "nuevo";
            this.cmdNuevoProducto.UseVisualStyleBackColor = true;
            this.cmdNuevoProducto.Click += new System.EventHandler(this.cmdNuevoProducto_Click);
            // 
            // cmdEliminarProducto
            // 
            this.cmdEliminarProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdEliminarProducto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminarProducto.Location = new System.Drawing.Point(836, 252);
            this.cmdEliminarProducto.Name = "cmdEliminarProducto";
            this.cmdEliminarProducto.Size = new System.Drawing.Size(115, 31);
            this.cmdEliminarProducto.TabIndex = 5;
            this.cmdEliminarProducto.Text = "eliminar";
            this.cmdEliminarProducto.UseVisualStyleBackColor = true;
            this.cmdEliminarProducto.Click += new System.EventHandler(this.cmdEliminarProducto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(64, 17);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(505, 26);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // chkSoloFavoritos
            // 
            this.chkSoloFavoritos.AutoSize = true;
            this.chkSoloFavoritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSoloFavoritos.Location = new System.Drawing.Point(575, 9);
            this.chkSoloFavoritos.Name = "chkSoloFavoritos";
            this.chkSoloFavoritos.Size = new System.Drawing.Size(106, 44);
            this.chkSoloFavoritos.TabIndex = 2;
            this.chkSoloFavoritos.Text = "solo ver los\r\nfavoritos";
            this.chkSoloFavoritos.UseVisualStyleBackColor = true;
            this.chkSoloFavoritos.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cmdUsar
            // 
            this.cmdUsar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdUsar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUsar.Location = new System.Drawing.Point(313, 438);
            this.cmdUsar.Name = "cmdUsar";
            this.cmdUsar.Size = new System.Drawing.Size(264, 67);
            this.cmdUsar.TabIndex = 6;
            this.cmdUsar.Text = "♠ usar";
            this.cmdUsar.UseVisualStyleBackColor = true;
            this.cmdUsar.Click += new System.EventHandler(this.cmdUsar_Click);
            // 
            // dtsDatos
            // 
            this.dtsDatos.DataSetName = "DatosPresupuestos";
            this.dtsDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmdFavorito
            // 
            this.cmdFavorito.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmdFavorito.Font = new System.Drawing.Font("Arial", 10F);
            this.cmdFavorito.Location = new System.Drawing.Point(836, 166);
            this.cmdFavorito.Name = "cmdFavorito";
            this.cmdFavorito.Size = new System.Drawing.Size(115, 43);
            this.cmdFavorito.TabIndex = 4;
            this.cmdFavorito.Text = "♥ marcar favorito";
            this.cmdFavorito.UseVisualStyleBackColor = true;
            this.cmdFavorito.Click += new System.EventHandler(this.cmdFavorito_Click);
            // 
            // id_producto
            // 
            this.id_producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.id_producto.DataPropertyName = "id_producto";
            this.id_producto.HeaderText = "id";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            this.id_producto.Width = 5;
            // 
            // colBarra
            // 
            this.colBarra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.colBarra.DataPropertyName = "codigo_barra";
            this.colBarra.HeaderText = "barra";
            this.colBarra.Name = "colBarra";
            this.colBarra.ReadOnly = true;
            this.colBarra.Width = 5;
            // 
            // colCategoria
            // 
            this.colCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCategoria.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCategoria.HeaderText = "categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            this.colCategoria.Width = 5;
            // 
            // colMarca
            // 
            this.colMarca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.colMarca.DataPropertyName = "marca";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMarca.DefaultCellStyle = dataGridViewCellStyle3;
            this.colMarca.HeaderText = "marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            this.colMarca.Width = 5;
            // 
            // colModelo
            // 
            this.colModelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.colModelo.DataPropertyName = "modelo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colModelo.DefaultCellStyle = dataGridViewCellStyle4;
            this.colModelo.HeaderText = "modelo";
            this.colModelo.Name = "colModelo";
            this.colModelo.ReadOnly = true;
            this.colModelo.Width = 5;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.descripcion.DefaultCellStyle = dataGridViewCellStyle5;
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 320;
            // 
            // colNombreRapido
            // 
            this.colNombreRapido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.colNombreRapido.DataPropertyName = "nombre_rapido";
            this.colNombreRapido.HeaderText = "nombre rapido";
            this.colNombreRapido.Name = "colNombreRapido";
            this.colNombreRapido.ReadOnly = true;
            this.colNombreRapido.Width = 5;
            // 
            // colUltProveedor
            // 
            this.colUltProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.colUltProveedor.DataPropertyName = "ultimo_proveedor";
            this.colUltProveedor.HeaderText = "ult. proveedor";
            this.colUltProveedor.Name = "colUltProveedor";
            this.colUltProveedor.ReadOnly = true;
            this.colUltProveedor.Width = 5;
            // 
            // _ventaIvaIncluido
            // 
            this._ventaIvaIncluido.DataPropertyName = "precio_venta";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this._ventaIvaIncluido.DefaultCellStyle = dataGridViewCellStyle6;
            this._ventaIvaIncluido.HeaderText = "Precio venta IVA+GAN Incl.";
            this._ventaIvaIncluido.Name = "_ventaIvaIncluido";
            this._ventaIvaIncluido.ReadOnly = true;
            this._ventaIvaIncluido.Width = 93;
            // 
            // colPrecioCosto
            // 
            this.colPrecioCosto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.colPrecioCosto.DataPropertyName = "precio_costo_pesos";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.colPrecioCosto.DefaultCellStyle = dataGridViewCellStyle7;
            this.colPrecioCosto.HeaderText = "precio costo $";
            this.colPrecioCosto.Name = "colPrecioCosto";
            this.colPrecioCosto.ReadOnly = true;
            this.colPrecioCosto.Width = 5;
            // 
            // colPrecioDOlar
            // 
            this.colPrecioDOlar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.colPrecioDOlar.DataPropertyName = "precio_costo_dolar";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "\'u$s \'0.00";
            dataGridViewCellStyle8.NullValue = "-";
            this.colPrecioDOlar.DefaultCellStyle = dataGridViewCellStyle8;
            this.colPrecioDOlar.HeaderText = "precio u$s";
            this.colPrecioDOlar.Name = "colPrecioDOlar";
            this.colPrecioDOlar.ReadOnly = true;
            this.colPrecioDOlar.Width = 5;
            // 
            // colStock
            // 
            this.colStock.DataPropertyName = "cantidad";
            this.colStock.HeaderText = "stock";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            this.colStock.Width = 35;
            // 
            // frmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 517);
            this.Controls.Add(this.cmdUsar);
            this.Controls.Add(this.chkSoloFavoritos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.cmdFavorito);
            this.Controls.Add(this.cmdNuevoProducto);
            this.Controls.Add(this.cmdEliminarProducto);
            this.Controls.Add(this.gridProductos);
            this.Name = "frmListaProductos";
            this.Text = "listado de productos";
            this.Load += new System.EventHandler(this.frmListaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.Button cmdNuevoProducto;
        private System.Windows.Forms.Button cmdEliminarProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.CheckBox chkSoloFavoritos;
        private System.Windows.Forms.Button cmdUsar;
        private ManejoAdaptadores.DatosPresupuestos2 dtsDatos;
        private System.Windows.Forms.Button cmdFavorito;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreRapido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUltProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn _ventaIvaIncluido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioDOlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
    }
}