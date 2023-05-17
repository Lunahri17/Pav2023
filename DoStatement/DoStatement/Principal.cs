using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoStatement
{
    public partial class Principal : Form 
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void ShowStepsClick(object sender, EventArgs e)
        {
            long amount = long.Parse(txtNumero.Text);
            txtPasos.Text = "";
            string current = "";

            do
            {
                long nextDigit = amount % 8;
                amount /= 8;
                long digitCode = '0' + nextDigit;
                char digit = Convert.ToChar(digitCode);
                current = digit + current;
                txtPasos.Text += current + '\n';
            } while (amount != 0);
        }
    }
}
