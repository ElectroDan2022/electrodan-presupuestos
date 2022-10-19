using System;
using System.Collections.Generic;
using System.Text;
using ManejoPresupuestos;
using ManejoAdaptadores;

namespace DLLEmma
{
    public static class PedidoProducto
    {
        public static void agregarPedido(TipoCliente tipo, decimal idCliente,decimal idTarea)
        {
            frmPedido pedido = new frmPedido(tipo, idCliente,idTarea);
            pedido.Show();
        }

        public static void abrirPedido(decimal p)
        {
            frmPedido pedido = new frmPedido(p);
            pedido.Show();
        }
    }
}
