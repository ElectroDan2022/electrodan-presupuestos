using System;
using System.Collections.Generic;
using System.Text;
using ManejoAdaptadores;

namespace ManejoPresupuestos
{
    public class ManagerClientes
    {
        private ManejoAdaptadores.ElectroDataTableAdapters.PersonaTableAdapter adpPersona;
        private ManejoAdaptadores.ElectroDataTableAdapters.CLIENTESTableAdapter adpCliente;
        private ElectroData dtsDatos;

        public ManagerClientes()
        {
            dtsDatos = new ElectroData();
            adpPersona = new ManejoAdaptadores.ElectroDataTableAdapters.PersonaTableAdapter();
            adpCliente = new ManejoAdaptadores.ElectroDataTableAdapters.CLIENTESTableAdapter();

        }
    }
}
