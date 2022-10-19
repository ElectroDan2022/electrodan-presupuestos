using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ManejoImagenes;
using System.Data.SqlClient;
using REDLibTools;
using ManejoImpresiones;
using ManejoPresupuestos;
using ManejoAdaptadores;

namespace ManejoTareas
{
    public partial class frmPresuNuevo : Form
    {
        #region declaraciones
        DatosPresupuesto datos;
        BindingSource bindprod;
        BindingSource bindprodpresu;
        BindingSource bindpresu;
        IMG2DB pic2db;
        bool _paraDaniel;
        #endregion

        #region inicializacion
        public frmPresuNuevo(bool para_daniel = false)
        {
            InitializeComponent();
            _paraDaniel = para_daniel;
            picCaptura.Image = Recursos.Properties.Resources.captura_32;
            picBuscador.Image = Recursos.Properties.Resources.search_48;
            pic2.Image = Recursos.Properties.Resources.search_32;
            cmdGuardar.Image = Recursos.Properties.Resources.floppy_disk_32;
            cmdGuardCopia.Image = Recursos.Properties.Resources.floppy_disk_copy_32;
            cmdGuardarPresu.Image = Recursos.Properties.Resources.floppy_disk_32;
            cmdImprimirPresu.Image = Recursos.Properties.Resources.printer_32;
            cmdNuevoPresu.Image = Recursos.Properties.Resources.add_32;
            cmdAgregarCliente.Image = Recursos.Properties.Resources.add_16;
            dateDesde.Value = DateTime.Today.AddMonths(-3);
            cmdBuscarContacto.Image = Recursos.Properties.Resources.search_16;
            dateHasta.Value = DateTime.Today.AddDays(7);
            datos = new DatosPresupuesto();
            ToolsDB.AgregarColumna(datos.Presupuestos, "id_presu", typeof(int), "id_presupuesto");
            pic2db = new IMG2DB(pictureBox1, ConfigPersonalizada.ELECTRODANConnectionString1, "base.dbo.Productos", "imagen", "id_producto");
            pic2db.AutoAjuste = true;
            gridProductos.AutoGenerateColumns = false;
            gridPresuAnteriores.AutoGenerateColumns = false;
            gridPresupuestos.AutoGenerateColumns = false;
            bindprod = new BindingSource(datos, "productos");
            bindprod.AddingNew += new AddingNewEventHandler(bindprod_AddingNew);
            bindpresu = new BindingSource(datos, "presupuestos");
            bindpresu.Sort = "id_presupuesto";
            bindpresu.CurrentChanged += new EventHandler(bindpresu_CurrentChanged);
            bindpresu.AddingNew += new AddingNewEventHandler(bindpresu_AddingNew);
            bindprodpresu = new BindingSource(bindpresu, "presu_prod");
            bindprodpresu.Sort = "orden";
            pic2db.AsociarColumna(colFoto);

        }

        private bool cargado = false;

        private void frmPresuNuevo_Load(object sender, EventArgs e)
        {

            Refresh();
            cargarDatos();
            AsociarControlesProd();

            gridPresuAnteriores.DataSource = bindpresu;
            gridProductos.DataSource = bindprod;
            gridPresupuestos.DataSource = bindprodpresu;

            //bindpresu.AddNew();
            vistaPanel(true);
            cargado = true;
        }

        private void cargarDatos()
        {
            Tools.IniciarEspera(this);
            datos.Clear();
            DataTable categorias = ToolsDB.TablaConsultaRapida(@"select id,nombre from base.dbo.categoria_producto", "BASE");
            if (categorias != null)
                datos.CategProducto.Load(categorias.CreateDataReader());

            DataTable prodReq = ToolsDB.TablaConsultaRapida(@"select id_prod_requerido,id_categoria,nombre from base.dbo.producto_requerido", "BASE");
            if (prodReq != null)
                datos.ProdRequerido.Load(prodReq.CreateDataReader());
            DataTable productos = ToolsDB.TablaConsultaRapida(
                        @"select id_producto
                                    ,imagen
                                    ,descripcion
                                    ,marca
                                    ,modelo
                                    ,porc_iva_costo
                                    ,precio_costo_pesos
                                    ,id_prod_requerido
                                    ,precio_costo_dolar
                                    ,valor_dolar 
                                    ,mano_obra_predef
                                    ,porc_ganancia_predef
                                    ,es_favorito
                            from productos", "BASE");
            if (productos != null)
                datos.Productos.Load(productos.CreateDataReader());

            cargarPresupuestos();
            Tools.TerminarEspera(this);
        }

        private void cargarPresupuestos(bool todos = false)
        {
            try
            {
                datos.ProdxPresu.Clear();
                datos.Presupuestos.Clear();
                DesasociarControlesPresu();
                SqlConnection conn = new SqlConnection(ManejoAdaptadores.ConfigPersonalizada.ELECTRODANConnectionString1);
                conn.Open();
                string consulta =
                            @"select id_presupuesto
                                        ,fecha_creado as fecha
                                        ,fecha_modif
                                        ,valor_dolar
                                        ,esta_confirmado
                                        ,ajuste
                                        ,monto_final
                                        ,titulo_presupuesto as cliente
                                        ,direccion
                                        ,telefono
                                        ,nota
                                        ,monitoreo
                                        ,precio_monitoreo
                                        ,motivo
                                        ,nota_instalacion
                                        ,mail
                                        ,es_tercerizado
                                    from base.dbo.presupuestos ";
                int idpresu = -1;
                if (txtFiltroPresupuestos.Text != "")
                {
                    if (Int32.TryParse(txtFiltroPresupuestos.Text, out idpresu))
                        consulta += "where id_presupuesto=@filtro_int" + (txtFiltroPresupuestos.Text.Length > 5 ? " or telefono like '%'+@filtro+'%'" : "");
                    else
                        consulta += "where titulo_presupuesto like '%'+@filtro+'%' or nota like '%'+@filtro+'%' or direccion like '%'+@filtro+'%' or telefono like '%'+@filtro+'%'";
                }
                else if (!todos)
                    consulta += "where fecha_creado between @fechadesde and @fechahasta";

                SqlCommand cmd = new SqlCommand(consulta, conn);
                if (txtFiltroPresupuestos.Text != "")
                {
                    cmd.Parameters.AddWithValue("@filtro", txtFiltroPresupuestos.Text);
                    if (idpresu != -1)
                        cmd.Parameters.AddWithValue("@filtro_int", idpresu);
                }
                else if (!todos)
                {
                    cmd.Parameters.AddWithValue("@fechadesde", dateDesde.Value);
                    cmd.Parameters.AddWithValue("@fechahasta", dateHasta.Value);
                }
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    datos.Presupuestos.Load(reader, LoadOption.OverwriteChanges);
                    //datos.Presupuestos.AcceptChanges();
                }
                conn.Close();
                bindpresu.ResumeBinding();
                AsociarControlesPresu();
                Tools.CursorAUltimaCelda(gridPresuAnteriores);
            }
            catch (Exception ex)
            {
                ToolsDB.GuardarError(ex.Message);
            }
        }

