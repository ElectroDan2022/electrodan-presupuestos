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
    public partial class frmProducto : Form
    {
        
        private ManagerProducto managerProducto;
        public frmProducto(DatosPresupuestos2 dtsDatos)
        {
            InitializeComponent();

            managerProducto = new ManagerProducto(dtsDatos);
            managerProducto.bindPrincipal = bindProductos;
            managerProducto.bindBusqueda = bindProducto2;
            managerProducto.adpProducto = adpProductos;
            
        }

        private void cmdNuevoProducto_Click(object sender, EventArgs e)
        {
            AcceptButton = null;
            managerProducto.crearNuevo();
            txtNombreRapido.Select();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            managerProducto.cargarFilaBuscada();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Validate();
            managerProducto.guardar();
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            managerProducto.actualizarBind();         
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            managerProducto.actualizarBind();            
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            managerProducto.habilitarExpresiones = true;
            adpProveedores.Fill(dtsDatos.PROVEEDORES);
            adpProdxProv.Fill(dtsDatos.PRODxPROVEEDOR);
            adpProductos.Fill(dtsDatos.PRODUCTOS);
            cmdNuevoProducto.PerformClick();
        }

        private void bindProductos_PositionChanged(object sender, EventArgs e)
        {
            //**ActualizarFechaUltControl();
        }

        //**private void ActualizarFechaUltControl()
        //**{
        //**    if (managerProducto.Actual()!=null && !managerProducto.Actual().Isultima_partidaNull())
        //**    {
        //**        dateFechaUltCompra.CustomFormat = "dd/MM/yy";
        //**    }
        //**    else
        //**    {
        //**        dateFechaUltCompra.CustomFormat = "'ELIJA FECHA'";
        //**    }
        //**}

        private void dateFechaUltCompra_CloseUp(object sender, EventArgs e)
        {
            ActualizarFechaUlt();
        }

        private void ActualizarFechaUlt()
        {
            if (bindProductos.Current != null)
            {
                bindProductos.EndEdit();
                //**ActualizarFechaUltControl();
            }
        }

        private void dateFechaUltCompra_ValueChanged(object sender, EventArgs e)
        {
            if (dateFechaUltCompra.Focused)
            ActualizarFechaUlt();
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void cmdQuitarFecha_Click(object sender, EventArgs e)
        {
            if (bindProductos.Current != null)
            {
                managerProducto.Actual().Setultima_partidaNull();
                ActualizarFechaUlt();
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            managerProducto.cancelarActual();
            gridProductos.Select();
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.') e.KeyChar = ',';
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            managerProducto.cargarFilaBuscada();
        }

        private void txtNombreRapido_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).Focused)
                managerProducto.buscar(txtCodigoBarra.Text,txtDescripcion.Text, txtMarca.Text, txtModelo.Text, txtNombreRapido.Text,false);
        }

        private void TextBoxVariable_TextChanged(object sender, EventArgs e)
        {
            bindProductos.EndEdit();
        }

        internal void AbrirPlanilla(object p)
        {
            Show();
            if (!Focused)
                Activate();
            managerProducto.cargarXID(Convert.ToDecimal( p));
        }
    }
}