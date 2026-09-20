using System;
using System.Windows.Forms;

namespace Escenario2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbCheckedChanged(object sender, EventArgs e)
        {
            gbTipoTriangulo.Visible = false;
            lblLadoB.Visible = false;
            txtLadoC.Visible = false;
            lblLadoC.Visible = false;
            txtLadoB.Visible = false;

            if (rbCirculo.Checked)
            {
                lblValor1.Text = "Radio:";
                lblValor2.Enabled = false;
                txtValor2.Enabled = false;
                txtValor2.Text = "";
                errorProvider1.SetError(txtValor2, ""); // esto borra errores de abajito si hay claro
            }
            else if (rbRectangulo.Checked)
            {
                lblValor1.Text = "Base:";
                lblValor2.Text = "Altura:";
                lblValor2.Enabled = true;
                txtValor2.Enabled = true;
            }
            else if (rbTriangulo.Checked)
            {
                lblValor1.Text = "Base:";
                lblValor2.Text = "Altura:";
                lblValor2.Enabled = true;
                txtValor2.Enabled = true;
                gbTipoTriangulo.Visible = true;
                rbEquilatero.Checked = true; // esto es el de al lao
            }
        }

        private void rbTipoTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            txtLadoB.Visible = lblLadoB.Visible = rbIsosceles.Checked || rbEscaleno.Checked;
            lblLadoB.Text = rbEscaleno.Checked ? "Lado B:" : "Igual:";
            txtLadoC.Visible = lblLadoC.Visible = rbEscaleno.Checked;

            if (!txtLadoB.Visible)
            {
                txtLadoB.Text = "";
                errorProvider1.SetError(txtLadoB, "");
            }
            if (!txtLadoC.Visible)
            {
                txtLadoC.Text = "";
                errorProvider1.SetError(txtLadoC, "");
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar)) && !(e.KeyChar == '.') && !(e.KeyChar == '-'))
            {
                e.Handled = true;
                MessageBox.Show("No se pueden ingresar letras");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!ValidarInput())
            {
                MessageBox.Show("Corrija los campos con los iconos rojos. Puede tener mas informacion del error pasando el mouse encima");
                return;
            }

            try
            {
                double val1 = double.Parse(txtValor1.Text);
                IFigura fig;

                if (rbCirculo.Checked)
                    fig = new Circulo { Radio = val1 };
                else if (rbRectangulo.Checked)
                {
                    double val2 = double.Parse(txtValor2.Text);
                    fig = new Rectangulo { Base = val1, Altura = val2 };
                }
                else // triangluo
                {
                    double valor2 = double.Parse(txtValor2.Text);

                    if (rbEquilatero.Checked)
                        fig = new TrianguloEquilatero { Base = val1, Altura = valor2 };
                    else if (rbIsosceles.Checked)
                    {
                        double igual = double.Parse(txtLadoC.Text);
                        fig = new TrianguloIsosceles { Base = val1, Altura = valor2, LadoIgual = igual };
                    }
                    else
                    {
                        double b = double.Parse(txtLadoC.Text);
                        double c = double.Parse(txtLadoB.Text);
                        fig = new TrianguloEscaleno { Base = val1, Altura = valor2, LadoB = b, LadoC = c };
                    }
                }

                lblArea.Text = fig.CalcularArea().ToString();
                lblPerimetro.Text = fig.CalcularPerimetro().ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Los valores numericos no son validos.");
            }
        }

        private bool ValidarInput()
        {
            bool esValido = true;

            if (!double.TryParse(txtValor1.Text, out double v1) || v1 <= 0)
            {
                errorProvider1.SetError(txtValor1, "Aqui debe ir un numero mayor que cero");
                esValido = false;
            }
            else
                errorProvider1.SetError(txtValor1, "");

            if (!rbCirculo.Checked)
            {
                if (!double.TryParse(txtValor2.Text, out double v2) || v2 <= 0)
                {
                    errorProvider1.SetError(txtValor2, "Aqui debe ir un numero mayor que cero");
                    esValido = false;
                }
                else
                    errorProvider1.SetError(txtValor2, "");
            }

            if (rbTriangulo.Checked)
            {
                if ((rbIsosceles.Checked || rbEscaleno.Checked) && (!double.TryParse(txtLadoB.Text, out double ladoB) || ladoB <= 0))
                {
                    errorProvider1.SetError(txtLadoB, "Aqui debe ir un numero mayor que cero");
                    esValido = false;
                }
                else
                    errorProvider1.SetError(txtLadoB, "");

                if (rbEscaleno.Checked && (!double.TryParse(txtLadoC.Text, out double ladoC) || ladoC <= 0))
                {
                    errorProvider1.SetError(txtLadoC, "Aqui debe ir un numero mayor que cero");
                    esValido = false;
                }
                else
                    errorProvider1.SetError(txtLadoC, "");
            }

            return esValido;
        }
    }
}
