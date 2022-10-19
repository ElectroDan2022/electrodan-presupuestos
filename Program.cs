using System;
using System.Collections.Generic;
using System.Windows.Forms;
using REDLibTools;
using System.Runtime.InteropServices;
using System.Diagnostics;
using ManejoAdaptadores;
using ManejoTareas;

namespace ManejoPresupuestos
{
    static class Program
    {
        
        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigPersonalizada.CargarConfig();
            ToolsDB.guardar_error = false;
        
            if (args.Length > 0)
            {
                CambiarConexion(REDLibTools.Tools.ExisteArg(args, "/i"));
                if (REDLibTools.Tools.ExisteArg(args, "/d"))
                    Application.Run(new frmPresuNuevo(true));
                else
                    Application.Run(new frmPresuNuevo());
                
            }
            else
            {
                CambiarConexion(false);
                Application.Run(new frmPresuNuevo());
            }
        
            
        }

        internal static void CambiarConexion(bool UsarInternet)
        {
            string Servidor = ConfigPersonalizada.FileINI.IniReadValue("SERVER", (UsarInternet ? "INTERNET" : "LOCAL"));
            string serverFull = Servidor + ',' + ConfigPersonalizada.FileINI.IniReadValue("SERVER", "PUERTO") 
                + (UsarInternet ? ";Network Library=DBMSSOCN" : "");
            ConfigPersonalizada.FileINI.IniWriteValue("Datos", "ServidorSQLDefault", "Data Source=" + serverFull + ";Initial Catalog=ELECTRODAN;Persist Security Info=True;User ID=emma;Password=1234");
            string pathFBI = ConfigPersonalizada.FileINI.IniReadValue("PATH", "FBI");
            string pathIGP = ConfigPersonalizada.FileINI.IniReadValue("PATH", "IGP");
            string pathOtras = ConfigPersonalizada.FileINI.IniReadValue("PATH", "OTRAS");
            global::ManejoAdaptadores.ConfigPersonalizada.Cargar(pathFBI, pathIGP, pathOtras, serverFull);
        }
    }
}