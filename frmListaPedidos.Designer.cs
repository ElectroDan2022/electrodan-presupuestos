namespace ManejoPresupuestos
{
    partial class frmListaPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaPedidos));
            this.gridPedidos = new System.Windows.Forms.DataGridView();
            this.idpedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechapedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulopedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpanelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddireccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindPedidos = new System.Windows.Forms.BindingSource(this.components);
            this.dtsDatos = new ManejoAdaptadores.DatosPresupuestos2();
            this.cmdEliminarPedido = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmdNuevoPedido = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gridPresupuestos = new System.Windows.Forms.DataGridView();
            this.colFechaModif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAclaraciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorDolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaCreado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdDuplicar = new System.Windows.Forms.Button();
            this.cmdConfirmar = new System.Windows.Forms.Button();
            this.cmdImprimir = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adpPedidos = new ManejoAdaptadores.DatosPresupuestosTableAdapters.PEDIDOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPresupuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPedidos
            // 
            this.gridPedidos.AllowUserToAddRows = false;
            this.gridPedidos.AllowUserToDeleteRows = false;
            this.gridPedidos.AllowUserToOrderColumns = true;
            this.gridPedidos.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpedidoDataGridViewTextBoxColumn,
            this.fechapedidoDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.titulopedidoDataGridViewTextBoxColumn,
            this.notaDataGridViewTextBoxColumn,
            this.idclienteDataGridViewTextBoxColumn,
            this.idpanelDataGridViewTextBoxColumn,
            this.iddireccionDataGridViewTextBoxColumn});
            this.gridPedidos.DataSource = this.bindPedidos;
            this.gridPedidos.Location = new System.Drawing.Point(12, 56);
            this.gridPedidos.Name = "gridPedidos";
            this.gridPedidos.ReadOnly = true;
            this.gridPedidos.Size = new System.Drawing.Size(505, 250);
            this.gridPedidos.TabIndex = 0;
            this.gridPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPedidos_CellDoubleClick);
            // 
            // idpedidoDataGridViewTextBoxColumn
            // 
            this.idpedidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.idpedidoDataGridViewTextBoxColumn.DataPropertyName = "id_pedido";
            this.idpedidoDataGridViewTextBoxColumn.HeaderText = "id_pedido";
            this.idpedidoDataGridViewTextBoxColumn.Name = "idpedidoDataGridViewTextBoxColumn";
            this.idpedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpedidoDataGridViewTextBoxColumn.Width = 5;
            // 
            // fechapedidoDataGridViewTextBoxColumn
            // 
            this.fechapedidoDataGridViewTextBoxColumn.DataPropertyName = "fecha_pedido";
            dataGridViewCellStyle2.Format = "dd/MM/yy";
            this.fechapedidoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.fechapedidoDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechapedidoDataGridViewTextBoxColumn.Name = "fechapedidoDataGridViewTextBoxColumn";
            this.fechapedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechapedidoDataGridViewTextBoxColumn.Width = 70;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "_cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteDataGridViewTextBoxColumn.Width = 200;
            // 
            // titulopedidoDataGridViewTextBoxColumn
            // 
            this.titulopedidoDataGridViewTextBoxColumn.DataPropertyName = "titulo_pedido";
            this.titulopedidoDataGridViewTextBoxColumn.HeaderText = "titulo_pedido";
            this.titulopedidoDataGridViewTextBoxColumn.Name = "titulopedidoDataGridViewTextBoxColumn";
            this.titulopedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "nota";
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            this.notaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idpanelDataGridViewTextBoxColumn
            // 
            this.idpanelDataGridViewTextBoxColumn.DataPropertyName = "id_panel";
            this.idpanelDataGridViewTextBoxColumn.HeaderText = "id_panel";
            this.idpanelDataGridViewTextBoxColumn.Name = "idpanelDataGridViewTextBoxColumn";
            this.idpanelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iddireccionDataGridViewTextBoxColumn
            // 
            this.iddireccionDataGridViewTextBoxColumn.DataPropertyName = "id_direccion";
            this.iddireccionDataGridViewTextBoxColumn.HeaderText = "id_direccion";
            this.iddireccionDataGridViewTextBoxColumn.Name = "iddireccionDataGridViewTextBoxColumn";
            this.iddireccionDataGridViewTextBoxColumn.ReadOnly = true;
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
            // cmdEliminarPedido
            // 
            this.cmdEliminarPedido.Location = new System.Drawing.Point(523, 154);
            this.cmdEliminarPedido.Name = "cmdEliminarPedido";
            this.cmdEliminarPedido.Size = new System.Drawing.Size(86, 23);
            this.cmdEliminarPedido.TabIndex = 1;
            this.cmdEliminarPedido.Text = "eliminar";
            this.cmdEliminarPedido.UseVisualStyleBackColor = true;
            this.cmdEliminarPedido.Click += new System.EventHandler(this.cmdEliminarPedido_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(523, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "presupuestar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmdNuevoPedido
            // 
            this.cmdNuevoPedido.Location = new System.Drawing.Point(523, 125);
            this.cmdNuevoPedido.Name = "cmdNuevoPedido";
            this.cmdNuevoPedido.Size = new System.Drawing.Size(86, 23);
            this.cmdNuevoPedido.TabIndex = 1;
            this.cmdNuevoPedido.Text = "nuevo";
            this.cmdNuevoPedido.UseVisualStyleBackColor = true;
            this.cmdNuevoPedido.Click += new System.EventHandler(this.cmdNuevoPedido_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(453, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "presupuestos:";
            // 
            // gridPresupuestos
            // 
            this.gridPresupuestos.AllowUserToAddRows = false;
            this.gridPresupuestos.AllowUserToDeleteRows = false;
            this.gridPresupuestos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPresupuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridPresupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPresupuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFechaModif,
            this.dataGridViewTextBoxColumn1,
            this.colTotal,
            this.colAclaraciones,
            this.colValorDolar,
            this.colIVA,
            this.colFechaCreado});
            this.gridPresupuestos.Location = new System.Drawing.Point(12, 330);
            this.gridPresupuestos.Name = "gridPresupuestos";
            this.gridPresupuestos.ReadOnly = true;
            this.gridPresupuestos.Size = new System.Drawing.Size(505, 172);
            this.gridPresupuestos.TabIndex = 8;
            // 
            // colFechaModif
            // 
            this.colFechaModif.HeaderText = "modificado";
            this.colFechaModif.Name = "colFechaModif";
            this.colFechaModif.ReadOnly = true;
            this.colFechaModif.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "titulo presupuesto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 140;
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
            // cmdDuplicar
            // 
            this.cmdDuplicar.Enabled = false;
            this.cmdDuplicar.Location = new System.Drawing.Point(523, 392);
            this.cmdDuplicar.Name = "cmdDuplicar";
            this.cmdDuplicar.Size = new System.Drawing.Size(86, 23);
            this.cmdDuplicar.TabIndex = 13;
            this.cmdDuplicar.Text = "duplicar";
            this.cmdDuplicar.UseVisualStyleBackColor = true;
            // 
            // cmdConfirmar
            // 
            this.cmdConfirmar.Enabled = false;
            this.cmdConfirmar.Location = new System.Drawing.Point(523, 352);
            this.cmdConfirmar.Name = "cmdConfirmar";
            this.cmdConfirmar.Size = new System.Drawing.Size(86, 23);
            this.cmdConfirmar.TabIndex = 11;
            this.cmdConfirmar.Text = "confirmar";
            this.cmdConfirmar.UseVisualStyleBackColor = true;
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Enabled = false;
            this.cmdImprimir.Location = new System.Drawing.Point(523, 462);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(86, 23);
            this.cmdImprimir.TabIndex = 10;
            this.cmdImprimir.Text = "imprimir";
            this.cmdImprimir.UseVisualStyleBackColor = true;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Enabled = false;
            this.cmdEliminar.Location = new System.Drawing.Point(523, 421);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(86, 23);
            this.cmdEliminar.TabIndex = 12;
            this.cmdEliminar.Text = "eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // adpPedidos
            // 
            this.adpPedidos.ClearBeforeFill = true;
            // 
            // frmListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 514);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdDuplicar);
            this.Controls.Add(this.cmdConfirmar);
            this.Controls.Add(this.cmdImprimir);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gridPresupuestos);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdNuevoPedido);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmdEliminarPedido);
            this.Controls.Add(this.gridPedidos);
            this.Name = "frmListaPedidos";
            this.Text = "lista pedidos";
            this.Load += new System.EventHandler(this.frmListaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPresupuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPedidos;
        private System.Windows.Forms.Button cmdEliminarPedido;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cmdNuevoPedido;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView gridPresupuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaModif;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAclaraciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorDolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaCreado;
        private System.Windows.Forms.Button cmdDuplicar;
        private System.Windows.Forms.Button cmdConfirmar;
        private System.Windows.Forms.Button cmdImprimir;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.BindingSource bindPedidos;
        private ManejoAdaptadores.DatosPresupuestos2 dtsDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechapedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulopedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpanelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddireccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ManejoAdaptadores.DatosPresupuestosTableAdapters.PEDIDOSTableAdapter adpPedidos;
    }
}