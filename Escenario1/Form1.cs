using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escenario1
{
    public partial class Form1 : Form
    {
        private readonly List<ITrabajador> listaTrabajadores = new List<ITrabajador>();

        public Form1()
        {
            InitializeComponent();
        }

        private void rbComision_CheckedChanged(object sender, EventArgs e)
        {
            txtComision.Enabled = rbComision.Checked;
            lblComision.Enabled = rbComision.Checked;
            if (!rbComision.Checked) txtComision.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarInput())
            {
                MessageBox.Show("Corrija los campos señalados. Puedes pasa el mouse sobre el error para saber mas al respecto");
                return;
            }

            try
            {
                decimal salarioBase = decimal.Parse(txtSueldoBase.Text);
                ITrabajador nuevoTraba;

                if (rbFijo.Checked)
                    nuevoTraba = new TrabajadorFijo
                    {
                        Nombre = txtNombre.Text.Trim(),
                        SalarioBase = salarioBase
                    };
                else
                {
                    decimal comision = decimal.Parse(txtComision.Text);
                    nuevoTraba = new TrabajadorXComision
                    {
                        Nombre = txtNombre.Text.Trim(),
                        SalarioBase = salarioBase,
                        Comision = comision
                    };
                }

                listaTrabajadores.Add(nuevoTraba);
                ActualziarGrid();
                LimpiarFormulario();
            }
            catch (FormatException)
            {
                MessageBox.Show("En las casillas Salario/Comision solo se aceptan numeros");
            }
        }

        private bool ValidarInput()
        {
            bool esValido = true;

            // nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre esta vacio");
                esValido = false;
            }
            else
                errorProvider1.SetError(txtNombre, "");

            // salario
            if (!decimal.TryParse(txtSueldoBase.Text, out decimal sueldo) || sueldo <= 0)
            {
                errorProvider1.SetError(txtSueldoBase, "El campo sueldo debe estar lleno y ser mayor que cero");
                esValido = false;
            }
            else
                errorProvider1.SetError(txtSueldoBase, "");


            // comision
            if (rbComision.Checked)
            {
                if (!decimal.TryParse(txtComision.Text, out decimal comision) || comision <= 0)
                {
                    errorProvider1.SetError(txtComision, "El campo comision debe estar lleno y ser mayor que cero");
                    esValido = false;
                }
                else
                    errorProvider1.SetError(txtComision, "");
            }

            return esValido;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                MessageBox.Show("No se aceptan numeros en el campo del nombre");
            }
        }

        private void ActualziarGrid()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("SalarioBase");
            tabla.Columns.Add("Comision");
            tabla.Columns.Add("SueldoFinal");
            tabla.Columns.Add("Tipo");

            foreach (ITrabajador traba in listaTrabajadores)
            {
                string comision;

                if (traba is TrabajadorXComision trabajadorComision)
                    comision = trabajadorComision.Comision.ToString();
                else
                    comision = "-";

                tabla.Rows.Add(traba.Nombre, traba.SalarioBase, comision, traba.CalcularSalarioFinal(), traba.GetType().Name);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tabla;
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtSueldoBase.Clear();
            txtComision.Clear();
            rbFijo.Checked = true;
            txtNombre.Focus();
        }
    }
}
