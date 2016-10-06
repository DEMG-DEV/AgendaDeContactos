using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaDeContactos
{
    public partial class Form1 : Form
    {
        int idSeleccion;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //if (this.dataGridView1.SelectedRows.Count > 0)
            //{
            //    clDetalleContacto detalleContacto = new clDetalleContacto();

            //    detalleContacto.vaciarRegistro(((DataRowView)this.dataGridView1.SelectedRows[0].DataBoundItem).Row);

            //    this.dsDetalleContactoBindingSource.Clear();
            //    this.dsDetalleContactoBindingSource.Add(detalleContacto);
            //    DataGridViewRow row = dataGridView1.CurrentRow;

            //    btnAñadir.Enabled = false;
            //    btnEditar.Enabled = false;
            //    btnEliminar.Enabled = false;

            //    btnGuardar.Visible = true;
            //    btnCancelar.Visible = true;
            //}
        }
    }
}
