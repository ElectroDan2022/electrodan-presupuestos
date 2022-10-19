using System;
using System.Collections.Generic;
using System.Text;
using ManejoAdaptadores;
using System.Windows.Forms;
using System.Data;

namespace ManejoTareas
{
    class ClassCategoriaProd:ClassObjeto
    {
        public ClassCategoriaProd(ClassConjuntoDatos Datos, Form Padre) : base(Datos, Padre)
        {
            Constructor();
        }
        public ClassCategoriaProd(Form Padre)
            : base(Padre)
        {
            Constructor();
        }

        private void Constructor()
        {
            tableActual.TableName = "categoria_producto";
            ToolsDB.AgregarColumna(tableActual, "ID", typeof(int));
            ToolsDB.AgregarColumna(tableActual, "NOMBRE", typeof(string));
            cadena_seleccion = "SELECT * FROM categoria_producto";
            columnas_id = "ID";
            columnas_id_db = "nombre";
            columnas_actualizables_db = "nombre";
            columnas_actualizables = "nombre";
            columnas_insertables_db = "nombre";
            columnas_insertables = "nombre";
            setTipoOrigen(TipoOrigen.SQL,"BASE");
            base.endInicializacion();
        }
        protected override string _cadena_filtro(params object[] filtro)
        {
            if (filtro.Length==2)
                return string.Format("nombre like '*{0}*' or id={1}", filtro[0], filtro[1]);
            else
                return string.Format("nombre like '*{0}*' ", filtro[0]);
        }

        protected override void nuevoRegistro(DataRow nueva)
        {
            nueva["ID"]=0;
            nueva["NOMBRE"] = "<CATEGORIA>";
        }

        protected override void chequearExistencia()
        {
            if (Convert.ToInt32(rowActual["id"]) == 0)
            {
                rowActual["id"] = ToolsDB.NuevoID(tipoOrigen, tableActual.TableName, "id");
                operacion_requerida =  TipoOperacion.insert;
            }
        }

    }
}
