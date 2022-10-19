using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using REDLibTools;

namespace ManejoPresupuestos
{
    public partial class frmPresupuesto : Form
    {
        public decimal ID_PEDIDO = -1;
        public frmPresupuesto(decimal id_pedido)
        {
            InitializeComponent();
            ID_PEDIDO = id_pedido;
        }

        private void frmPresupuesto_Load(object sender, EventArgs e)
        {
            if (ID_PEDIDO != -1)
            {
                
            }
        }

        private void cmdSelProducto_Click(object sender, EventArgs e)
        {
            frmListaProductos selProd = new frmListaProductos();
            selProd.MdiParent = this.MdiParent;
            selProd.Show();
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            Mensaje.AlertaAviso("aca se creará una tarea para ir a instalar lo presupuestado");
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            Mensaje.AlertaAviso("se imprime el presupuesto realizado");
        }


    }
}