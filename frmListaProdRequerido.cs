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
    public partial class frmListaProdRequerido : Form
    {
        ClassProdRequerido prodRequerido;
        private object id_inicial;

        public frmListaProdRequerido(object inicial)
        {
            InitializeComponent();
            prodRequerido = new ClassProdRequerido(this);
            prodRequerido.Modo = ClassProdRequerido.Comportamiento.SELECTOR;
            id_inicial = inicial;
            prodRequerido.asociarDetalles(groupBox1);
            prodRequerido.asociarPropiedadControl(txtID, "text", "id");
            prodRequerido.asociarPropiedadControl(txtNombre, "text", "nombre");
            prodRequerido.asociarPropiedadControl(txtCategoria, "text", "categoria");
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            Tools.IniciarEspera(this);
            grid.AutoGenerateColumns = false;
            prodRequerido.loadDatos();
            prodRequerido.asociarGrid(grid);
            prodRequerido.asociarFiltro(txtFiltro);
            prodRequerido.Ordernar("descripcion");
            if (id_inicial != null)
                prodRequerido.posicionar("ID", id_inicial);
            Tools.TerminarEspera(this);
        }


        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            prodRequerido.seleccionarActual();
        }

        public DataRow ValorElegido
        {
            get
            {
                return prodRequerido.ValorElegido;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            prodRequerido.Nuevo();
            txtNombre.Select();
            txtNombre.Focus();
        }

        private void cmdElegirCategoria_Click(object sender, EventArgs e)
        {
            frmListaCategoriasProd categ = new frmListaCategoriasProd(prodRequerido.ValorActual("id_categoria"));
            if (categ.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                prodRequerido.editActual("id_categoria", categ.ValorElegido["id"]);
                prodRequerido.editActual("categoria",categ.ValorElegido["nombre"]);
            }
            cmdGuardar.Select();
            cmdGuardar.Focus();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (prodRequerido.GuardarCambios() != 0)
                Mensaje.AlertaAviso("Revisar los datos no se pudo guardar");
            else 
                groupBox1.Visible = false;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            prodRequerido.cancelCambios();
            groupBox1.Visible = false;
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.Handled = true;
                Tools.AvanzarTABControl(this, sender);
            }
        }

    }
}