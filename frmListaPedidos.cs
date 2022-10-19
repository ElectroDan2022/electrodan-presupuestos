using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ManejoAdaptadores;
using REDLibTools;

namespace ManejoPresupuestos
{
    public partial class frmListaPedidos : Form
    {

        public frmListaPedidos()
        {
            InitializeComponent();
        }

        private void cmdNuevoPedido_Click(object sender, EventArgs e)
        {
            frmPedido nuevoPedido = new frmPedido();
            nuevoPedido.MdiParent = this.MdiParent;
            nuevoPedido.Show();
        }

        private void frmListaPedidos_Load(object sender, EventArgs e)
        {
            //Pedido = new Pedidos();
            adpPedidos.FillFull(dtsDatos.PEDIDOS);
        }

        private void gridPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && bindPedidos.Current != null)
            {
                frmPedido formPedido = new frmPedido(PedidoActual().id_pedido);
                formPedido.MdiParent = this.MdiParent;
                formPedido.FormClosed += new FormClosedEventHandler(formPedido_FormClosed);
                formPedido.Show();
            }
        }

        DatosPresupuestos2.PEDIDOSRow PedidoActual()
        {
            if (bindPedidos.Current != null)
                return (DatosPresupuestos2.PEDIDOSRow)((DataRowView)bindPedidos.Current).Row;
            else 
                return null;
        }

        void formPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (((frmPedido)sender).Actualizado)
            //    Pedido.cargarID(((frmPedido)sender).ID_PEDIDO);
        }

        private void cmdEliminarPedido_Click(object sender, EventArgs e)
        {
            if (Mensaje.AlertaOK("Esta por eliminar los elementos seleccionados") == DialogResult.OK)
            {
                foreach (DataGridViewRow fila in gridPedidos.SelectedRows)
                {
                    ((DatosPresupuestos2.PEDIDOSRow)((DataRowView)fila.DataBoundItem).Row).Delete();
                }
                //Pedido.guardarTodos();
            }

        }

    }
}