        void recargarProdRequerido(int id_prod)
        {
            DataTable prodReq = ToolsDB.TablaConsultaRapida(string.Format(@"select id_prod_requerido,id_categoria,nombre from base.dbo.producto_requerido where id_prod_requerido={0}", id_prod), "BASE");
            if (prodReq != null)
            {
                datos.ProdRequerido.Load(prodReq.CreateDataReader(), LoadOption.OverwriteChanges);
                datos.ProdRequerido.AcceptChanges();
            }
        }

        void bindpresu_CurrentChanged(object sender, EventArgs e)
        {
            if (PresuActual != null)
            {
                recargarProdPresu();
                //if (PresuActual.IstotalNull())
                //    PresuActual.Setmonto_finalNull();
                //else 
                //    PresuActual.monto_final= PresuActual.total;
            }
        }

        private void recargarProdPresu()
        {
            if (PresuActual.RowState != DataRowState.Added && PresuActual.id_presupuesto != -1)
            {
                datos.ProdxPresu.Clear();
                DataTable tmp = ToolsDB.TablaConsultaRapida(@"select 
                                                               [id_presupuesto]
                                                               ,[cantidad]
                                                               ,[id_producto]
                                                               ,[porc_ganancia]
                                                               ,producto
                                                               ,porc_iva
                                                               ,mano_obra
                                                               ,precio_pesos
                                                               ,precio_dolar
                                                               ,es_mobra
                                                               ,orden
                                                            from [BASE].[dbo].[PRODxPRESUPUESTO]
                                                            where id_presupuesto=" + PresuActual.id_presupuesto, "BASE");
                if (tmp != null)
                {
                    try
                    {
                        datos.ProdxPresu.Load(tmp.CreateDataReader());
                        datos.ProdxPresu.AcceptChanges();
                    }
                    catch
                    {
                        Mensaje.AlertaError("error en carga");
                    }
                }
                ObtenerCostos();
            }
        }
        private void AsociarControlesProd()
        {
            pic2db.AsociarBind(bindprod);
            txtProducto.DataBindings.Add("text", bindprod, "xproducto");
            txtCategoria.DataBindings.Add("text", bindprod, "xcategoria");
            txtDescripcion.DataBindings.Add("text", bindprod, "descripcion");
            txtModelo.DataBindings.Add("text", bindprod, "modelo");
            txtMarca.DataBindings.Add("text", bindprod, "marca");
            lblPrecio.DataBindings.Add("text", bindprod, "xventa", true, DataSourceUpdateMode.OnPropertyChanged, "-", "N2");
            chkEsFavorito.DataBindings.Add("checked", bindprod, "es_favorito");
            numCostoDolar.DataBindings.Add("value", bindprod, "precio_costo_dolar", true, DataSourceUpdateMode.OnValidation, "-", "N2");
            numManoObra.DataBindings.Add("value", bindprod, "mano_obra_predef", true, DataSourceUpdateMode.OnValidation, "-", "N2");
            numCostoPesos.DataBindings.Add("value", bindprod, "precio_costo_pesos", true, DataSourceUpdateMode.OnValidation, "-", "N2");
            numGanancia.DataBindings.Add("value", bindprod, "porc_ganancia_predef", true, DataSourceUpdateMode.OnValidation, "-", "N2");
            numIVA.DataBindings.Add("value", bindprod, "porc_iva_costo", true, DataSourceUpdateMode.OnValidation, "-", "N2");
            numDolar.DataBindings.Add("value", bindprod, "valor_dolar", true, DataSourceUpdateMode.OnValidation, "-", "N2");
        }

        private void AsociarControlesPresu()
        {
            gridPresuAnteriores.DataSource = bindpresu;
            txtNroPresu.DataBindings.Add("text", bindpresu, "id_presu");
            lblAjuste.DataBindings.Add("text", bindpresu, "ajuste", true, DataSourceUpdateMode.OnPropertyChanged, "-", "N2");
            lblActual.DataBindings.Add("text", bindpresu, "total", true, DataSourceUpdateMode.OnPropertyChanged, "-", "N2");
            lblTotal.DataBindings.Add("text", bindpresu, "total", true, DataSourceUpdateMode.OnPropertyChanged, "-", "N2");
            lblManoObra.DataBindings.Add("text", bindpresu, "xmobra", true, DataSourceUpdateMode.OnPropertyChanged, "-", "N2");
            pres_costo.DataBindings.Add("text", bindpresu, "xcosto_final", true, DataSourceUpdateMode.OnPropertyChanged, "-", "N2");
            pres_dif.DataBindings.Add("text", bindpresu, "xdiferencia", true, DataSourceUpdateMode.OnPropertyChanged, "-", "N2");
            pres_ajuste.DataBindings.Add("text", bindpresu, "ajuste", true, DataSourceUpdateMode.OnPropertyChanged, "-", "N2");
            pres_venta.DataBindings.Add("text", bindpresu, "total", true, DataSourceUpdateMode.OnPropertyChanged, "-", "N2");
            pres_venta2.DataBindings.Add("text", bindpresu, "total", true, DataSourceUpdateMode.OnPropertyChanged, "-", "N2");
            txtCliente.DataBindings.Add("text", bindpresu, "cliente");
            txtMail.DataBindings.Add("text", bindpresu, "mail");
            txtNotaImprimible.DataBindings.Add("text", bindpresu, "nota_instalacion");
            txtDireccion.DataBindings.Add("text", bindpresu, "direccion");
            txtTelefono.DataBindings.Add("text", bindpresu, "telefono");
            comboMotivoPresu.DataBindings.Add("text", bindpresu, "motivo");
            txtNota.DataBindings.Add("text", bindpresu, "nota");
            txtMonitoreo.DataBindings.Add("text", bindpresu, "monitoreo");
            numMonitoreo.DataBindings.Add("value", bindpresu, "precio_monitoreo", true, DataSourceUpdateMode.OnPropertyChanged, "-", "N2");
            dateFechaPresu.DataBindings.Add("value", bindpresu, "fecha");
            numDolarPresu.DataBindings.Add("value", bindpresu, "valor_dolar", true, DataSourceUpdateMode.OnPropertyChanged, "-", "N2");
            numDolarPresu2.DataBindings.Add("value", bindpresu, "valor_dolar", true, DataSourceUpdateMode.OnPropertyChanged, "-", "N2");
            chkConfirmado.DataBindings.Add("checked", bindpresu, "esta_confirmado");
            chkManoObra.DataBindings.Add("checked", bindpresu, "es_tercerizado", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void DesasociarControlesPresu()
        {
            gridPresuAnteriores.DataSource = null;
            txtNroPresu.DataBindings.Clear();
            lblAjuste.DataBindings.Clear();
            lblActual.DataBindings.Clear();
            lblTotal.DataBindings.Clear();
            pres_costo.DataBindings.Clear();
            pres_dif.DataBindings.Clear();
            pres_ajuste.DataBindings.Clear();
            pres_venta.DataBindings.Clear();
            pres_venta2.DataBindings.Clear();
            lblManoObra.DataBindings.Clear();
            txtCliente.DataBindings.Clear();
            comboMotivoPresu.DataBindings.Clear();
            txtNotaImprimible.DataBindings.Clear();
            txtDireccion.DataBindings.Clear();
            txtMail.DataBindings.Clear();
            txtTelefono.DataBindings.Clear();
            txtNota.DataBindings.Clear();
            txtMonitoreo.DataBindings.Clear();
            numMonitoreo.DataBindings.Clear();
            dateFechaPresu.DataBindings.Clear();
            numDolarPresu.DataBindings.Clear();
            numDolarPresu2.DataBindings.Clear();
            chkConfirmado.DataBindings.Clear();
            chkManoObra.DataBindings.Clear();
        }
        #endregion

        #region manejo presupuesto
        private DatosPresupuesto.PresupuestosRow PresuActual
        {
            get
            {
                if (bindpresu.Current != null)
                    return (DatosPresupuesto.PresupuestosRow)((DataRowView)bindpresu.Current).Row;
                else
                    return null;
            }
        }

        void bindpresu_AddingNew(object sender, AddingNewEventArgs e)
        {
            DataRowView nuevo = ((DataView)bindpresu.List).AddNew();
            DatosPresupuesto.PresupuestosRow nuevoPresu = (DatosPresupuesto.PresupuestosRow)nuevo.Row;
            nuevoPresu.id_presupuesto = -1;
            nuevoPresu.cliente = "PRESUPUESTO NUEVO";
            nuevoPresu.ajuste = 0;
            if (comboMotivo.SelectedIndex > 0)
                nuevoPresu.motivo = comboMotivo.Text;
            nuevoPresu.fecha = DateTime.Now;
            nuevoPresu.valor_dolar = Convert.ToSingle(ToolsDB.getConstante("valor_dolar"));
            nuevoPresu.esta_confirmado = false;
            nuevo.EndEdit();
            e.NewObject = nuevo;
            bindpresu.Position = bindpresu.IndexOf(nuevo);
            ObtenerCostos();
        }

        private void guardarPresuActual(bool silence = true)
        {
            if (PresuActual.id_presupuesto == -1)
                crearPresupuesto(silence);
            else
                actualizarPresupuesto(silence);
        }

        private void limpiarListaProdPresu()
        {
            ToolsDB.TablaConsultaRapida("delete from base.dbo.prodxpresupuesto where id_presupuesto=" + PresuActual.id_presupuesto, "BASE");
        }

        private void insertarListaProdPresu()
        {
            if (gridPresupuestos.Rows.Count > 0)
                for (int i = 0; i < gridPresupuestos.Rows.Count; i++)
                {
                    ((DataRowView)gridPresupuestos.Rows[i].DataBoundItem).Row.EndEdit();
                    insertarProdPresu(((DataRowView)gridPresupuestos.Rows[i].DataBoundItem).Row);
                    ((DataRowView)gridPresupuestos.Rows[i].DataBoundItem).Row.AcceptChanges();
                }
        }

        private void insertarProdPresu(DataRow dataRow)
        {
            DatosPresupuesto.ProdxPresuRow fila = (DatosPresupuesto.ProdxPresuRow)dataRow;
            SqlConnection con = new SqlConnection(ConfigPersonalizada.ELECTRODANConnectionString1);
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [BASE].[dbo].[PRODxPRESUPUESTO]
                                                   ([id_presupuesto]
                                                   ,orden
                                                   ,[cantidad]
                                                   ,[id_producto]
                                                   ,[porc_ganancia]
                                                   ,porc_iva
                                                   ,mano_obra
                                                   ,producto
                                                   ,precio_pesos
                                                   ,precio_dolar
                                                   ,es_mobra)
                                             VALUES
                                                   (@id_presupuesto
                                                    ,@orden
                                                   ,@cantidad
                                                   ,@id_producto
                                                   ,@porc_ganancia
                                                   ,@porc_iva
                                                   ,@mano_obra
                                                   ,@producto
                                                   ,@precio_pesos
                                                   ,@precio_dolar
                                                   ,@es_mobra)", con);
            cmd.Parameters.AddWithValue("@id_presupuesto", fila.id_presupuesto);
            cmd.Parameters.AddWithValue("@orden", fila.orden);
            cmd.Parameters.AddWithValue("@cantidad", fila.cantidad);
            cmd.Parameters.AddWithValue("@id_producto", fila.id_producto);
            cmd.Parameters.AddWithValue("@mano_obra", fila.mano_obra);
            cmd.Parameters.AddWithValue("@producto", fila.producto);
            cmd.Parameters.AddWithValue("@porc_iva", fila.porc_iva);
            cmd.Parameters.AddWithValue("@porc_ganancia", fila.porc_ganancia);
            cmd.Parameters.AddWithValue("@precio_pesos", fila.precio_pesos);
            cmd.Parameters.AddWithValue("@precio_dolar", fila.precio_dolar);
            cmd.Parameters.AddWithValue("@es_mobra", fila.es_mobra);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            if (null != con) con.Close();
        }

        private void crearPresupuesto(bool silence)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigPersonalizada.ELECTRODANConnectionString1);
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [BASE].[dbo].[PRESUPUESTOS]
                                                       ([fecha_modif]
                                                       ,[fecha_creado]
                                                       ,[titulo_presupuesto]
                                                       ,[valor_dolar]
                                                       ,[esta_confirmado]
                                                       ,ajuste
                                                       ,monto_final
                                                       ,direccion
                                                       ,telefono
                                                       ,nota
                                                       ,motivo
                                                       ,monitoreo
                                                       ,precio_monitoreo
                                                       ,nota_instalacion
                                                       ,mail)
                                                 VALUES
                                                       (getdate()
                                                       ,@fecha
                                                       ,@cliente
                                                       ,@valor_dolar
                                                       ,@confirmado
                                                       ,@ajuste
                                                       ,@monto_final
                                                       ,@direccion
                                                       ,@telefono
                                                       ,@nota
                                                       ,@motivo
                                                       ,@monitoreo
                                                       ,@precio_monitoreo
                                                       ,@nota_instalacion
                                                        ,@mail);
                                            SELECT @@identity;", con);
                presuActualParametros(cmd);
                con.Open();
                SqlDataReader resul = cmd.ExecuteReader();
                resul.Read();
                if (resul.HasRows && !resul.IsDBNull(0))
                {
                    PresuActual.id_presupuesto = Convert.ToInt32(resul[0]);
                    PresuActual.fecha_modif = ToolsDB.horaServidor();
                    PresuActual.monto_final = PresuActual.total;
                    bindpresu.EndEdit();
                    insertarListaProdPresu();
                    PresuActual.AcceptChanges();
                    //bindpresu.ResetCurrentItem();//.ResetBindings(false);
                    if (!silence)
                        Mensaje.AlertaAviso(string.Format("Presupuesto #{0} creado!", resul[0]));
                }
                con.Close();
                if (null != con) con.Close();
            }
            catch
            {
                Mensaje.AlertaError("Errores en creacion, intente nuevamente luego");
            }
        }

