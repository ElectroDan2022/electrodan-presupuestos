using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ManejoAdaptadores;
using REDLibTools;
using System.IO;
using System.Xml;


namespace ManejoPresupuestos
{
    public partial class frmPedido : Form
    {
        
        public decimal ID_PEDIDO;
        public decimal ID_PANEL;
        public decimal ID_CLIENTE;
        public decimal ID_TAREA;
        private SelectorDato listBusqueda;
        public bool Actualizado = false;
        
        //constructores
        public frmPedido()
        {
            InitializeComponent();
            ID_PEDIDO = -1;
            ID_PANEL = -1;
            ID_CLIENTE = -1;
            ID_TAREA = -1;
        }

        public frmPedido(decimal idPedido,decimal idPanel,decimal idCliente,decimal idTarea)
        {
            InitializeComponent();
            ID_PEDIDO = idPedido;
            ID_PANEL = idPanel;
            ID_CLIENTE = idCliente;
            ID_TAREA = idTarea;
        }
        public frmPedido(decimal idPedido)
        {
            InitializeComponent();
            ID_PEDIDO = idPedido;
            ID_PANEL = -1;
            ID_CLIENTE = -1;
            ID_TAREA = -1;
        }



        public frmPedido(TipoCliente tipo, decimal id,decimal idtarea)
        {
            InitializeComponent();
            ID_PEDIDO = -1;
            ID_CLIENTE = tipo == TipoCliente.Cliente?id:-1;
            ID_PANEL = tipo == TipoCliente.Panel ? id : -1;
            ID_TAREA = idtarea;
        }
        private void frmPedido_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            CargarSecundarios();
            if (ID_PEDIDO != -1)
            {
                CargarDatosEspecificos();
                HabilitarControles();
            }
            else
            {
                CrearNuevoPedido(); 
            }
            IniciarCliente();
            IniciarTarea();
            Cursor = Cursors.Default;
            if (ID_PEDIDO == -1)
                txtCliente.Select();
            else
                txtNotaPedido.Select();
        }

        private void HabilitarControles()
        {
            cmdCrearPresupueso.Enabled = true;
        }

        private void CrearNuevoPedido()
        {
            bindPedidos.AddNew();
            PedidoActual().id_pedido = -1;
            PedidoActual().fecha_pedido = DateTime.Today;
            bindPedidos.EndEdit();
        }

        private void CargarDatosEspecificos()
        {
            cargarID(ID_PEDIDO);
            actualizarControles();
        }

        private void actualizarControles()
        {
            txtCliente.Text = PedidoActual()._cliente;
            //txtDireccion.Text = PedidoActual()._direccion;
            //if (!PedidoActual().Isid_clienteNull())
            //    optPersona.Checked = true;
            //else
            //    optPanel.Checked = true;
            //if (!PedidoActual().Isid_clienteNull() || !PedidoActual().Isid_panelNull())
            //    CargarDireTel();
        }
        //carga datos
        //private void frmPedido_Load(object sender, EventArgs e)
        //{
        //    Cursor = Cursors.WaitCursor;
        //    CargarSecundarios();

        //    if (ID_PEDIDO != -1)
        //        cargarID(ID_PEDIDO);
        //    else
        //    {
        //        bindPedidos.AddNew();
        //        PedidoActual().id_pedido = -1;
        //        PedidoActual().fecha_pedido = DateTime.Today;
        //        bindPedidos.EndEdit();
        //    }
        //    AsociarCliente();
        //    AsociarTarea();
        //    if (ID_PEDIDO != -1)
        //    {
        //        cmdCrearPresupueso.Enabled = true;
        //        txtCliente.Text =PedidoActual()._cliente;
        //        txtDireccion.Text =PedidoActual()._direccion;
        //        if (!PedidoActual().Isid_clienteNull())
        //            optPersona.Checked = true;
        //        else
        //            optPanel.Checked = true;
        //        if (!PedidoActual().Isid_clienteNull() ||  !PedidoActual().Isid_panelNull())
        //            CargarDireTel();
        //    }
        //    Cursor = Cursors.Default;
        //    txtCliente.Select();
        //}

        private void IniciarTarea()
        {
            //if (ID_TAREA != -1)
            //    PedidoActual().id_tarea = ID_TAREA;
        }

