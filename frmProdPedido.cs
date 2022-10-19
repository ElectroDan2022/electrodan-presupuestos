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
    public partial class frmProdPedido : Form
    {
        public bool valorElegido = false;
        public decimal ID_PRODUCTO = -1;
        public decimal ID_PRODUCTO_ACTUAL = -1;
        public decimal ID_CATEGORIA = -1;
        public string PRODUCTO = "";

        public frmProdPedido()
        {
            InitializeComponent();
        }

        public frmProdPedido(decimal id_categoria,string producto)
        {
            InitializeComponent();
            ID_CATEGORIA = id_categoria;
            PRODUCTO = producto;
        }

        SelectorDato listBusqueda;

        private void frmProdPedido_Load(object sender, EventArgs e)
        {
            Activate();
            listBusqueda = new SelectorDato(this, txtCategoria, bindCategorias, "nombre", "id", "nombre like '*{0}*'");
            adpCategorias.Fill(dtsDatos.CATEGORIA_PRODUCTO);
            adpProductos.Fill(dtsDatos.PRODUCTO_REQUERIDO);
            cmdNuevoProducto.Focus();
            cmdNuevoProducto.Select();
            if (PRODUCTO!="")
            {
                NuevoProducto();   
                txtNombre.Text = PRODUCTO;
                if (ID_CATEGORIA != -1)
                {
                    DatosPresupuestos2.CATEGORIA_PRODUCTORow cat= dtsDatos.CATEGORIA_PRODUCTO.FindByid(ID_CATEGORIA);
                    if (cat != null)
                    {
                        comboCategoria.Text = cat.nombre;
                        txtCategoria.Text = cat.nombre;
                    }
                }
                txtNombre.Focus();
                txtNombre.Select();
            }
        }

        private bool guardando = false;

        private void cmdGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                bindProductos.EndEdit();
                adpProductos.Update(dtsDatos.PRODUCTO_REQUERIDO);
                Mensaje.AlertaAviso("Guardado OK");
                guardando = true;
                Close();
            }
            catch
            {
                Mensaje.AlertaAviso("Error. No se pudo guardar");
            }
        }

        private void cmdNuevoProducto_Click(object sender, EventArgs e)
        {
            NuevoProducto();
        }

        private void NuevoProducto()
        {
            groupNuevo.Enabled = true;
            txtNombre.Text = "";
            cmdNuevoProducto.Enabled = false;
            txtNombre.Select();
        }

        private void cmdGuardarProd_Click(object sender, EventArgs e)
        {
            GuardarNuevo();
            groupNuevo.Enabled = false;
            cmdNuevoProducto.Enabled = true;
            txtNombre.Text = "";
            cmdNuevoProducto.Select();
        }

        private void GuardarNuevo()
        {
            if (ID_PRODUCTO_ACTUAL == -1)
            {
                //DatosPresupuestos2.PRODUCTO_BASICORow nuevo = dtsDatos.PRODUCTO_BASICO.NewPRODUCTO_BASICORow();
                //nuevo.id_categoria = CategoriaActual().id;
                //nuevo.id_producto = NuevoID();
                //nuevo.nombre = txtNombre.Text;
                //dtsDatos.PRODUCTO_BASICO.AddPRODUCTO_BASICORow(nuevo);
            }
            else
            {
                //DatosPresupuestos2.PRODUCTO_BASICORow editado = dtsDatos.PRODUCTO_BASICO.FindByid_producto(ID_PRODUCTO_ACTUAL);
                //editado.id_categoria = CategoriaActual().id;
                //editado.nombre = txtNombre.Text;
                //editado.EndEdit();
                //ID_PRODUCTO_ACTUAL = -1;
            }
        }

        private decimal NuevoID()
        {
            return 1;
            //DataRow[] maxID=dtsDatos.PRODUCTO_BASICO.Select("id_producto=max(id_producto)","id_producto desc", DataViewRowState.CurrentRows);
            //if (maxID != null && maxID.Length > 0)
            //    return (decimal)maxID[0]["id_producto"]+1;
            //else
            //    return 1;
        }

        private DatosPresupuestos2.CATEGORIA_PRODUCTORow CategoriaActual()
        {
            if (bindCategoriasSelector.Current != null)
                return (DatosPresupuestos2.CATEGORIA_PRODUCTORow)((DataRowView)bindCategoriasSelector.Current).Row;
            else
                return null;
        }

        private void cmdEliminarProdPedido_Click(object sender, EventArgs e)
        {
            if (gridProductos.SelectedRows.Count > 0 &&
                Mensaje.AlertaConfirmaSiNo("Confirma eliminar producto(s) seleccionado(s)?") == DialogResult.Yes)
                foreach (DataGridViewRow fila in gridProductos.SelectedRows)
                    ((DataRowView)fila.DataBoundItem).Row.Delete();
        }

        private void frmProdPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!guardando)
            {
                DialogResult resul = Mensaje.AlertaConfirmaSiNoCancel("Esta por salir. Desea guardar?");
                if (resul == DialogResult.Yes)
                    cmdGuardarCambios.PerformClick();
                else if (resul == DialogResult.Cancel)
                    e.Cancel = true;
            }
            else
                valorElegido = true;
        }

        private void gridProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                //ID_PRODUCTO_ACTUAL = ProductoActual().id_producto;
                //EditarProdActual();
            }

        }

        DatosPresupuestos2.PRODUCTO_REQUERIDORow ProductoActual()
        {
            return null;
            //if (bindProductos.Current != null)
            //    return (DatosPresupuestos2.PRODUCTO_BASICORow)((DataRowView)bindProductos.Current).Row;
            //else
            //    return null;
        }

        private void EditarProdActual()
        {
            groupNuevo.Enabled = true;
            txtCategoria.Select();
            //llenarControles((DatosPresupuestos2.PRODUCTO_BASICORow)((DataRowView)bindProductos.Current).Row);
        }

        private void llenarControles(DatosPresupuestos2.PRODUCTO_REQUERIDORow pRODRow)
        {
            txtCategoria.Text = pRODRow.CATEGORIA_PRODUCTORow.nombre;
            txtNombre.Text = pRODRow.nombre;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cmdGuardarProd.Select();
                e.Handled = true;
            }
        }

        private void groupNuevo_Leave(object sender, EventArgs e)
        {
            if (listBusqueda == null || !listBusqueda.seleccionando)
            {
                txtNombre.Text = "";
                groupNuevo.Enabled = false;
                cmdNuevoProducto.Enabled = true;
            }
        }
       
    }
}