        private void presuActualParametros(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@fecha", PresuActual.fecha);
            cmd.Parameters.AddWithValue("@cliente", PresuActual.cliente);
            cmd.Parameters.AddWithValue("@valor_dolar", PresuActual.valor_dolar);
            cmd.Parameters.AddWithValue("@ajuste", PresuActual.ajuste);
            cmd.Parameters.AddWithValue("@confirmado", PresuActual.esta_confirmado);
            cmd.Parameters.AddWithValue("@monto_final", PresuActual.total);
            cmd.Parameters.AddWithValue("@nota", PresuActual.nota);
            cmd.Parameters.AddWithValue("@motivo", PresuActual.motivo);
            cmd.Parameters.AddWithValue("@mail", PresuActual.mail);
            cmd.Parameters.AddWithValue("@direccion", PresuActual.direccion);
            cmd.Parameters.AddWithValue("@telefono", PresuActual.telefono);
            cmd.Parameters.AddWithValue("@monitoreo", PresuActual.monitoreo);
            cmd.Parameters.AddWithValue("@precio_monitoreo", PresuActual.precio_monitoreo);
            cmd.Parameters.AddWithValue("@nota_instalacion", PresuActual.nota_instalacion);
            cmd.Parameters.AddWithValue("@es_tercerizado", PresuActual.es_tercerizado);
        }

