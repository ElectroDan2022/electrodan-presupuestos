using System;
using System.Collections.Generic;
using System.Text;
using REDLibTools;
using System.Data;

namespace ManejoPresupuestos
{
    public class TablaPrecios
    {
        private List<ColumnaTablaPrecios> columnas;
        private CapturaClipboard captura;
        private DataTable tabla;
    
        public TablaPrecios()
        {
            tabla = new DataTable();
            columnas = new List<ColumnaTablaPrecios>();
        }
    
        public int cantColumnasConfiguradas
        {
            get
            {
                return columnas.Count;
            }
        }

        public DataTable TablaDatos
        {
            get
            {
                return tabla;
            }
        }

        public void crearColumna(string NombreColumna, string TipoFormato)
        {
            columnas.Add(new ColumnaTablaPrecios(NombreColumna, "", false, TipoFormato));
            tabla.Columns.Add(NombreColumna,Type.GetType(TipoFormato));
        }

        public void borrarColumna(int Indice)
        {
            columnas.RemoveAt(Indice);
            tabla.Columns.RemoveAt(Indice);
        }

        public void limpiarTabla()
        {
            columnas.Clear();
            tabla.Columns.Clear();
        }

        public void iniciarCaptura()
        {
            if (columnas.Count > 0)
            {
                if (captura!=null)
                    captura.limpiarDatos();
                captura = new CapturaClipboard();
            }
            else
                Mensaje.AlertaAviso("No se pueden tomar los datos del portapapeles\nsin antes declarar columnas para los datos");
        }

        public void interpretarFila(int Indice)
        {
            FilaCapturada fila = captura.getFila(Indice);
            int i=0;
            DataRow nuevaFila=tabla.NewRow();
            foreach (ColumnaTablaPrecios columna in columnas)
            {
                string valor = fila.getDatoColumna(i);
                if (valor != null && valor!="" )
                    try
                    {
                        nuevaFila[i] = columna.getDatoProcesado(valor);
                    }
                    catch
                    {
                        nuevaFila[i] = DBNull.Value;
                    }
                else
                    nuevaFila[i] =DBNull.Value;
                i++;
            }
            tabla.Rows.Add(nuevaFila);
        }


        public void cargarTabla()
        {
            for (int i = 0; i < captura.cantFilasCapturadas; i++)
            {
                interpretarFila(i);
            }
            captura.limpiarDatos();
        }

        public void limpiarDatos()
        {
            tabla.Clear();
            captura.limpiarDatos();
        }
    }

    public class ColumnaTablaPrecios
    {
        private string tipoFormato;
        private string adorno;
        private bool usarComoPrefijo;
        private string nombreColumna;

        public ColumnaTablaPrecios(string NombreColumna,string Adorno, bool UsarComoPrefijo, string TipoFormato)
        {
            adorno = Adorno;
            usarComoPrefijo = UsarComoPrefijo;
            tipoFormato = TipoFormato;
            nombreColumna = NombreColumna;
        }

        public object getDatoProcesado(string Dato)
        {
            //if (adorno != "")
            //{
            //    int posAdorno = Dato.IndexOf(adorno, StringComparison.InvariantCultureIgnoreCase);
            //    if (posAdorno > -1)
            //    {
            //        if (usarComoPrefijo)
            //            return Convert.ChangeType(Dato.Substring(posAdorno + adorno.Length, Dato.Length - adorno.Length).Trim(),Type.GetType(tipoFormato));
            //        else
            //            return Convert.ChangeType(Dato.Substring(0, posAdorno).Trim(), Type.GetType(tipoFormato));
            //    }
            //    else
            //        return Convert.ChangeType(Dato.Trim(), Type.GetType(tipoFormato));
            //}
            //else
            if (Dato != "")
            {
                if (tipoFormato == "System.Decimal" || tipoFormato == "System.Int32")
                {
                    Dato = StringTools.SoloNumeros(Dato);
                    if (Dato!="")
                        try
                        {
                            return Convert.ChangeType(Dato.Trim(), Type.GetType(tipoFormato));
                        }
                        catch { return null; }
                }
                else return Dato.Trim();
            }
            return null;
            // faltaria que al devolver el valor no fuera un string sino el tipo indicado antes.
        }
    }

    public class CapturaClipboard
    {
        private List<FilaCapturada> filasCapturadas;

        private string separadorLineas="\r\n";
        private string separadorColumnas = "\t";

        public CapturaClipboard(string SeparadorLineas, string SeparadorColumnas)
        {
            filasCapturadas = new List<FilaCapturada>();
            separadorColumnas = SeparadorColumnas;
            separadorLineas = SeparadorLineas;
            capturarDatos();
        }

        private void capturarDatos()
        {
            string[] lineas = System.Windows.Forms.Clipboard.GetText().Replace(separadorLineas,"\r").Split('\r');
            foreach (string linea in lineas)
            {
                if (linea != "")
                    filasCapturadas.Add(new FilaCapturada(linea,separadorColumnas));
            }
        }

        public CapturaClipboard()
        {
            filasCapturadas = new List<FilaCapturada>();
            capturarDatos();
        }

        private FilaCapturada devolverFila(int Indice)
        {
            if (Indice < filasCapturadas.Count)
                return filasCapturadas[Indice];
            else return null;
        }


        internal FilaCapturada getFila(int Indice)
        {
            return filasCapturadas[Indice];
        }

        public int cantFilasCapturadas
        {
            get
            {
                return filasCapturadas.Count;
            }
        }

        internal void limpiarDatos()
        {
            filasCapturadas.Clear();
        }
    }
    public class FilaCapturada
    {
        private string separadorColumnas;
        private string linea;

        public FilaCapturada(string Linea, string SeparadorColumna)
        {
            separadorColumnas = SeparadorColumna;
            linea = Linea;
        }

        public string getDatoColumna(int idColumna)
        {
            string[] columnas = linea.Split(separadorColumnas.ToCharArray());
            if (idColumna < columnas.Length)
                return columnas[idColumna];
            else return null;
        }
    }

}