        private void IniciarCliente()
        {
            if (ID_CLIENTE != -1 || ID_PANEL != -1 || ID_PEDIDO!=-1)
            {
                //if (ID_PANEL != -1) PedidoActual().id_panel = ID_PANEL;
                //if (ID_CLIENTE != -1) PedidoActual().id_cliente = ID_CLIENTE;
                //ActualizarCliente();
                //txtCliente.Text = PedidoActual()._cliente;
                //txtDireccion.Text = PedidoActual()._direccion;
                CargarDireTel();
            }
        }

        public string Cliente
        {
            get
            {
                if (PedidoActual() != null)
                {
                    //if (!PedidoActual().Isid_panelNull())
                    //    return REDLibTools.Tools.isNull(adpPedidos.getDescripcion("PANEL", PedidoActual().id_panel), "no encontrado");
                    //else if (!PedidoActual().Isid_clienteNull())
                    //{
                    //    string desc=REDLibTools.Tools.isNull(adpPedidos.getDescripcion("PERSONA", PedidoActual().id_cliente), "no encontrado");
                    //    if (desc=="--")
                    //        desc = REDLibTools.Tools.isNull(adpPedidos.getDescripcion("CLIENTE", PedidoActual().id_cliente), "no encontrado");
                    //    return desc;
                    //}
                }
                return "";
            }
        }

        internal void ActualizarCliente()
        {
            if (PedidoActual()!=null)
            PedidoActual()._cliente = Cliente;
        }

        private void CargarSecundarios()
        {
            adpDires.FillFull(dtsDatos.DIRECCION);
            //adpAbonados.FillBasico(dtsDatos.PANEL);
            //adpPersonas.FillBasico(dtsDatos.PERSONA);
            adpCategorias.Fill(dtsDatos.CATEGORIA_PRODUCTO);
            adpProdBasicos.Fill(dtsDatos.PRODUCTO_REQUERIDO);
        }
        public DatosPresupuestos2.PRODxPEDIDORow ProdPedidoActual()
        {
            if (bindProdPedidos != null && bindProdPedidos.Current != null)
                return (DatosPresupuestos2.PRODxPEDIDORow)((DataRowView)bindProdPedidos.Current).Row;
            else
                return null;
        }

        public DatosPresupuestos2.PEDIDOSRow PedidoActual()
        {
            if (bindPedidos != null && bindPedidos.Current != null)
                return (DatosPresupuestos2.PEDIDOSRow)((DataRowView)bindPedidos.Current).Row;
            else
                return null;
        }
        public void cargarID(decimal idPedido)
        {
            adpPedidos.ClearBeforeFill = false;
            adpProdPedidos.ClearBeforeFill = false;
            adpPedidos.FillBy(dtsDatos.PEDIDOS, idPedido);
            adpProdPedidos.FillBy(dtsDatos.PRODxPEDIDO, idPedido);
            adpPedidos.ClearBeforeFill = true;
            adpProdPedidos.ClearBeforeFill = true;
        }

        public int guardarActual()
        {
            try
            {
                Validate();
                if (PedidoActual().id_pedido == -1)
                {
                    object maxid = adpPedidos.MaxID();
                    if (maxid != null)
                        PedidoActual().id_pedido = Convert.ToDecimal(maxid) + 1;
                    else
                        PedidoActual().id_pedido = 1;
                }
                bindPedidos.EndEdit();
                if (ID_PEDIDO != -1)
                {
                    bindProdPedidos.EndEdit();
                    adpProdPedidos.Update(dtsDatos.PRODxPEDIDO);
                    dtsDatos.PRODxPEDIDO.AcceptChanges();
                    adpPedidos.Update(dtsDatos.PEDIDOS);
                    dtsDatos.PEDIDOS.AcceptChanges();
                }
                else
                {
                    adpPedidos.Update(dtsDatos.PEDIDOS);
                    bindProdPedidos.EndEdit();
                    foreach (DataRow fila in dtsDatos.PRODxPEDIDO.Rows)
                        fila.SetAdded();
                    adpProdPedidos.Update(dtsDatos.PRODxPEDIDO);
                }
            }
            catch
            {
                return 1;
            }
            return 0;
        }

        public void guardarTodos()
        {
            adpPedidos.Update(((DatosPresupuestos2)bindProdPedidos.DataSource).PEDIDOS);
            ((DatosPresupuestos2)bindProdPedidos.DataSource).PEDIDOS.AcceptChanges();
        }

