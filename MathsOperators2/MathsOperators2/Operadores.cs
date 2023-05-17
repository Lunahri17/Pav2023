using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsOperators
{
    public partial class Operadores : Form
    {
        public Operadores()
        {
            InitializeComponent();
        }

        private void SalirClick(object sender, EventArgs e)
        {
            Close();
        }

        private void CalcularClick(object sender, EventArgs e)
        {
            try
            {
                if (rbSuma.Checked)
                {
                    AddValues();
                }
                else if (rbResta.Checked)
                {
                    SubtractValues();
                }
                else if (rbMultiplicacion.Checked)
                {
                    MultiplyValues();
                }
                else if (rbDivision.Checked)
                {
                    DivideValues();
                }
                else if (rbResto.Checked)
                {
                    RemainderValues();
                }
                else
                {
                    throw new InvalidOperationException("No seleccionó un operador");
                }
            }
            catch (FormatException fEx)
            {
                lblResultado.Text = fEx.Message;
            }
            catch (OverflowException oEx)
            {
                lblResultado.Text += oEx.Message;
            }
            catch (InvalidOperationException ioEx)
            {
                lblResultado.Text = ioEx.Message;
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
        }

        private void AddValues()
        {
            int lhs = int.Parse(txtOperIzq.Text);
            int rhs = int.Parse(txtOperDcha.Text);
            int outcome = 0;

            outcome = lhs + rhs;
            lblExpresion.Text = $"{txtOperIzq.Text} + {txtOperDcha.Text}";
            lblResultado.Text = outcome.ToString();
        }

        private void SubtractValues()
        {
            int valor = 0;
            int lhs = int.Parse(txtOperIzq.Text);
            int rhs = int.Parse(txtOperDcha.Text);
            int outcome = 0;

            outcome = lhs - rhs;
            lblExpresion.Text = $"{txtOperIzq.Text} - {txtOperDcha.Text}";
            lblResultado.Text = outcome.ToString();
        }

        private void MultiplyValues()
        {
            int lhs = int.Parse(txtOperIzq.Text);
            int rhs = int.Parse(txtOperDcha.Text);
            int outcome = 0;

            outcome = lhs * rhs;
            lblExpresion.Text = $"{txtOperIzq.Text} * {txtOperDcha.Text}";
            lblResultado.Text = outcome.ToString();
        }

        private void DivideValues()
        {
            int lhs = int.Parse(txtOperIzq.Text);
            int rhs = int.Parse(txtOperDcha.Text);
            int outcome = 0;

            outcome = lhs / rhs;
            lblExpresion.Text = $"{txtOperIzq.Text} / {txtOperDcha.Text}";
            lblResultado.Text = outcome.ToString();
        }

        private void RemainderValues()
        {
            int lhs = int.Parse(txtOperIzq.Text);
            int rhs = int.Parse(txtOperDcha.Text);
            int outcome = 0;

            outcome = lhs % rhs;
            lblExpresion.Text = $"{txtOperIzq.Text} % {txtOperDcha.Text}";
            lblResultado.Text = outcome.ToString();
        }
    }
}
