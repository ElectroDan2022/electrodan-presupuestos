namespace ManejoPresupuestos
{
    partial class frmListaPresupuestos
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
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdDuplicar = new System.Windows.Forms.Button();
            this.cmdImprimir = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colFechaModif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAclaraciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorDolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaCreado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(446, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 29);
            this.button4.TabIndex = 11;
            this.button4.Text = "filtrar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 20);
            this.textBox1.TabIndex = 9;
            // 
            // cmdDuplicar
            // 
            this.cmdDuplicar.Location = new System.Drawing.Point(523, 195);
            this.cmdDuplicar.Name = "cmdDuplicar";
            this.cmdDuplicar.Size = new System.Drawing.Size(86, 23);
            this.cmdDuplicar.TabIndex = 8;
            this.cmdDuplicar.Text = "duplicar";
            this.cmdDuplicar.UseVisualStyleBackColor = true;
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Location = new System.Drawing.Point(523, 293);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(86, 23);
            this.cmdImprimir.TabIndex = 6;
            this.cmdImprimir.Text = "imprimir";
            this.cmdImprimir.UseVisualStyleBackColor = true;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(523, 224);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(86, 23);
            this.cmdEliminar.TabIndex = 7;
            this.cmdEliminar.Text = "eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 38);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFechaModif,
            this.dataGridViewTextBoxColumn1,
            this.colTotal,
            this.colAclaraciones,
            this.colValorDolar,
            this.colIVA,
            this.colFechaCreado});
            this.dataGridView2.Location = new System.Drawing.Point(12, 63);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(505, 346);
            this.dataGridView2.TabIndex = 12;
            // 
            // colFechaModif
            // 
            this.colFechaModif.HeaderText = "modificado";
            this.colFechaModif.Name = "colFechaModif";
            this.colFechaModif.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "titulo presupuesto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 140;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "total $";
            this.colTotal.Name = "colTotal";
            this.colTotal.Width = 70;
            // 
            // colAclaraciones
            // 
            this.colAclaraciones.HeaderText = "aclaraciones";
            this.colAclaraciones.Name = "colAclaraciones";
            // 
            // colValorDolar
            // 
            this.colValorDolar.HeaderText = "valor dolar";
            this.colValorDolar.Name = "colValorDolar";
            this.colValorDolar.Width = 50;
            // 
            // colIVA
            // 
            this.colIVA.HeaderText = "%iva";
            this.colIVA.Name = "colIVA";
            this.colIVA.Width = 40;
            // 
            // colFechaCreado
            // 
            this.colFechaCreado.HeaderText = "creado";
            this.colFechaCreado.Name = "colFechaCreado";
            this.colFechaCreado.Width = 60;
            // 
            // cmdConfirmar
            // 
            this.cmdConfirmar.Location = new System.Drawing.Point(523, 143);
            this.cmdConfirmar.Name = "cmdConfirmar";
            this.cmdConfirmar.Size = new System.Drawing.Size(86, 23);
            this.cmdConfirmar.TabIndex = 6;
            this.cmdConfirmar.Text = "confirmar";
            this.cmdConfirmar.UseVisualStyleBackColor = true;
            // 
            // frmListaPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 421);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdDuplicar);
            this.Controls.Add(this.cmdConfirmar);
            this.Controls.Add(this.cmdImprimir);
            this.Controls.Add(this.cmdEliminar);
            this.Name = "frmListaPresupuestos";
            this.Text = "lista presupuestos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmdDuplicar;
        private System.Windows.Forms.Button cmdImprimir;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaModif;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAclaraciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorDolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaCreado;
        private System.Windows.Forms.Button cmdConfirmar;

    }
}