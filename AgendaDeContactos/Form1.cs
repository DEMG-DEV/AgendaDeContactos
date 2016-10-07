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
        int btn;

        public Form1()
        {
            InitializeComponent();
            button5.Enabled = false;
            button4.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsDetalleContacto.contacto' table. You can move, or remove it, as needed.
            this.contactoTableAdapter.Fill(this.dsDetalleContacto.contacto);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                clDetalleContacto detalleContacto = new clDetalleContacto();


                detalleContacto.vaciarRegistro(((DataRowView)this.dataGridView1.SelectedRows[0].DataBoundItem).Row);
                

                this.contactoBindingSource.Clear();
                this.contactoBindingSource.Add(detalleContacto);
                DataGridViewRow row = dataGridView1.CurrentRow;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn = 1;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;

            cbTratamiento.Enabled = true;
            txtNombre.ReadOnly = false;
            txtApePaterno.ReadOnly = false;
            txtApeMaterno.ReadOnly = false;
            txtOrganizacion.ReadOnly = false;
            txtPuesto.ReadOnly = false;

            txtNombre.Text = "";
            txtApePaterno.Text = "";
            txtApeMaterno.Text = "";
            txtOrganizacion.Text = "";
            txtPuesto.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn = 2;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn = 3;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;

            cbTratamiento.Enabled = true;
            txtNombre.ReadOnly = false;
            txtApePaterno.ReadOnly = false;
            txtApeMaterno.ReadOnly = false;
            txtOrganizacion.ReadOnly = false;
            txtPuesto.ReadOnly = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                switch (btn)
                {
                    case 1:
                        try
                        {
                            clDetalleContacto detalleContacto = new clDetalleContacto();
                            detalleContacto.TratamientoContacto = cbTratamiento.SelectedItem.ToString();
                            detalleContacto.NombreContacto = txtNombre.Text.ToString();
                            detalleContacto.ApePaternoContacto = txtApePaterno.Text.ToString();
                            detalleContacto.ApeMaternoContacto = txtApeMaterno.Text.ToString();
                            detalleContacto.OrganizacionContacto = txtOrganizacion.Text.ToString();
                            detalleContacto.PuestoContacto = txtPuesto.Text.ToString();

                            detalleContacto.insertarRegistro();
                            this.contactoTableAdapter.Fill(this.dsDetalleContacto.contacto);

                            button1.Enabled = true;
                            button2.Enabled = true;
                            button3.Enabled = true;
                            button4.Enabled = false;
                            button5.Enabled = false;

                            cbTratamiento.Enabled = false;
                            txtNombre.ReadOnly = true;
                            txtApePaterno.ReadOnly = true;
                            txtApeMaterno.ReadOnly = true;
                            txtOrganizacion.ReadOnly = true;
                            txtPuesto.ReadOnly = true;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error Mensaje: " + ex.Message);
                        }
                        break;
                    case 2:
                        try
                        {
                            DataGridViewRow row = dataGridView1.CurrentRow;
                            long id = Convert.ToInt64(row.Cells[0].Value.ToString());
                            clDetalleContacto detalleContacto = new clDetalleContacto();
                            detalleContacto.IdContacto = id;

                            detalleContacto.borrarRegistro();
                            this.contactoTableAdapter.Fill(this.dsDetalleContacto.contacto);

                            button1.Enabled = true;
                            button2.Enabled = true;
                            button3.Enabled = true;
                            button4.Enabled = false;
                            button5.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error Mensaje: " + ex.Message);
                        }
                        break;
                    case 3:
                        try
                        {
                            DataGridViewRow row = dataGridView1.CurrentRow;
                            long id = Convert.ToInt64(row.Cells[0].Value.ToString());

                            clDetalleContacto detalleContacto = new clDetalleContacto();
                            detalleContacto.IdContacto = id;
                            detalleContacto.TratamientoContacto = cbTratamiento.SelectedItem.ToString();
                            detalleContacto.NombreContacto = txtNombre.Text.ToString();
                            detalleContacto.ApePaternoContacto = txtApePaterno.Text.ToString();
                            detalleContacto.ApeMaternoContacto = txtApeMaterno.Text.ToString();
                            detalleContacto.OrganizacionContacto = txtOrganizacion.Text.ToString();
                            detalleContacto.PuestoContacto = txtPuesto.Text.ToString();

                            detalleContacto.editarRegistro();
                            this.contactoTableAdapter.Fill(this.dsDetalleContacto.contacto);

                            button1.Enabled = true;
                            button2.Enabled = true;
                            button3.Enabled = true;
                            button4.Enabled = false;
                            button5.Enabled = false;

                            cbTratamiento.Enabled = false;
                            txtNombre.ReadOnly = true;
                            txtApePaterno.ReadOnly = true;
                            txtApeMaterno.ReadOnly = true;
                            txtOrganizacion.ReadOnly = true;
                            txtPuesto.ReadOnly = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                        break;
                }
            }
            catch (Exception ex) { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;

            cbTratamiento.Enabled = false;
            txtNombre.ReadOnly = true;
            txtApePaterno.ReadOnly = true;
            txtApeMaterno.ReadOnly = true;
            txtOrganizacion.ReadOnly = true;
            txtPuesto.ReadOnly = true;
        }
    }
}
