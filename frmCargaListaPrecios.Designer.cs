using ManejoAdaptadores;
namespace ManejoPresupuestos
{
    partial class frmCargaListaPrecios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bindColumnaConfig = new System.Windows.Forms.BindingSource(this.components);
            this.origenDatos = new ManejoAdaptadores.OrigenDatos();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bindProveedores = new System.Windows.Forms.BindingSource(this.components);
            this.dtsDatos = new ManejoAdaptadores.DatosPresupuestos2();
            this.adpProveedores = new ManejoAdaptadores.DatosPresupuestosTableAdapters.PROVEEDORESTableAdapter();
            this.adpProdXProveedor = new ManejoAdaptadores.DatosPresupuestosTableAdapters.PRODxPROVEEDORTableAdapter();
            this.adpProductos = new ManejoAdaptadores.DatosPresupuestosTableAdapters.PRODUCTOSTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoFormatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.tipoFormatoComboBox = new System.Windows.Forms.ComboBox();
            this.cmdAgregarColumna = new System.Windows.Forms.Button();
            this.cmdMoverAntes = new System.Windows.Forms.Button();
            this.cmdMoverDespues = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindColumnaConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(474, 225);
            this.dataGridView1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 63);
            this.button1.TabIndex = 8;
            this.button1.Text = "pegar\r\ndatos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindColumnaConfig
            // 
            this.bindColumnaConfig.DataMember = "ColumnaConfig";
            this.bindColumnaConfig.DataSource = this.origenDatos;
            // 
            // origenDatos
            // 
            this.origenDatos.DataSetName = "OrigenDatos";
            this.origenDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.bindProveedores;
            this.comboBox1.DisplayMember = "descripcion";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(53, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 28);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "id_proveedor";
            // 
            // bindProveedores
            // 
            this.bindProveedores.DataMember = "PROVEEDORES";
            this.bindProveedores.DataSource = this.dtsDatos;
            // 
            // dtsDatos
            // 
            this.dtsDatos.DataSetName = "DatosPresupuestos";
            this.dtsDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adpProveedores
            // 
            this.adpProveedores.ClearBeforeFill = true;
            // 
            // adpProdXProveedor
            // 
            this.adpProdXProveedor.ClearBeforeFill = true;
            // 
            // adpProductos
            // 
            this.adpProductos.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "proveedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "valor dolar:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindProveedores, "valor_dolar", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "-", "C2"));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(276, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 26);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(519, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 66);
            this.button3.TabIndex = 9;
            this.button3.Text = "limpiar\r\nplanilla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "nombre columna:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.tipoFormatoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bindColumnaConfig;
            this.dataGridView2.Location = new System.Drawing.Point(13, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(435, 106);
            this.dataGridView2.StandardTab = true;
            this.dataGridView2.TabIndex = 5;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoFormatoDataGridViewTextBoxColumn
            // 
            this.tipoFormatoDataGridViewTextBoxColumn.DataPropertyName = "tipoFormato";
            this.tipoFormatoDataGridViewTextBoxColumn.HeaderText = "tipoFormato";
            this.tipoFormatoDataGridViewTextBoxColumn.Name = "tipoFormatoDataGridViewTextBoxColumn";
            this.tipoFormatoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "tipo formato:";
            // 
            // tipoFormatoComboBox
            // 
            this.tipoFormatoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoFormatoComboBox.FormattingEnabled = true;
            this.tipoFormatoComboBox.Items.AddRange(new object[] {
            "TEXTO",
            "NUMERO ENTERO",
            "NUMERO DECIMAL",
            "PORCENTAJE"});
            this.tipoFormatoComboBox.Location = new System.Drawing.Point(288, 23);
            this.tipoFormatoComboBox.Name = "tipoFormatoComboBox";
            this.tipoFormatoComboBox.Size = new System.Drawing.Size(121, 21);
            this.tipoFormatoComboBox.TabIndex = 1;
            this.tipoFormatoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
            // 
            // cmdAgregarColumna
            // 
            this.cmdAgregarColumna.Location = new System.Drawing.Point(415, 22);
            this.cmdAgregarColumna.Name = "cmdAgregarColumna";
            this.cmdAgregarColumna.Size = new System.Drawing.Size(33, 27);
            this.cmdAgregarColumna.TabIndex = 4;
            this.cmdAgregarColumna.Text = "+";
            this.cmdAgregarColumna.UseVisualStyleBackColor = true;
            this.cmdAgregarColumna.Click += new System.EventHandler(this.cmdAgregarColumna_Click);
            // 
            // cmdMoverAntes
            // 
            this.cmdMoverAntes.Enabled = false;
            this.cmdMoverAntes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMoverAntes.Location = new System.Drawing.Point(454, 78);
            this.cmdMoverAntes.Name = "cmdMoverAntes";
            this.cmdMoverAntes.Size = new System.Drawing.Size(33, 27);
            this.cmdMoverAntes.TabIndex = 6;
            this.cmdMoverAntes.Text = "▲";
            this.cmdMoverAntes.UseVisualStyleBackColor = true;
            // 
            // cmdMoverDespues
            // 
            this.cmdMoverDespues.Enabled = false;
            this.cmdMoverDespues.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMoverDespues.Location = new System.Drawing.Point(454, 111);
            this.cmdMoverDespues.Name = "cmdMoverDespues";
            this.cmdMoverDespues.Size = new System.Drawing.Size(33, 27);
            this.cmdMoverDespues.TabIndex = 7;
            this.cmdMoverDespues.Text = "▼";
            this.cmdMoverDespues.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(519, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 66);
            this.button2.TabIndex = 14;
            this.button2.Text = "aceptar\r\nproductos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 450);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 75);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "detalles proveedor del listado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 262);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "lista precio de productos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.cmdMoverDespues);
            this.groupBox3.Controls.Add(this.cmdMoverAntes);
            this.groupBox3.Controls.Add(this.cmdAgregarColumna);
            this.groupBox3.Controls.Add(this.tipoFormatoComboBox);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 170);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "lista columnas configuradas";
            // 
            // textBox2
            // 
            this.textBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textBox2.FormattingEnabled = true;
            this.textBox2.Items.AddRange(new object[] {
            "descripcion",
            "precio_costo_pesos",
            "precio_costo_dolar",
            "marca",
            "categoria",
            "modelo"});
            this.textBox2.Location = new System.Drawing.Point(99, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 21);
            this.textBox2.TabIndex = 8;
            // 
            // frmCargaListaPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 542);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "frmCargaListaPrecios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "carga de lista de precios";
            this.Load += new System.EventHandler(this.frmCargaListaPrecios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindColumnaConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.origenDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private ManejoAdaptadores.DatosPresupuestosTableAdapters.PROVEEDORESTableAdapter adpProveedores;
        private ManejoAdaptadores.DatosPresupuestosTableAdapters.PRODxPROVEEDORTableAdapter adpProdXProveedor;
        private ManejoAdaptadores.DatosPresupuestosTableAdapters.PRODUCTOSTableAdapter adpProductos;
        private System.Windows.Forms.BindingSource bindProveedores;
        private ManejoAdaptadores.DatosPresupuestos2 dtsDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoFormatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindColumnaConfig;
        private OrigenDatos origenDatos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox tipoFormatoComboBox;
        private System.Windows.Forms.Button cmdAgregarColumna;
        private System.Windows.Forms.Button cmdMoverAntes;
        private System.Windows.Forms.Button cmdMoverDespues;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox textBox2;
    }
}