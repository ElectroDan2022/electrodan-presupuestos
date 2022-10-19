using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ManejoAdaptadores;
using ManejoTareas;
using REDLibTools;

namespace ManejoPresupuestos
{
    public partial class frmPrincipal : Form
    {
        private DatosPresupuestos2 dtsDatos;

        public frmPrincipal()
        {
            InitializeComponent();
            dtsDatos = new DatosPresupuestos2();
        }

        private void cmdPedidoCliente_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido();
            pedido.MdiParent = this;
            pedido.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListaPedidos listaPedidos = new frmListaPedidos();
            listaPedidos.MdiParent = this;
            listaPedidos.Show();
        }

        private void cmdListaPresupuestos_Click(object sender, EventArgs e)
        {
            frmListaPresupuestos listaPresupuestos = new frmListaPresupuestos();
            listaPresupuestos.MdiParent = this;
            listaPresupuestos.Show();
        }

        private void cmdStock_Click(object sender, EventArgs e)
        {
            frmCargaListaPrecios listaPrecios = new frmCargaListaPrecios();
            listaPrecios.MdiParent = this;
            listaPrecios.Show();

            //frmListaProductos listaProductos = new frmListaProductos();
            //listaProductos.MdiParent = this;
            //listaProductos.Show();
        }

        private void cmdNuevoProducto_Click(object sender, EventArgs e)
        {
            frmProducto nuevoProducto = new frmProducto(dtsDatos);
            nuevoProducto.MdiParent = this;
            nuevoProducto.Show();
        }

        private void cmdPresupuesto_Click(object sender, EventArgs e)
        {
            frmPresuNuevo presu = new frmPresuNuevo();
            presu.MdiParent = this;
            presu.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmPostergador pos = new frmPostergador("Control valido por","horas",16);
            if (pos.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                Mensaje.AlertaAviso("se acepto el valor "+ pos.Valor);
            else
                Mensaje.AlertaAviso("se cancelo el valor");
        }

    }
}