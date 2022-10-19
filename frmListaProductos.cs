using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using REDLibTools;
using ManejoAdaptadores;

namespace ManejoPresupuestos
{
    public partial class frmListaProductos : Form
    {
        private ListaProductos listaProductos;
        //*internal Form formLlamador;

        public frmListaProductos()
        {
            InitializeComponent();
            listaProductos = new ListaProductos(dtsDatos);
            gridProductos.AutoGenerateColumns = false;
            gridProductos.DataSource = listaProductos.bindPrincipal;
        }

        private void cmdNuevoProducto_Click(object sender, EventArgs e)
        {
            frmProducto nuevoProducto = new frmProducto(dtsDatos);
            nuevoProducto.MdiParent = this.MdiParent   ;
            nuevoProducto.Show();
        }

        private void frmListaProductos_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            listaProductos.CargarDatos();
            Cursor = Cursors.Default;
            //listaProductos.Refiltrar(txtFiltro.Text, chkSoloFavoritos.Checked);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSoloFavoritos.Focused)
                listaProductos.Refiltrar(txtFiltro.Text, chkSoloFavoritos.Checked);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.Focused)
                listaProductos.Refiltrar(txtFiltro.Text, chkSoloFavoritos.Checked);
        }

        private frmProducto producto;

        private void gridProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (producto == null)
            {
                producto = new frmProducto(dtsDatos);
                producto.MdiParent = this.MdiParent;
                producto.FormClosed += new FormClosedEventHandler(producto_FormClosed);
            }
            producto.AbrirPlanilla(listaProductos.productoActual["id_producto"]);
        }

        void producto_FormClosed(object sender, FormClosedEventArgs e)
        {
            producto = null;
        }

        private void cmdUsar_Click(object sender, EventArgs e)
        {
            //if (formLlamador.GetType() ==Type.GetType("ManejoPresupuestos.frmPedido"))
            //    ((frmPedido)formLlamador).agregarProductoElegido(Convert.ToDecimal( listaProductos.productoActual["id_producto"]));
        }

        private void cmdEliminarProducto_Click(object sender, EventArgs e)
        {
            if (listaProductos.productoActual!=null && Mensaje.AlertaConfirmaSiNo("Eliminar producto seleccionado?")== DialogResult.Yes)
                listaProductos.eliminarActual();
        }

        private void cmdFavorito_Click(object sender, EventArgs e)
        {
            listaProductos.marcarFavorito();
        }

        private void gridProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex==0 && e.RowIndex > -1)
            {
                OrigenDatos.PRODUCTOSRow Actual = (OrigenDatos.PRODUCTOSRow)((DataRowView)gridProductos.Rows[e.RowIndex].DataBoundItem).Row;
                if (Actual != null && Actual.es_favorito)
                {
                    gridProductos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else gridProductos.Rows[e.RowIndex].DefaultCellStyle.BackColor = gridProductos.DefaultCellStyle.BackColor;
            }
        }

        internal void filtroSeleccionar()
        {
            txtFiltro.Select();
        }
    }

    public class ListaProductos
    {
        private DatosPresupuestos2 dtsDatos;
        private OrigenDatos dtsVistaDatos;
        private BindingSource _bindPrincipal;
        private ManejoAdaptadores.OrigenDatosTableAdapters.PRODUCTOSTableAdapter adpProductos;

        public ListaProductos(DatosPresupuestos2 origen)
        {
            dtsDatos = origen;
            dtsVistaDatos = new OrigenDatos();
            _bindPrincipal = new BindingSource(dtsVistaDatos,"PRODUCTOS");
            adpProductos = new ManejoAdaptadores.OrigenDatosTableAdapters.PRODUCTOSTableAdapter();
        }

        public BindingSource bindPrincipal
        {
            get
            {
                return _bindPrincipal;
            }
        }

        public void CargarDatos()
        {
            adpProductos.Fill(dtsVistaDatos.PRODUCTOS);
        }

        internal void Refiltrar(string Texto, bool SoloFavoritos)
        {
            string filtro = "";
            int cant = 0;
            if (Texto != "")
            {
                filtro += string.Format("(" + (StringTools.SoloNumeros(Texto) != "" ? "codigo_barra={0} or " : "") + "nombre_rapido like '*{1}*' or descripcion like '*{1}*' or ultimo_proveedor like '*{1}*')", StringTools.SoloNumeros(Texto), StringTools.EscapeSqlLike(Texto));
                cant++;
            }
            if (SoloFavoritos)
            {
                if (cant > 0)
                    filtro += " and ";
                filtro += "es_favorito=1";
            }
            if (filtro != "")
                _bindPrincipal.Filter = filtro;
            else
                _bindPrincipal.RemoveFilter();
        }

        internal OrigenDatos.PRODUCTOSRow productoActual
        {
            get
            {
                if (_bindPrincipal.Current != null)
                    return (OrigenDatos.PRODUCTOSRow)((DataRowView)_bindPrincipal.Current).Row;
                else
                    return null;
            }
        }

        internal void eliminarActual()
        {
            try
            {
                adpProductos.Borrar(productoActual.id_producto);
                productoActual.Delete();
            }
            catch
            {
            }
        }

        internal void marcarFavorito()
        {
            if (productoActual != null)
            {
                adpProductos.CambiarFavorito(productoActual.id_producto);
                productoActual.es_favorito = !productoActual.es_favorito;
                _bindPrincipal.ResetBindings(false);
            }
        }
    }
       
}