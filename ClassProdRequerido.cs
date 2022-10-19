using System;
using System.Collections.Generic;
using System.Text;
using ManejoAdaptadores;
using System.Windows.Forms;
using System.Data;

namespace ManejoTareas
{
    class ClassProdRequerido:ClassObjeto
    {
        public ClassProdRequerido(ClassConjuntoDatos Datos, Form Padre) : base(Datos, Padre)
        {
            Constructor();
        }
        public ClassProdRequerido(Form Padre)
            : base(Padre)
        {
            Constructor();
        }

        private void Constructor()
        {
            tableActual.TableName = "producto_requerido";
            ToolsDB.AgregarColumna(tableActual, "ID", typeof(int));
            ToolsDB.AgregarColumna(tableActual, "NOMBRE", typeof(string));
            ToolsDB.AgregarColumna(tableActual, "ID_CATEGORIA", typeof(int));
            ToolsDB.AgregarColumna(tableActual, "CATEGORIA", typeof(string));
            cadena_seleccion = "SELECT * FROM view_prod_requerido";
            columnas_id = "ID";
            columnas_id_db = "ID_prod_requerido";
            columnas_actualizables_db = "nombre,id_categoria";
            columnas_actualizables = "nombre,id_categoria";
            columnas_insertables_db = "nombre,id_categoria";
            columnas_insertables = "nombre,id_categoria";
            setTipoOrigen(TipoOrigen.SQL,"BASE");
            base.endInicializacion();
        }
        protected override string _cadena_filtro(params object[] filtro)
        {
            if (filtro.Length==2)
                return string.Format("nombre like '*{0}*' or categoria like '*{0}*' or id='{1}'", filtro[0], filtro[1]);
            else
                return string.Format("nombre like '*{0}*' or categoria like '*{0}*'", filtro[0]);
        }

        protected override void nuevoRegistro(DataRow nueva)
        {
            nueva["ID"]=0;
            nueva["ID_CATEGORIA"] = -1;
            nueva["CATEGORIA"] = "<<SIN ASIGNAR>>";
            nueva["NOMBRE"] = "<PRODUCTO>";
        }

        protected override void chequearExistencia()
        {
            if (Convert.ToInt32(rowActual["id"]) == 0)
            {
                rowActual["id"] = ToolsDB.NuevoID(tipoOrigen, tableActual.TableName, "id_prod_requerido");
                operacion_requerida =  TipoOperacion.insert;
            }
        }    
    }
}
