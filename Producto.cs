using System;
using System.Collections.Generic;
using System.Text;
using ManejoAdaptadores;
using System.Windows.Forms;
using System.Data;
using REDLibTools;

namespace ManejoPresupuestos
{
    public class ManagerProducto
    {
        public ManejoAdaptadores.DatosPresupuestosTableAdapters.PRODUCTOSTableAdapter adpProducto;

        private DatosPresupuestos2 dtsDatos;
        private bool creando;
        private bool buscando;
        private BindingSource _bindPrincipal;
        private BindingSource _bindBusqueda;
        private bool usarExpresiones;

        public bool habilitarExpresiones
        {
            get
            {
                return usarExpresiones;
            }
            set
            {
                usarExpresiones = value;
                cambiarEstadoExpresiones(value);

            }
        }

        public BindingSource bindPrincipal
        {
            get
            {
                if (_bindPrincipal != null)
                    return _bindPrincipal;
                else
                    Mensaje.AlertaAviso("Aun no asigno el bind principal");
                return null;
            }
            set
            {
                _bindPrincipal = value;
                _bindPrincipal.AddingNew+=new System.ComponentModel.AddingNewEventHandler(bindPrincipal_AddingNew);
            }
        }

        public BindingSource bindBusqueda
        {
            get
            {
                if (_bindBusqueda != null)
                    return _bindBusqueda;
                else
                    Mensaje.AlertaAviso("Aun no asigno el bind principal");
                return null;
            }
            set
            {
                _bindBusqueda = value;
                _bindBusqueda.PositionChanged += new EventHandler(_bindBusqueda_PositionChanged);
            }
        }

        void _bindBusqueda_PositionChanged(object sender, EventArgs e)
        {
            if (!creando)
            cargarFilaBuscada();
        }


        public ManagerProducto(DatosPresupuestos2 origen)
        {
            if (dtsDatos != null)
                dtsDatos = origen;
            else 
                dtsDatos = new DatosPresupuestos2();
            creando = false;
            buscando = false;
        }
        
        void bindPrincipal_AddingNew(object sender, System.ComponentModel.AddingNewEventArgs e)
        {
            DataRowView nuevo= ((DataView)_bindPrincipal.List).AddNew();
            DatosPresupuestos2.PRODUCTOSRow nuevoProd = (DatosPresupuestos2.PRODUCTOSRow)nuevo.Row;
            nuevoProd.id_producto=minProducto();
            e.NewObject = nuevo;
            nuevo.EndEdit();
            _bindPrincipal.Position = _bindPrincipal.IndexOf(nuevo);
            _bindBusqueda.Position = _bindBusqueda.Find("id_producto", Actual().id_producto);
        }

        internal void crearNuevo()
        {
            creando = true;
            _bindBusqueda.RemoveFilter();
            _bindPrincipal.AddNew();
        }

        internal DatosPresupuestos2.PRODUCTOSRow Actual()
        {
            if (_bindPrincipal.Current != null)
                return (DatosPresupuestos2.PRODUCTOSRow)((DataRowView)_bindPrincipal.Current).Row;
            else return null;
        }
        internal DatosPresupuestos2.PRODUCTOSRow ActualBuscado()
        {
            if (_bindBusqueda.Current != null)
                return (DatosPresupuestos2.PRODUCTOSRow)((DataRowView)_bindBusqueda.Current).Row;
            else return null;
        }
        internal void cargarFilaBuscada()
        {
            if (ActualBuscado() != null)
            {
                if (creando)
                    cancelarActual();
                _bindPrincipal.Position = _bindPrincipal.Find("id_producto", ActualBuscado().id_producto);
            }
        }

        internal void guardar()
        {
            _bindPrincipal.EndEdit();
            cambiarEstadoExpresiones(false);
            DataRow[] filasNuevas = dtsDatos.PRODUCTOS.Select("id_producto<0","id_producto desc");
            foreach (DataRow fila in filasNuevas)
            {
                ((DatosPresupuestos2.PRODUCTOSRow)fila).id_producto =Convert.ToDecimal( adpProducto.NuevoID());
                adpProducto.Update(fila);
                fila.AcceptChanges();
                //Actual().id_producto = maxProducto();
            }
            adpProducto.Update(dtsDatos.PRODUCTOS);
            ((DataTable)dtsDatos.PRODUCTOS).AcceptChanges();
            cambiarEstadoExpresiones(true);
            _bindBusqueda.RemoveFilter();
        }

        private void cambiarEstadoExpresiones(bool estado)
        {
            DatosPresupuestos2.cambiarEstadoExpresiones(((DatosPresupuestos2)bindPrincipal.DataSource),bindPrincipal.DataMember, estado);
        }


        private decimal maxProducto()
        {
            DataRow[] resul=dtsDatos.PRODUCTOS.Select("isnull(id_producto=max(id_producto),0)");
            if (resul.Length==1)
                return Convert.ToDecimal( resul[0]["id_producto"])+1;
            return -1;
        }
        private decimal minProducto()
        {
            DataRow[] resul = dtsDatos.PRODUCTOS.Select("id_producto=min(id_producto) and id_producto<0");
            if (resul.Length == 1)
                return Convert.ToDecimal(resul[0]["id_producto"])-1;
            return -1;
        }

        internal void actualizarBind()
        {
            _bindPrincipal.EndEdit();
        }

        internal void cancelarActual()
        {
            _bindPrincipal.CancelEdit();
            ((DataRowView)_bindPrincipal.Current).Row.RejectChanges();
            creando = false;
        }

        internal void buscar(string codigoBarra,string descripcion, string marca, string modelo, string nombreRapido,bool forzar)
        {
            string conector = (forzar ? " and " : " or ");
            if (creando || buscando)
            {
                int con = 0;
                string filtro = "";
                if (descripcion != "")
                {
                    filtro += "descripcion like '*" + descripcion + "*'";
                    con++;
                }
                if (codigoBarra != "-" && codigoBarra!="")
                {
                    if (con > 0)
                        filtro += conector;
                    filtro += "codigo_barra =" + codigoBarra ;
                    con++;
                }

                if (marca != "")
                {
                    if (con > 0)
                        filtro += conector;
                    filtro += "marca like '*" + marca + "*'";
                    con++;
                }
                if (modelo != "")
                {
                    if (con > 0)
                        filtro += conector;
                    filtro += "modelo like '*" + modelo + "*'";
                    con++;
                }
                if (nombreRapido != "")
                {
                    if (con > 0)
                        filtro += conector;
                    filtro += "nombre_rapido like '*" + nombreRapido + "*'";
                    con++;
                }
                if (con == 0)
                    bindBusqueda.RemoveFilter();
                else
                    bindBusqueda.Filter = filtro + " and id_producto>0";
            }
        }

        internal void cargarXID(decimal p)
        {
            _bindBusqueda.Position=_bindBusqueda.Find("id_producto", p);
            cargarFilaBuscada();
        }
    }
    
}
