using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ManejoAdaptadores;
using REDLibTools;

namespace ManejoPresupuestos
{
    public partial class frmCargaListaPrecios : Form
    {
        public frmCargaListaPrecios()
        {
            InitializeComponent();
        }
        

        private TablaPrecios precios;

        private void frmCargaListaPrecios_Load(object sender, EventArgs e)
        {
            adpProveedores.Fill(dtsDatos.PROVEEDORES);
            precios = new TablaPrecios();
            tipoFormatoComboBox.Text = "TEXTO";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bindColumnaConfig.Count > 0)
            {
                generarColumnas();
                precios.iniciarCaptura();
                precios.cargarTabla();
                dataGridView1.DataSource = precios.TablaDatos.DefaultView;
            }
            else
                Mensaje.AlertaAviso("Debe agregar columnas antes de pegar los datos");
            //PegarValores(txtAdornoPrecio.Text,optFin.Checked);
        }

        private void generarColumnas()
        {
            precios.limpiarTabla();
            foreach (OrigenDatos.ColumnaConfigRow colConfig in origenDatos.ColumnaConfig.Rows)
            {
                precios.crearColumna(colConfig.nombre,GetTipo( colConfig.tipoFormato));
            }
        }

        
        private DatosPresupuestos2.PROVEEDORESRow proveedorActual()
        {
            if (bindProveedores.Current != null)
                return (DatosPresupuestos2.PROVEEDORESRow)((DataRowView)bindProveedores.Current).Row;
            else 
                return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            bindProveedores.EndEdit();
            decimal newIDProv=comboBox1.SelectedIndex;
            DatosPresupuestos2.PROVEEDORESRow proveedor;
            if (comboBox1.SelectedIndex == -1 && comboBox1.Text != "")
            {
                newIDProv = Convert.ToDecimal(adpProveedores.MaxID()) + 1;
                proveedor = dtsDatos.PROVEEDORES.NewPROVEEDORESRow();
                proveedor.id_proveedor = newIDProv;
                proveedor.descripcion = comboBox1.Text.ToUpper();
                string soloNumero = StringTools.SoloNumeros(textBox1.Text);
                if (soloNumero != "")
                {
                    proveedor.valor_dolar = Decimal.Parse(soloNumero);
                }
                dtsDatos.PROVEEDORES.AddPROVEEDORESRow(proveedor);
                adpProveedores.Update(proveedor);
            }
            else proveedor = dtsDatos.PROVEEDORES.FindByid_proveedor(Convert.ToDecimal(comboBox1.SelectedValue));
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                DatosPresupuestos2.PRODUCTOSRow producto;
                decimal posProducto= Convert.ToDecimal(adpProductos.BuscarDesc(fila.Cells["descripcion"].Value.ToString()));
                if (posProducto > 0)
                {
                    adpProductos.FillBy(dtsDatos.PRODUCTOS, posProducto);
                    producto = dtsDatos.PRODUCTOS.FindByid_producto(posProducto);
                }
                else
                {
                    producto = dtsDatos.PRODUCTOS.NewPRODUCTOSRow();
                    producto.id_producto = Convert.ToDecimal(adpProductos.NuevoID());
                    string descr=fila.Cells["descripcion"].Value.ToString();
                    producto.descripcion = descr.Length > 900 ? descr.Substring(0, 900) : descr;
                    dtsDatos.PRODUCTOS.AddPRODUCTOSRow(producto);
                }
                foreach (DataGridViewColumn columna in dataGridView1.Columns)
                {
                    if (columna.DataPropertyName!="descripcion")
                        producto[columna.DataPropertyName] = fila.Cells[columna.DataPropertyName].Value;
                    //if (!optPrecioPesos.Checked)
                    //{
                    //    producto.precio_costo_pesos = 0;
                    //    producto.precio_costo_dolar = Convert.ToDecimal(fila.Cells["precio"].Value);
                    //}
                    //else
                    //{
                    //    producto.precio_costo_dolar = 0;
                    //    producto.precio_costo_pesos = Convert.ToDecimal(fila.Cells["precio"].Value);
                    //}
                }
                producto.ultima_partida = DateTime.Today;
                producto.ultimo_proveedor = proveedor.id_proveedor;
                if (!proveedor.Isvalor_dolarNull())
                producto.valor_dolar = proveedor.valor_dolar;
                adpProductos.Update(producto);
                DatosPresupuestos2.PRODxPROVEEDORRow prodXproveedor;
                adpProdXProveedor.FillByProv(dtsDatos.PRODxPROVEEDOR, proveedor.id_proveedor);
                prodXproveedor = dtsDatos.PRODxPROVEEDOR.FindByid_productoid_ped_proveedor(producto.id_producto,proveedor.id_proveedor);
                if (prodXproveedor == null)
                {
                    prodXproveedor = dtsDatos.PRODxPROVEEDOR.NewPRODxPROVEEDORRow();
                    prodXproveedor.id_producto = producto.id_producto;
//                    prodXproveedor.id_proveedor = proveedor.id_proveedor;
                    dtsDatos.PRODxPROVEEDOR.AddPRODxPROVEEDORRow(prodXproveedor);
                }
                //prodXproveedor.fecha_listado = DateTime.Today;
                if (!producto.Isprecio_costo_dolarNull())
                   prodXproveedor.precio_costo_dolar=producto.precio_costo_dolar;
                if (!prodXproveedor.Isprecio_costo_pesosNull())
                   prodXproveedor.precio_costo_pesos = producto.precio_costo_pesos;
                adpProdXProveedor.Update(prodXproveedor);
            }
            Cursor = Cursors.Default;
            Mensaje.AlertaAviso("la lista fue guardada!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            precios.limpiarDatos();
            dataGridView1.DataSource = null;
        }

        private void cmdAgregarColumna_Click(object sender, EventArgs e)
        {
            OrigenDatos.ColumnaConfigRow nueva= origenDatos.ColumnaConfig.NewColumnaConfigRow();
            nueva.tipoFormato = tipoFormatoComboBox.Text;
            nueva.nombre = textBox2.Text;
            origenDatos.ColumnaConfig.AddColumnaConfigRow(nueva);
            textBox2.Text="";
            textBox2.Select();
        }


        private void TextBox_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private string GetTipo(string p)
        {
            switch (p)
            {
                case "TEXTO": return "System.String";
                case "NUMERO ENTERO": return "System.Int32";
                case "NUMERO DECIMAL": return "System.Decimal";
                case "PORCENTAJE": return "System.Decimal";
            }
            return null;
        }


        
    }
}