        internal DatosPresupuestos2.PANELRow AboActual()
        {
            if (bindAbonados.Current != null)
                return ((DatosPresupuestos2.PANELRow)((DataRowView)bindAbonados.Current).Row);
            else
                return null;
        }
        internal DatosPresupuestos2.PERSONARow PersonaActual()
        {
            if (bindPersonas.Current != null)
                return (DatosPresupuestos2.PERSONARow)((DataRowView)bindPersonas.Current).Row;
            else
                return null;
        }


        //manejo de productos
        //private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboCategoria.Focused && comboCategoria.SelectedIndex > -1)
        //    {
        //        CargarCombo();
        //        txtCantidad.Select();
        //    }
        //}
        private void cmdNuevoProdPedido_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (tieneCambios)
            //       guardarActual();

            LimpiarProductoPedido();
            NuevoProdPedido();

            //}
            //catch
            //{
            //    Mensaje.AlertaAviso("El pedido esta mal definido, revise informacion");
            //}
        }
        private void NuevoProdPedido()
        {
            groupNuevo.Enabled = true;
        //    agregando = true;
            if (comboCategoria.Text != "")
                txtCantidad.Select();
            else 
                comboCategoria.Select();
        }

        //private void CargarCombo()
        //{
        //    if (comboCategoria.Text != "")
        //    {
        //        comboProducto.Items.Clear();
        //        StreamReader lectorDatos = new StreamReader(Application.StartupPath + "\\itemsPedidos.xml", Encoding.UTF8);
        //        XmlTextReader lectorXML = new XmlTextReader(lectorDatos);
        //        XmlReader categoria = null;
        //        bool salir = false;
        //        while (lectorXML.Read() && !salir)
        //        {
        //            if (lectorXML.NodeType == XmlNodeType.Element && lectorXML.Name == "Categorias")
        //            {
        //                categoria = lectorXML.ReadSubtree();
        //                salir = true;
        //            }
        //        }
        //        salir = false;
        //        XmlReader items = null;
        //        while (categoria != null && categoria.Read() && !salir)
        //        {
        //            if (categoria.NodeType == XmlNodeType.Element && comboCategoria.Text.ToUpper() == categoria.Name.ToUpper())
        //            {
        //                items = categoria.ReadSubtree();
        //                salir = true;
        //            }
        //        }
        //        salir = false;
        //        while (items != null && items.Read() && !salir)
        //        {
        //            if (items.NodeType == XmlNodeType.Element)
        //                comboProducto.Items.Add(items.ReadString().ToUpper());
        //            else if (items.NodeType == XmlNodeType.EndElement && categoria.Name == items.Name)
        //                salir = true;
        //        }
        //    }
        //}

        
        private void txtPanel_Enter(object sender, EventArgs e)
        {
            if (listBusqueda == null)
            {
                if (optPanel.Checked)
                    listBusqueda = new SelectorDato(this, txtCliente,bindAbonados, "descripcion", "id_panel", "descripcion like '*{0}*' or numero_abonado='{0}'");
                else if (optPersona.Checked)
                    listBusqueda = new SelectorDato(this, txtCliente,bindPersonas, "_nombre", "id_persona", "_nombre like '*{0}*'","nombre,apellido");
                listBusqueda.seleccionNula += new SelectorDato.seleccionNulaEvent(listBusqueda_seleccionNula);
                listBusqueda.valorElegido += new SelectorDato.valorElegidoEvent(listBusqueda_valorElegido);
                listBusqueda.valorConfirmado += new SelectorDato.valorConfirmadoEvent(listBusqueda_valorConfirmado);
                listBusqueda.confirmaCrearNuevo += new SelectorDato.confirmaCrearNuevoEvent(listBusqueda_confirmaCrearNuevo);
            }
            else
            {
                if (optPanel.Checked)
                    listBusqueda.actualizarOrigen(this,txtCliente,bindAbonados, "descripcion", "id_panel", "descripcion like '*{0}*' or numero_abonado='{0}'");
                else if (optPersona.Checked)
                    listBusqueda.actualizarOrigen(this,txtCliente,bindPersonas, "_nombre", "id_persona", "_nombre like '*{0}*'","nombre,apellido");
            }
        }
        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (listBusqueda == null)
            {
                listBusqueda = new SelectorDato(this, txtDireccion,bindDirecciones, "_direccion", "id_direccion", "_direccion like '*{0}*'");
                listBusqueda.seleccionNula += new SelectorDato.seleccionNulaEvent(listBusqueda_seleccionNula);
                listBusqueda.valorElegido += new SelectorDato.valorElegidoEvent(listBusqueda_valorElegido);
                listBusqueda.valorConfirmado += new SelectorDato.valorConfirmadoEvent(listBusqueda_valorConfirmado);
                listBusqueda.confirmaCrearNuevo += new SelectorDato.confirmaCrearNuevoEvent(listBusqueda_confirmaCrearNuevo);
            }
            if (listBusqueda.control != txtDireccion)
            {
                listBusqueda.actualizarOrigen(this,txtDireccion,bindDirecciones, "_direccion", "id_direccion", "_direccion like '*{0}*'");
            }
        }

        //eventos de listado
        void listBusqueda_valorConfirmado(object sender, EventArgs arg)
        {
            ActualizarValor(sender);
        }

        private void CargarDireTel()
        {
            listDirecciones.Items.Clear();
            ManejoAdaptadores.DatosPresupuestosTableAdapters.DIRECCIONTableAdapter adpDires = new ManejoAdaptadores.DatosPresupuestosTableAdapters.DIRECCIONTableAdapter();
            //DatosPresupuestos2.DIRECCIONDataTable dires;
            //if (optPersona.Checked && !PedidoActual().Isid_clienteNull())
            //    dires = adpDires.GetDirePersona(PedidoActual().id_cliente);
            //else if (optPanel.Checked && !PedidoActual().Isid_panelNull())
            //    dires = adpDires.GetDirePanel(PedidoActual().id_panel);
            //else dires = null;
            //if (dires!=null)
            //    foreach (DatosPresupuestos2.DIRECCIONRow fila in dires)
            //        listDirecciones.Items.Add(fila._direccion);

            //listTelefonos.Items.Clear();
            //ManejoAdaptadores.DatosPresupuestosTableAdapters.TELEFONOTableAdapter adptels = new ManejoAdaptadores.DatosPresupuestosTableAdapters.TELEFONOTableAdapter();
            //DatosPresupuestos2.TELEFONODataTable tels;
            //if (optPersona.Checked && !PedidoActual().Isid_clienteNull())
            //    tels = adptels.GetTelPersona(PedidoActual().id_cliente);
            //else if (optPanel.Checked && !PedidoActual().Isid_panelNull())
            //    tels = adptels.GetTelPanel(PedidoActual().id_panel);
            //else tels = null;
            //if (tels!=null)
            //    foreach (DatosPresupuestos2.TELEFONORow fila in tels)
            //        listTelefonos.Items.Add(fila._telefono);
        }

        private void ActualizarValor(object sender)
        {
            if (((SelectorDato)sender).control == txtCliente)
            {
                //if (optPanel.Checked && PedidoActual() != null &&AboActual() != null)
                //   PedidoActual().id_panel =AboActual().ID_PANEL;
                //else if (optPersona.Checked &&PedidoActual() != null &&PersonaActual() != null)
                //   PedidoActual().id_cliente =PersonaActual().ID_PERSONA;
               CargarDireTel();
           }
            else if (((SelectorDato)sender).control == txtDireccion)
            {
                //if (PedidoActual() != null && DireccionActual() != null)
                //   PedidoActual().id_direccion = DireccionActual().ID_DIRECCION;
               CargarDireTel();
           }
           else if (((SelectorDato)sender).control == txtProducto)
           {
               
           }
        }

        private DatosPresupuestos2.DIRECCIONRow DireccionActual()
        {
            if (bindDirecciones.Current != null)
                return (DatosPresupuestos2.DIRECCIONRow)((DataRowView)bindDirecciones.Current).Row;
            else
                return null;
        }

        void listBusqueda_valorElegido(object sender, EventArgs arg)
        {
            ActualizarValor( sender);
        }

        void listBusqueda_seleccionNula(object sender, EventArgs arg)
        {
            if (((SelectorDato)sender).control == txtCliente)
            {
                if (PedidoActual() != null )
                {
                //   PedidoActual().Setid_panelNull();
                //   PedidoActual().Setid_clienteNull();
                //
                }
                listTelefonos.Items.Clear();
                listDirecciones.Items.Clear();
            }
            else if (((SelectorDato)sender).control == txtDireccion)
            {
                //if (PedidoActual() != null )
                //   PedidoActual().Setid_direccionNull();
            }
        }
        void listBusqueda_confirmaCrearNuevo(object sender, EventArgs arg)
        {
            if (((SelectorDato)sender).control == txtCliente)
            {
                if (optPanel.Checked)
                {
                    Mensaje.AlertaAviso("no programado aun");
                    //frmPanelNuevo panelNuevo = new frmPanelNuevo(null, -1, 1);
                    //panelNuevo.Show(this);
                }
                else if (optPersona.Checked)
                {
                    Mensaje.AlertaAviso("no programado aun");
                    //frmPersonaNuevo persNueva = new frmPersonaNuevo(null, -1);
                    //persNueva.Show(this);
                }
            }
            else if (((SelectorDato)sender).control == txtDireccion)
            {
                Mensaje.AlertaAviso("Aun no se puede crear direcciones");
                //frmPersonaNuevo persNueva = new frmdi(null, -1);
                //persNueva.Show(this);
            }
            else if (((SelectorDato)sender).control == txtProducto)
            {
                frmProdPedido prodPedido = new frmProdPedido(Convert.ToDecimal(comboCategoria.SelectedValue),txtProducto.Text);
                prodPedido.Show(this);
            }
        }

        private void cmdGuardarPedido_Click(object sender, EventArgs e)
        {
            if (guardarActual() == 0)
            {
                ID_PEDIDO=PedidoActual().id_pedido;
                Actualizado = true;
                Mensaje.AlertaAviso("Datos guardados");
                guardando = true;
                Close();
            }
            else
                Mensaje.AlertaAviso("Errores al guardar", MessageBoxIcon.Error);
        }
        //manejo producto pedido
        private void cmdSelProducto_Click(object sender, EventArgs e)
        {
            if (validoProdPedido())
            {
                guardarProductoPedido();
                LimpiarProductoPedido();
                cmdNuevoProdPedido.Focus();
                cmdNuevoProdPedido.Select();
            }
            else
            {
                Mensaje.AlertaAviso("Error. Verifique los datos");
                txtCantidad.Select();
            }
        }

        private void LimpiarProductoPedido()
        {
            txtCantidad.Text = "1";
            txtProducto.Text = "";
        }

        private void guardarProductoPedido()
        {
            if (PROD_ACTUAL == "")
            {
                DatosPresupuestos2.PRODxPEDIDORow nuevoProdPedido = dtsDatos.PRODxPEDIDO.NewPRODxPEDIDORow();
                levantarDatos(nuevoProdPedido);
                //try
                //{
                    dtsDatos.PRODxPEDIDO.AddPRODxPEDIDORow(nuevoProdPedido);
                //}
                //catch
                //{
                //    Mensaje.AlertaAviso("Este producto ya esta cargado en el pedido\nmodifique la cantidad de ese item");
                //}
            }
            else
            {
                //DatosPresupuestos2.PRODxPEDIDORow prodPedido= dtsDatos.PRODxPEDIDO.FindByid_pedidoproducto(PedidoActual().id_pedido, PROD_ACTUAL);
                //prodPedido.BeginEdit();
                //levantarDatos(prodPedido);
                //prodPedido.EndEdit();
                PROD_ACTUAL = "";
            }
            //nuevoProdPedido.SetAdded();
        }

        private void levantarDatos(DatosPresupuestos2.PRODxPEDIDORow nuevoProdPedido)
        {
            nuevoProdPedido.id_pedido = PedidoActual().id_pedido;
            int cantidad = 0;
            if (!int.TryParse(txtCantidad.Text, out cantidad))
                nuevoProdPedido.cantidad = 1;
            else
                nuevoProdPedido.cantidad = Convert.ToDecimal(cantidad);
            nuevoProdPedido.es_opcional = chkEsOpcional.Checked;
            nuevoProdPedido.nota = txtNotaProdPedido.Text;
            nuevoProdPedido.id_prod_requerido = ProdPedidoActual().id_prod_requerido;
        }
        private bool validoProdPedido()
        {
            decimal tmp;
            return (bindProductos.Current != null && txtProducto.Text!="" && decimal.TryParse(txtCantidad.Text,out tmp));
        }

        //private bool agregando = false;
        private void groupNuevo_Leave(object sender, EventArgs e)
        {
            if (listBusqueda==null || !listBusqueda.seleccionando)
            {
                LimpiarProductoPedido();
                groupNuevo.Enabled = false;
            }
            //if (bindProdPedidos.Current != null)
            //{
            //    DataRow actual = ((DataRowView)bindProdPedidos.Current).Row;
            //    if (actual.RowState == DataRowState.Modified || actual.RowState == DataRowState.Added && this.txtProducto.Text != "")
            //    {
            //        DialogResult resul = Mensaje.AlertaConfirmaSiNoCancel("Hay cambios. Quiere guardar?");
            //        if (resul == DialogResult.Yes)
            //        {
            //            actual.EndEdit();
            //            agregando = false;
            //            groupNuevo.Enabled = false;
            //        }
            //        else if (resul == DialogResult.No)
            //        {
            //            actual.CancelEdit();
            //            agregando = false;
            //            groupNuevo.Enabled = false;
            //        }
            //        else if (resul == DialogResult.Cancel)
            //        {
            //            txtCantidad.Select();
            //        }
            //    }
            //    else if (actual.RowState == DataRowState.Detached && txtProducto.Text == "")
            //       bindProdPedidos.CancelEdit();
            //}
        }
        private void gridProdPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                EditarProdActual();
            }
        }

        private void Control2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.SelectNextControl(((Control)sender), true, true, true, true);
                e.Handled = true;
            }
        }

        private void optPanel_CheckedChanged(object sender, EventArgs e)
        {
            if (optPanel.Focused)
                IniciarBusquedaCliente();
        }

        private void optPersona_CheckedChanged(object sender, EventArgs e)
        {
            if (optPersona.Focused)
                IniciarBusquedaCliente();

        }

        private void optCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (optCliente.Focused)
                IniciarBusquedaCliente();
        }

        private void IniciarBusquedaCliente()
        {
            txtCliente.Text = "";
            txtCliente.Select();
            //if (optPanel.Checked)
            //   PedidoActual().Setid_clienteNull();
            //else if (optPersona.Checked)
            //   PedidoActual().Setid_panelNull();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void cmdCrearPresupueso_Click(object sender, EventArgs e)
        {
            if (PedidoActual() != null)
            {
                frmPresupuesto presupuesto = new frmPresupuesto(PedidoActual().id_pedido);
                presupuesto.Show();
            }
        }

        private void txtProducto_Enter(object sender, EventArgs e)
        {
            if (listBusqueda == null)
            {
                listBusqueda = new SelectorDato(this, txtProducto,bindProductos, "nombre", "id_prod_requerido", "nombre like '*{0}*'");
                listBusqueda.seleccionNula += new SelectorDato.seleccionNulaEvent(listBusqueda_seleccionNula);
                listBusqueda.valorElegido += new SelectorDato.valorElegidoEvent(listBusqueda_valorElegido);
                listBusqueda.valorConfirmado += new SelectorDato.valorConfirmadoEvent(listBusqueda_valorConfirmado);
                listBusqueda.confirmaCrearNuevo += new SelectorDato.confirmaCrearNuevoEvent(listBusqueda_confirmaCrearNuevo);
            }
            else if (!listBusqueda.mismoControl(txtProducto))
            {
                listBusqueda.actualizarOrigen(this, txtProducto, bindProductos, "nombre", "id_prod_requerido", "nombre like '*{0}*'");
            }
        }

        private void cmdEliminarProdPedido_Click(object sender, EventArgs e)
        {
            if (gridProdPedido.SelectedRows.Count>0 && Mensaje.AlertaOK("Esta por eliminar el producto(s) seleccionado(s)") == DialogResult.OK)
            {
                foreach (DataGridViewRow fila in gridProdPedido.SelectedRows)
                    ((DataRowView)fila.DataBoundItem).Row.Delete();
            }
        }

        private void gridProdPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private string PROD_ACTUAL="";

        private void cmdEditarProdPedido_Click(object sender, EventArgs e)
        {
            EditarProdActual();
        }

        private void EditarProdActual()
        {
            groupNuevo.Enabled = true;
            txtCantidad.Select();
            //PROD_ACTUAL = ProdPedidoActual().producto;
            llenarControles(ProdPedidoActual());
        }

        private void llenarControles(DatosPresupuestos2.PRODxPEDIDORow pRODxPEDIDORow)
        {
            //txtProducto.Text = pRODxPEDIDORow.producto;
            txtCantidad.Text = pRODxPEDIDORow.cantidad.ToString();
            if (pRODxPEDIDORow.IsnotaNull())
                txtNotaProdPedido.Text = pRODxPEDIDORow.nota;
            else
                txtNotaProdPedido.Text = "";
            chkEsOpcional.Checked = pRODxPEDIDORow.es_opcional;
        }

        private bool guardando = false;

        private void frmPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!guardando)
            {
                DialogResult resul = Mensaje.AlertaConfirmaSiNoCancel("Esta por salir. Desea guardar antes?");
                if (resul == DialogResult.Yes)
                    cmdGuardarPedido.PerformClick();
                else if (resul== DialogResult.Cancel)
                    e.Cancel=true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }


        
    }
    

}