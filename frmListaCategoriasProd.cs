using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ManejoAdaptadores;
using REDLibTools;
using ManejoTareas;

namespace ManejoPresupuestos
{
    public partial class frmListaCategoriasProd : Form
    {
        ClassCategoriaProd categoria;
        private object id_inicial;

        public frmListaCategoriasProd(object inicial)
        {
            InitializeComponent();
            categoria = new ClassCategoriaProd(this);
            categoria.Modo = ClassProdRequerido.Comportamiento.SELECTOR;
            id_inicial = inicial;
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            Tools.IniciarEspera(this);
            grid.AutoGenerateColumns = false;
            categoria.loadDatos();
            categoria.asociarGrid(grid);
            categoria.asociarFiltro(txtFiltro);
            categoria.Ordernar("descripcion");
            if (id_inicial != null)
                categoria.posicionar("ID", id_inicial);
            Tools.TerminarEspera(this);
        }


        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            categoria.seleccionarActual();
        }

        public DataRow ValorElegido
        {
            get
            {
                return categoria.ValorElegido;
            }
        }


    }
}