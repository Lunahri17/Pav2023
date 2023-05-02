using System;
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
            int calculatedValue = 0;

            try
            {
                int leftHandSide = System.Int32.Parse(txtOperIzq.Text);
                int rightHandSide = System.Int32.Parse(txtOperDcha.Text);

                if (rbSuma.Checked)
                {
                    calculatedValue = AddValues(leftHandSide, rightHandSide);
                    ShowResult(calculatedValue);
                }
                else if (rbResta.Checked)
                {
                    calculatedValue = SubtractValues(leftHandSide, rightHandSide);
                    ShowResult(calculatedValue);
                }
                else if (rbMultiplicacion.Checked)
                {
                    calculatedValue = MultiplyValues(leftHandSide, rightHandSide);
                    ShowResult(calculatedValue);
                }
                else if (rbDivision.Checked)
                {
                    calculatedValue = DivideValues(leftHandSide, rightHandSide);
                    ShowResult(calculatedValue);
                }
                else if (rbResto.Checked)
                {
                    calculatedValue = RemainderValues(leftHandSide, rightHandSide);
                    ShowResult(calculatedValue);
                }
            }
            catch (Exception caught)
            {
                lblExpresion.Text = "";
                lblResultado.Text = caught.Message;
            }
        }

        private int AddValues(int leftHandSide, int rightHandSide)
        {
            lblExpresion.Text = leftHandSide.ToString() + " + " + rightHandSide.ToString();
            return leftHandSide + rightHandSide;
        }

        private int SubtractValues(int leftHandSide, int rightHandSide)
        {
            lblExpresion.Text = leftHandSide.ToString() + " - " + rightHandSide.ToString();
            return leftHandSide - rightHandSide;
        }

        private int MultiplyValues(int leftHandSide, int rightHandSide)
        {
            lblExpresion.Text = leftHandSide.ToString() + " * " + rightHandSide.ToString();
            return leftHandSide * rightHandSide;
        }

        private int DivideValues(int leftHandSide, int rightHandSide)
        {
            lblExpresion.Text = leftHandSide.ToString() + " / " + rightHandSide.ToString();
            return leftHandSide / rightHandSide;
        }

        private int RemainderValues(int leftHandSide, int rightHandSide)
        {
            lblExpresion.Text = leftHandSide.ToString() + " % " + rightHandSide.ToString();
            return leftHandSide % rightHandSide;
        }

        private void ShowResult(int answer)
        {
            lblResultado.Text = answer.ToString();
        }
    }
}