        private void actualizarPresupuesto(bool silence)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigPersonalizada.ELECTRODANConnectionString1);
                SqlCommand cmd = new SqlCommand(
                    @"update [BASE].[dbo].[PRESUPUESTOS]
                set [fecha_modif]=getdate()
                    ,[fecha_creado]=@fecha
                    ,[titulo_presupuesto]=@cliente
                    ,[valor_dolar]=@valor_dolar
                    ,ajuste=@ajuste
                    ,[esta_confirmado]=@confirmado
                    ,monto_final=@monto_final
                    ,direccion=@direccion
                    ,telefono=@telefono
                    ,nota=@nota
                    ,motivo=@motivo
                    ,mail=@mail
                    ,monitoreo=@monitoreo
                    ,precio_monitoreo=@precio_monitoreo
                    ,nota_instalacion=@nota_instalacion
                    ,es_tercerizado=@es_tercerizado
                where id_presupuesto=@id_presupuesto", con);
                cmd.Parameters.AddWithValue("@id_presupuesto", PresuActual.id_presupuesto);
                presuActualParametros(cmd);
                con.Open();
                int resul = cmd.ExecuteNonQuery();
                PresuActual.monto_final = PresuActual.total;
                PresuActual.fecha_modif = ToolsDB.horaServidor();
                bindpresu.EndEdit();
                limpiarListaProdPresu();
                insertarListaProdPresu();
                PresuActual.AcceptChanges();
                con.Close();
                if (null != con) con.Close();
                if (!silence)
                    Mensaje.AlertaAviso("Presupuesto actualizado!");
            }
            catch (Exception ex)
            {
                Mensaje.AlertaError("Errores al actualizar, reintente\n" + ex.Message);
            }

        }
        private void imprimirPresuActual()
        {
            datosImpresiones datosImp = new datosImpresiones();
            datosImpresiones.presuCabezaRow encabezado = datosImp.presuCabeza.NewpresuCabezaRow();
            encabezado.cliente = PresuActual.cliente.ToUpper();
            encabezado.dire = PresuActual.direccion.ToString();
            encabezado.fecha = PresuActual.fecha;
            encabezado.permanencia = "";
            encabezado.tel = PresuActual.telefono.ToString();
            if (PresuActual.precio_monitoreo > 0)
                encabezado.texto_abono = ToolsPrint.getTextoMonitoreo(PresuActual.monitoreo, PresuActual.precio_monitoreo);
            if (!PresuActual.Isnota_instalacionNull() && PresuActual.nota_instalacion != "")
                encabezado.nota_instalacion = "NOTA:\n" + PresuActual.nota_instalacion;
            if (PresuActual.total == 0)
                encabezado.texto_instalacion = "";
            else
                encabezado.texto_instalacion = ToolsPrint.getTextoInstalacion(PresuActual.total);
            encabezado.texto_motivo = ToolsPrint.getTextMotivo(comboMotivoPresu.Text);
            encabezado.id = 1;
            datosImp.presuCabeza.AddpresuCabezaRow(encabezado);
            foreach (DataGridViewRow fila in gridPresupuestos.Rows)
            {
                DatosPresupuesto.ProdxPresuRow prod = (DatosPresupuesto.ProdxPresuRow)((DataRowView)fila.DataBoundItem).Row;
                if (!prod.es_mobra)
                {
                    if (prod.cantidad != 0)
                        datosImp.presuCuerpo.AddpresuCuerpoRow(ToolsPrint.getCantidad(prod.cantidad), prod.producto, encabezado);
                    else
                        datosImp.presuAdicional.AddpresuAdicionalRow(prod.xventa, prod.producto, encabezado);
                }
            }
            frmImprimirPresupuesto presuImpr = new frmImprimirPresupuesto(datosImp, PresuActual.id_presupuesto, _paraDaniel);
            presuImpr.Show();
        }
        private int ValidarPresupuesto()
        {
            if (PresuActual != null)
            {
                this.Validate();
                bindpresu.EndEdit();
                if (ToolsDB.RowHasChange(PresuActual) || ToolsDB.TableHasChanges(datos.ProdxPresu))
                {
                    DialogResult resul = Mensaje.AlertaConfirmaSiNoCancel("Hay cambios, guardarlos?");
                    if (resul == DialogResult.Yes)
                    {
                        guardarPresuActual(true);
                        PresuActual.AcceptChanges();
                    }
                    else if (resul == DialogResult.No)
                    {
                        PresuActual.CancelEdit();
                        if (PresuActual.RowState == DataRowState.Added)
                        {
                            datos.ProdxPresu.Clear();
                            bindpresu.RemoveCurrent();
                        }
                        else
                        {
                            PresuActual.RejectChanges();
                            recargarProdPresu();
                        }
                    }
                    else
                        return 1;
                }
            }
            return 0;
        }
        #endregion

        #region manejo producto
        private DatosPresupuesto.ProductosRow ProductoActual
        {
            get
            {
                if (bindprod.Current != null)
                    return (DatosPresupuesto.ProductosRow)((DataRowView)bindprod.Current).Row;
                else
                    return null;
            }
        }

        private void valoresXdefecto(DataRow dataRow)
        {
            DatosPresupuesto.ProductosRow fila = (DatosPresupuesto.ProductosRow)dataRow;
            fila.id_producto = -1;
            fila.id_prod_requerido = -1;
            fila.marca = "";
            fila.modelo = "";
            fila.descripcion = "";
            fila.es_favorito = false;
            fila.precio_costo_pesos = 0;
            fila.precio_costo_dolar = 0;
            fila.valor_dolar = 5.5F;
            fila.mano_obra_predef = 0;
            fila.porc_ganancia_predef = 30;
            fila.porc_iva_costo = 21;
        }
        private void guardarActual(bool silence = true)
        {
            if (Convert.ToDecimal(ProductoActual.id_producto) == -1)
                crearProducto(silence);
            else
                actualizarProducto(silence);
        }
        private void actualizarProducto(bool silence)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigPersonalizada.ELECTRODANConnectionString1);
                SqlCommand cmd = new SqlCommand(
                    @"update [BASE].[dbo].[PRODUCTOS]
                set [descripcion]=@descripcion
	                ,[modelo]=@modelo
	                ,[marca]=@marca
	                ,[imagen]=@imagen
                    ,id_prod_requerido=@id_prod_req
	                ,porc_ganancia_predef=@porc_ganancia_predef
                    ,porc_iva_costo=@porc_iva_costo
	                ,valor_dolar=@valor_dolar
	                ,precio_costo_dolar=@precio_costo_dolar
	                ,precio_costo_pesos=@precio_costo_pesos
                    ,es_favorito=@es_favorito
                    ,mano_obra_predef=@mano_obra
                where id_producto=@id_producto", con);
                Validate();
                bindprod.EndEdit();
                cmd.Parameters.AddWithValue("@id_producto", ProductoActual.id_producto);
                prodActualParametros(cmd);
                con.Open();
                int resul = cmd.ExecuteNonQuery();
                if (!silence)
                    Mensaje.AlertaAviso("Producto actualizado!");
                ProductoActual.AcceptChanges();
                con.Close();
                if (null != con) con.Close();
            }
            catch { Mensaje.AlertaError("Errores al actualizar producto, reintente."); }
        }
        private void prodActualParametros(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@id_prod_req", ProductoActual.id_prod_requerido);
            cmd.Parameters.AddWithValue("@descripcion", ProductoActual.descripcion);
            cmd.Parameters.AddWithValue("@modelo", ProductoActual.modelo);
            cmd.Parameters.AddWithValue("@marca", ProductoActual.marca);
            if (!ProductoActual.IsimagenNull())
                cmd.Parameters.AddWithValue("@imagen", ProductoActual.imagen);
            else
                cmd.Parameters.AddWithValue("@imagen", pic2db.getNula());
            cmd.Parameters.AddWithValue("@porc_ganancia_predef", ProductoActual.porc_ganancia_predef);
            cmd.Parameters.AddWithValue("@porc_iva_costo", ProductoActual.porc_iva_costo);
            cmd.Parameters.AddWithValue("@precio_costo_pesos", ProductoActual.precio_costo_pesos);
            cmd.Parameters.AddWithValue("@precio_costo_dolar", ProductoActual.precio_costo_dolar);
            cmd.Parameters.AddWithValue("@valor_dolar", ProductoActual.valor_dolar);
            cmd.Parameters.AddWithValue("@es_favorito", ProductoActual.es_favorito);
            cmd.Parameters.AddWithValue("@mano_obra", ProductoActual.mano_obra_predef);
        }
        private void EliminarProducto()
        {
            if (Mensaje.AlertaOK("Esta por eliminar el producto") == DialogResult.OK)
            {
                if (Convert.ToDecimal(ProductoActual.id_producto) != -1)
                    ToolsDB.TablaConsultaRapida("delete from productos where id_producto=" + ProductoActual.id_producto);
                bindprod.RemoveCurrent();
            }
        }
        private int ValidarProducto()
        {
            if (ProductoActual != null)
            {
                this.Validate();
                bindprod.EndEdit();
                if (ToolsDB.RowHasChange(ProductoActual))
                {
                    DialogResult resul = Mensaje.AlertaConfirmaSiNoCancel("Hay cambios, guardarlos?");
                    if (resul == DialogResult.Yes)
                    {
                        guardarActual(true);
                        ProductoActual.AcceptChanges();
                    }
                    else if (resul == DialogResult.No)
                    {
                        ProductoActual.CancelEdit();
                        ProductoActual.RejectChanges();
                    }
                    else
                        return 1;
                }
            }
            return 0;
        }
        private void crearProducto(bool silence)
        {
            SqlConnection con = new SqlConnection(ConfigPersonalizada.ELECTRODANConnectionString1);
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [BASE].[dbo].[PRODUCTOS] 
                                                    ([descripcion]
                                                    ,[modelo]
                                                    ,[marca]
                                                    ,[imagen]
                                                    ,id_prod_requerido
                                                    ,porc_ganancia_predef
                                                    ,porc_iva_costo
                                                    ,valor_dolar
                                                    ,precio_costo_dolar
                                                    ,precio_costo_pesos
                                                    ,es_favorito
                                                    ,mano_obra_predef)
                                             VALUES (@descripcion,@modelo,@marca,@imagen,@id_prod_req,@porc_ganancia_predef,@porc_iva_costo
                                               ,@valor_dolar,@precio_costo_dolar,@precio_costo_pesos,@es_favorito,@mano_obra);
                                             select @@identity;", con);
            Validate();
            bindprod.EndEdit();
            prodActualParametros(cmd);
            con.Open();
            SqlDataReader resul = cmd.ExecuteReader();
            resul.Read();
            if (resul.HasRows && !resul.IsDBNull(0))
            {
                ProductoActual.id_producto = Convert.ToInt32(resul[0]);
                ProductoActual.imagen = pic2db.getNula();
                ProductoActual.AcceptChanges();
                bindprod.ResetCurrentItem();
                if (!silence)
                    Mensaje.AlertaAviso("Producto creado!");
            }
            con.Close();
            if (null != con) con.Close();
        }
        void bindprod_AddingNew(object sender, AddingNewEventArgs e)
        {
            DataRowView nuevo = ((DataView)bindprod.List).AddNew();
            valoresXdefecto(nuevo.Row);
            e.NewObject = nuevo;
            bindprod.Position = bindprod.List.IndexOf(nuevo);
            pic2db.setNula();
            txtMarca.Select();
            txtMarca.Focus();
            if (!groupParametros.Visible)
                cmdAjustarParametros.PerformClick();
            cmdProdRequerido.PerformClick();
        }
        #endregion

        #region manejo prod presu
        private DatosPresupuesto.ProdxPresuRow ProdPresuActual
        {
            get
            {
                if (bindprodpresu.Current != null)
                    return (DatosPresupuesto.ProdxPresuRow)((DataRowView)bindprodpresu.Current).Row;
                else
                    return null;
            }
        }
        private void usarActual()
        {
            if (PresuActual != null)
            {
                if (ProductoActual != null)
                {
                    DatosPresupuesto.ProdxPresuRow existente = datos.ProdxPresu.FindByid_productoid_presupuesto(ProductoActual.id_producto, PresuActual.id_presupuesto);
                    if (existente == null)
                    {
                        bindprodpresu.AddNew();
                        cargarActual();
                        txtCantidad.Value = 1;
                        txtFiltro.Select();
                        txtFiltro.Focus();
                    }
                    else
                    {
                        existente.cantidad++;
                    }
                }
            }
            else
                if (Mensaje.AlertaOK("Se creara un presupuesto antes!") == System.Windows.Forms.DialogResult.OK)
                    bindpresu.AddNew();
        }
        private void cargarActual()
        {
            ProdPresuActual.id_presupuesto = PresuActual.id_presupuesto;
            ProdPresuActual.producto = ProductoActual.xproducto;
            ProdPresuActual.id_producto = ProductoActual.id_producto;
            ProdPresuActual.cantidad = Convert.ToInt32(txtCantidad.Value);
            ProdPresuActual.orden = maxProdPresu() + 1;
            ProdPresuActual.porc_iva = ProductoActual.porc_iva_costo;
            ProdPresuActual.precio_dolar = ProductoActual.precio_costo_dolar;
            ProdPresuActual.precio_pesos = ProductoActual.precio_costo_pesos;
            ProdPresuActual.porc_ganancia = ProductoActual.porc_ganancia_predef;
            if (!chkManoObra.Checked)
                ProdPresuActual.mano_obra = ProductoActual.mano_obra_predef;
            else
                ProdPresuActual.mano_obra = 0;
            bindprodpresu.EndEdit();
        }

        private int maxProdPresu()
        {
            int resul = 99;
            object tmp = datos.ProdxPresu.Compute("max(orden)", string.Format("id_presupuesto={0}", PresuActual.id_presupuesto));
            if (tmp != null && tmp != DBNull.Value)
                resul = (int)tmp;
            return resul;
        }
        #endregion

        #region eventos formulario
        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            bindprod.RemoveFilter();
            bindprod.AddNew();
        }
        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            guardarActual(false);
        }
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto();
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            refiltrar();
        }
        private void cmdUsar_Click(object sender, EventArgs e)
        {
            usarActual();
        }
        private void cmdGuardarPresu_Click(object sender, EventArgs e)
        {
            guardarPresuActual(false);
        }
        private void cmdImprimirPresu_Click(object sender, EventArgs e)
        {
            guardarPresuActual();
            imprimirPresuActual();
        }
        private void refiltrar()
        {
            int cant = 0;
            string filtro = "";
            if (txtFiltro.Text != "")
            {
                filtro += string.Format(@"(descripcion like '*{0}*' or modelo like '*{0}*' 
                         or marca like '*{0}*' or xproducto like '*{0}*' or xcategoria like '*{0}*')", txtFiltro.Text);
                cant++;
            }
            if (chkFavorito.Checked)
            {
                if (cant > 0)
                    filtro = filtro + " and ";
                filtro += "es_favorito=1";
                cant++;
            }
            if (comboMotivo.SelectedIndex > 0)
            {
                if (cant > 0)
                    filtro = filtro + " and ";
                switch (comboMotivo.SelectedIndex)
                {
                    case 1:
                        filtro += "xid_categoria=2";
                        break;
                    case 2:
                        filtro += "xid_categoria=1";
                        break;
                    case 3:
                    case 4:
                        filtro += "xid_categoria=4";
                        break;
                }
            }
            if (filtro != "")
                bindprod.Filter = filtro;
            else
                bindprod.RemoveFilter();
        }
        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                e.SuppressKeyPress = true;
                bindprod.MovePrevious();
                txtFiltro.SelectAll();
            }
            else if (e.KeyData == Keys.Down)
            {
                e.SuppressKeyPress = true;
                bindprod.MoveNext();
                txtFiltro.SelectAll();
            }
            else if (e.KeyData == Keys.Multiply)
            {
                e.SuppressKeyPress = true;
                txtCantidad.Select();
                txtCantidad.Focus();
            }
            else if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                usarActual();
                txtFiltro.Select();
                txtFiltro.Focus();
                txtFiltro.SelectAll();
            }
        }
        private void click_control(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox))
                ((TextBox)sender).SelectAll();
            else if (sender.GetType() == typeof(NumericUpDown))
                ((TextBox)((ContainerControl)sender).Controls[1]).SelectAll();
        }
        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                usarActual();
                txtFiltro.SelectAll();
            }
        }
        private void cmdAjustarParametros_Click(object sender, EventArgs e)
        {
            vistaPanel(!groupParametros.Visible);
        }

        private void chkFavorito_CheckedChanged(object sender, EventArgs e)
        {
            refiltrar();
        }
        private void groupEdicion_Leave(object sender, EventArgs e)
        {
            ValidarProducto();
        }
        private void control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                prod_modificado(sender, EventArgs.Empty);
            }
        }
        private void presu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                presu_modificado(sender, EventArgs.Empty);
            }
        }
        private void numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';
        }
        private void presu_modificado(object sender, EventArgs e)
        {
            REDLibTools.Tools.AvanzarTABControl(this, sender);
            bindpresu.EndEdit();
        }
        private void prod_modificado(object sender, EventArgs e)
        {
            REDLibTools.Tools.AvanzarTABControl(this, sender);
            bindprod.EndEdit();
        }
        #endregion

        private void gridPresuAnteriores_Enter(object sender, EventArgs e)
        {
            ValidarPresupuesto();
        }


        private void frmPresuNuevo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ValidarProducto() != 0 || ValidarPresupuesto() != 0)
                e.Cancel = true;
        }

        private void gridPresuAnteriores_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
            if (PresuActual != null && Mensaje.AlertaConfirmaSiNo("Seguro que desea eliminar presupuesto?") == DialogResult.Yes)
            {
                eliminarPresupuesto(((DataRowView)e.Row.DataBoundItem).Row);
                bindpresu.RemoveCurrent();
                datos.Presupuestos.AcceptChanges();
                datos.ProdxPresu.AcceptChanges();
            }
        }

        private void eliminarPresupuesto(DataRow dataRow)
        {
            ToolsDB.TablaConsultaRapida("delete from presupuestos where id_presupuesto=" + PresuActual.id_presupuesto, "BASE");
        }

        private void cmdGuardarPresuCopia_Click(object sender, EventArgs e)
        {
            if (PresuActual != null && Convert.ToInt32(PresuActual.id_presupuesto) == -1)
                guardarPresuActual(false);
            else if (Mensaje.AlertaOK("Esta por guardar una copia del presupuesto actual") == DialogResult.OK)
            {
                object[] copia = new object[PresuActual.ItemArray.Length];
                PresuActual.ItemArray.CopyTo(copia, 0);
                DatosPresupuesto.PresupuestosRow presuActual = datos.Presupuestos.FindByid_presupuesto(PresuActual.id_presupuesto);
                presuActual.id_presupuesto = -1;
                presuActual.cliente += "_";
                presuActual.EndEdit();
                presuActual.AcceptChanges();
                presuActual.SetAdded();
                guardarPresuActual(true);
                datos.Presupuestos.LoadDataRow(copia, true);
            }
        }

        private void cmdNuevoPresu_Click(object sender, EventArgs e)
        {
            if (ValidarPresupuesto() == 0 && ValidarProducto() == 0)
            {
                string opc = FormOpciones.Leer("Tipo de presupuesto", "CCTV,ALARMAS,ELECTRICIDAD");
                switch (opc)
                {
                    case "CCTV":
                        comboMotivo.SelectedIndex = 1;
                        break;
                    case "ALARMAS":
                        comboMotivo.SelectedIndex = 2;
                        break;
                    case "ELECTRICIDAD":
                        comboMotivo.SelectedIndex = 3;
                        break;
                    default:
                        comboMotivo.SelectedIndex = 0;
                        break;
                }
                bindpresu.AddNew();
            }
        }

        private void gridPresuAnteriores_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            //bindpresu.CancelEdit();
        }

        private void gridProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
                usarActual();
        }

        private void gridPresupuestos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
            datos.ProdxPresu.Rows.Remove(((DataRowView)e.Row.DataBoundItem).Row);

        }

        private void gridPresupuestos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bindprodpresu.EndEdit();
        }

        private void comboMotivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            refiltrar();
        }

        private void cmdProdRequerido_Click(object sender, EventArgs e)
        {
            frmListaProdRequerido prodreq = new frmListaProdRequerido(ProductoActual.id_prod_requerido);
            if (prodreq.ShowDialog(this) == DialogResult.OK)
            {
                recargarProdRequerido(Convert.ToInt32(prodreq.ValorElegido["id"]));
                ProductoActual.id_prod_requerido = Convert.ToInt32(prodreq.ValorElegido["id"]);
                ProductoActual.EndEdit();
                bindprod.EndEdit();
            }
        }

        private void lblAjuste_Click(object sender, EventArgs e)
        {
            panAjuste.Visible = true;
            numEsperado.Value = (decimal)PresuActual.total;
            lblActual.Text = (PresuActual.total - PresuActual.ajuste).ToString("N2");
            lblAjusteTotal.Text = lblAjuste.Text;
            numEsperado.Select();
            numEsperado.Focus();
        }

        private void cmdAceptarAjuste_Click(object sender, EventArgs e)
        {
            PresuActual.ajuste += (float)numEsperado.Value - PresuActual.total;
            PresuActual.EndEdit();
            panAjuste.Visible = false;
        }

        private void cmdCancelarAjuste_Click(object sender, EventArgs e)
        {
            panAjuste.Visible = false;
        }

        private void numEsperado_ValueChanged(object sender, EventArgs e)
        {
            float tmp = (float)numEsperado.Value - PresuActual.total + PresuActual.ajuste;
            lblAjusteTotal.Text = tmp.ToString("N2");
        }

        private void cmdAjuste0_Click(object sender, EventArgs e)
        {
            PresuActual.ajuste = 0;
            PresuActual.EndEdit();
        }

        private void lblCapturar_DoubleClick(object sender, EventArgs e)
        {
            gridPresupuestos.ClearSelection();
            cambiarColores();
            Tools.evFormCapturaCerrado += new EventHandler(Tools_evFormCapturaCerrado);
            Tools.CapturarControl2PDF(panelPresu);
        }

        private void cambiarColores()
        {
            panelPresu.BackColor = Color.White;
            gridPresupuestos.BackgroundColor = Color.White;
            vistaPanel(FormOpciones.Leer("CLIENTE,ADMIN") == "ADMIN");
        }

        private void vistaPanel(bool admin)
        {
            panelTotal.Visible = !admin;
            panelAdmin.Visible = admin;
            groupParametros.Visible = admin;
            colDesc_p.Visible = !admin;
            colCosto.Visible = admin;
            colCostoDolarP.Visible = admin;
            colCostoPesoP.Visible = admin;
            colPresuGanancia.Visible = admin;
            colPresuManoObra.Visible = admin;
        }

        void Tools_evFormCapturaCerrado(object sender, EventArgs e)
        {
            restaurarColores();
        }

        private void restaurarColores()
        {
            panelPresu.BackColor = Color.DarkSeaGreen;
            gridPresupuestos.BackgroundColor = Color.PeachPuff;
            panelTotal.Visible = false;
            panelAdmin.Visible = false;

        }

        private void ObtenerCostos()
        {
            if (PresuActual != null)
            {
                DataTable tmp = ToolsDB.TablaConsultaRapida("select [dbo].[getCostoActualizado](" + PresuActual.id_presupuesto + ")", "BASE");
                if (tmp != null && tmp.Rows.Count > 0)
                {
                    Single costo_actual = Convert.ToSingle(tmp.Rows[0][0]);
                    pres_dif2.Text = (PresuActual.total - costo_actual - PresuActual.xmobra).ToString("N2");
                    pres_actual.Text = costo_actual.ToString("N2");
                }
            }
            else
            {
                pres_dif2.Text = "0.00";
                pres_actual.Text = "0.00";
            }
        }

        private void colVerTotales_Click(object sender, EventArgs e)
        {
            panelAdmin.Visible = !panelAdmin.Visible;
        }

        private void gridPresupuestos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex > -1 && ProdPresuActual != null)
            {
                int pos = bindprod.Find("id_producto", ProdPresuActual.id_producto);
                if (pos > 0)
                    bindprod.Position = pos;
            }

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            filtrar();
        }

        private void dateDesde_ValueChanged(object sender, EventArgs e)
        {
            if (cargado)
                cargarPresupuestos();
        }

        private void lblTodos_DblClick(object sender, EventArgs e)
        {
            txtFiltroPresupuestos.Text = "";
            cargarPresupuestos(true);
        }

        private void txtFiltroPresupuestos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Escape)
            {
                if (e.KeyData == Keys.Escape)
                    txtFiltroPresupuestos.Text = "";
                filtrar();
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Down)
            {
                gridPresuAnteriores.ClearSelection();
                bindpresu.MoveNext();
                if (gridPresuAnteriores.CurrentRow != null)
                    gridPresuAnteriores.CurrentRow.Selected = true;
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Up)
            {
                gridPresuAnteriores.ClearSelection();
                bindpresu.MovePrevious();
                if (gridPresuAnteriores.CurrentRow != null)
                    gridPresuAnteriores.CurrentRow.Selected = true;
                e.Handled = true;
            }
        }

        private void filtrar()
        {
            cargarPresupuestos();
            txtFiltroPresupuestos.SelectAll();
        }

        private void gridPresupuestos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex > -1)
                if (e.ColumnIndex == colPresuManoObra.Index || e.ColumnIndex == colPrecio.Index)
                {
                    gridPresupuestos.ClearSelection();
                    gridPresupuestos.CurrentCell = gridPresupuestos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    gridPresupuestos.CurrentRow.Selected = true;
                    float resul = Tools.AjustarValor(ProdPresuActual.xventa);
                    ProdPresuActual.mano_obra += resul;
                    ProdPresuActual.EndEdit();
                }
        }

        private void chkCostosSegunLista_CheckedChanged(object sender, EventArgs e)
        {
            groupCostos.Visible = chkCostosSegunLista.Checked;
        }

        private void chkManoObra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkManoObra.Focused && bindprodpresu.Count > 0)
            {
                if (chkManoObra.Checked
                    && Mensaje.AlertaConfirmaSiNo("Ya ha presupuestado componentes\nDesea quitarle el costo de mano de obra?") == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow fila in gridPresupuestos.Rows)
                    {
                        DatosPresupuesto.ProdxPresuRow prod = (DatosPresupuesto.ProdxPresuRow)((DataRowView)fila.DataBoundItem).Row;
                        prod.mano_obra = 0;
                        prod.EndEdit();
                    }
                }
            }
            PresuActual.EndEdit();
        }

        private void chkCellselection_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCellselection.Checked)
                gridPresupuestos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            else
                gridPresupuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void cmdBuscarContacto_Click(object sender, EventArgs e)
        {
            ConsultasVarias contactoFiltrado = new ConsultasVarias();
            frmCargaRapidaCliente cargaRapidaClie = new frmCargaRapidaCliente(txtCliente.Text, contactoFiltrado);
            DialogResult resul = cargaRapidaClie.ShowDialog();
            if (resul == System.Windows.Forms.DialogResult.OK)
            {
                string valor = contactoFiltrado.CONTACTOS.Rows[0]["DESCRIPCION"].ToString();
                if (valor != "" && Mensaje.AlertaConfirmaSiNo("Copiar NOMBRE?\n\n" + valor + "\n") == System.Windows.Forms.DialogResult.Yes)
                    txtCliente.Text = valor;

                valor = contactoFiltrado.CONTACTOS.Rows[0]["DIRECCION"].ToString();
                if (valor != "" && Mensaje.AlertaConfirmaSiNo("Copiar DIRECCION?\n\n" + valor + "\n") == System.Windows.Forms.DialogResult.Yes)
                    txtDireccion.Text = valor;

                valor = contactoFiltrado.CONTACTOS.Rows[0]["TELEFONO"].ToString();
                if (valor != "" && Mensaje.AlertaConfirmaSiNo("Copiar TELEFONO?\n\n" + valor + "\n") == System.Windows.Forms.DialogResult.Yes)
                    txtTelefono.Text = valor;

                valor = contactoFiltrado.CONTACTOS.Rows[0]["EMAIL"].ToString();
                if (valor != "" && Mensaje.AlertaConfirmaSiNo("Copiar E-MAIL?\n\n" + valor + "\n") == System.Windows.Forms.DialogResult.Yes)
                    txtMail.Text = valor;
            }
            this.Validate();
            bindpresu.EndEdit();
        }

        private void cmdAgregarCliente_Click(object sender, EventArgs e)
        {
            if (Mensaje.AlertaOK("Recuerde solo agregar un cliente si:\n-no esta en base de datos\n-se precisa cargar una tarea") == System.Windows.Forms.DialogResult.OK)
                agregarCliente();
        }


        private void agregarCliente()
        {
            if (solicitadaPlanilla != null)
                solicitadaPlanilla(this, new planillaClienteEventArg(txtCliente.Text, txtDireccion.Text, txtTelefono.Text, txtMail.Text));
            //frmClienteNuevo cargaCliente = new frmClienteNuevo(txtDescripcion.Text, txtTelefono.Text, txtDireccion.Text, txtMail.Text);
        }

        public event solicitarPlanillaClienteHandler solicitadaPlanilla;
    }
}
