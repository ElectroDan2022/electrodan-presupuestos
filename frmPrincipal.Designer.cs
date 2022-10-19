namespace ManejoPresupuestos
{
    partial class frmPrincipal
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
            this.cmdPedidoCliente = new System.Windows.Forms.Button();
            this.cmdListaPedidos = new System.Windows.Forms.Button();
            this.cmdListaPresupuestos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdNuevoProducto = new System.Windows.Forms.Button();
            this.cmdStock = new System.Windows.Forms.Button();
            this.cmdPresupuesto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdPedidoCliente
            // 
            this.cmdPedidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPedidoCliente.Location = new System.Drawing.Point(3, 5);
            this.cmdPedidoCliente.Name = "cmdPedidoCliente";
            this.cmdPedidoCliente.Size = new System.Drawing.Size(65, 32);
            this.cmdPedidoCliente.TabIndex = 0;
            this.cmdPedidoCliente.Text = "PEDIDO";
            this.cmdPedidoCliente.UseVisualStyleBackColor = true;
            this.cmdPedidoCliente.Click += new System.EventHandler(this.cmdPedidoCliente_Click);
            // 
            // cmdListaPedidos
            // 
            this.cmdListaPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListaPedidos.Location = new System.Drawing.Point(267, 5);
            this.cmdListaPedidos.Name = "cmdListaPedidos";
            this.cmdListaPedidos.Size = new System.Drawing.Size(183, 32);
            this.cmdListaPedidos.TabIndex = 0;
            this.cmdListaPedidos.Text = "LISTA PEDIDOS";
            this.cmdListaPedidos.UseVisualStyleBackColor = true;
            this.cmdListaPedidos.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdListaPresupuestos
            // 
            this.cmdListaPresupuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListaPresupuestos.Location = new System.Drawing.Point(456, 5);
            this.cmdListaPresupuestos.Name = "cmdListaPresupuestos";
            this.cmdListaPresupuestos.Size = new System.Drawing.Size(182, 32);
            this.cmdListaPresupuestos.TabIndex = 0;
            this.cmdListaPresupuestos.Text = "LISTA PRESUPUESTOS";
            this.cmdListaPresupuestos.UseVisualStyleBackColor = true;
            this.cmdListaPresupuestos.Click += new System.EventHandler(this.cmdListaPresupuestos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.cmdNuevoProducto);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmdStock);
            this.panel1.Controls.Add(this.cmdListaPresupuestos);
            this.panel1.Controls.Add(this.cmdListaPedidos);
            this.panel1.Controls.Add(this.cmdPresupuesto);
            this.panel1.Controls.Add(this.cmdPedidoCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 42);
            this.panel1.TabIndex = 2;
            // 
            // cmdNuevoProducto
            // 
            this.cmdNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevoProducto.Location = new System.Drawing.Point(842, 5);
            this.cmdNuevoProducto.Name = "cmdNuevoProducto";
            this.cmdNuevoProducto.Size = new System.Drawing.Size(164, 32);
            this.cmdNuevoProducto.TabIndex = 0;
            this.cmdNuevoProducto.Text = "NUEVO PRODUCTO";
            this.cmdNuevoProducto.UseVisualStyleBackColor = true;
            this.cmdNuevoProducto.Click += new System.EventHandler(this.cmdNuevoProducto_Click);
            // 
            // cmdStock
            // 
            this.cmdStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStock.Location = new System.Drawing.Point(724, 5);
            this.cmdStock.Name = "cmdStock";
            this.cmdStock.Size = new System.Drawing.Size(112, 32);
            this.cmdStock.TabIndex = 0;
            this.cmdStock.Text = "STOCK";
            this.cmdStock.UseVisualStyleBackColor = true;
            this.cmdStock.Click += new System.EventHandler(this.cmdStock_Click);
            // 
            // cmdPresupuesto
            // 
            this.cmdPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPresupuesto.Location = new System.Drawing.Point(74, 5);
            this.cmdPresupuesto.Name = "cmdPresupuesto";
            this.cmdPresupuesto.Size = new System.Drawing.Size(119, 32);
            this.cmdPresupuesto.TabIndex = 0;
            this.cmdPresupuesto.Text = "PRESUPUESTO";
            this.cmdPresupuesto.UseVisualStyleBackColor = true;
            this.cmdPresupuesto.Click += new System.EventHandler(this.cmdPresupuesto_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(677, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "prueba";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(860, 564);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "gestion de pedidos y presupuestos";
            this.TransparencyKey = System.Drawing.Color.Gainsboro;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdPedidoCliente;
        private System.Windows.Forms.Button cmdListaPedidos;
        private System.Windows.Forms.Button cmdListaPresupuestos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdStock;
        private System.Windows.Forms.Button cmdNuevoProducto;
        private System.Windows.Forms.Button cmdPresupuesto;
        private System.Windows.Forms.Button button1;
    }
}