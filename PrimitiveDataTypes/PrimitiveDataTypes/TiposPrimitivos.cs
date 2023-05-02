using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimitiveDataTypes
{
    public partial class TiposPrimitivos : Form
    {
        public TiposPrimitivos()
        {
            InitializeComponent();
        }

        private void TiposSelectedValueChanged(object sender, EventArgs e)
        {
            switch (lbTipos.SelectedItem.ToString())
            {
                case "int":
                    ShowIntValue();
                    break;
                case "long":
                    ShowLongValue();
                    break;
                case "float":
                    ShowFloatValue();
                    break;
                case "double":
                    ShowDoubleValue();
                    break;
                case "decimal":
                    ShowDecimalValue();
                    break;
                case "string":
                    ShowStringValue();
                    break;
                case "char":
                    ShowCharValue();
                    break;
                case "bool":
                    ShowBoolValue();
                    break;
            }
        }

        private void ShowIntValue()
        {
            int intVar;
            intVar = 42;
            txtEjemplo.Text = intVar.ToString();
        }

        private void ShowLongValue()
        {
            long longVar;
            longVar = 42L;
            txtEjemplo.Text = longVar.ToString();
        }

        private void ShowFloatValue()
        {
            float floatVar;
            floatVar = 0.42F;
            txtEjemplo.Text = floatVar.ToString();
        }

        private void ShowDoubleValue()
        {
            double doubleVar;
            doubleVar = 0.42;
            txtEjemplo.Text = doubleVar.ToString();
        }

        private void ShowDecimalValue()
        {
            decimal decimalVar;
            decimalVar = 0.42M;
            txtEjemplo.Text = decimalVar.ToString();
        }

        private void ShowStringValue()
        {
            string stringVar;
            stringVar = "forty two";
            txtEjemplo.Text = stringVar; // ToString not needed
        }

        private void ShowCharValue()
        {
            char charVar;
            charVar = 'x';
            txtEjemplo.Text = charVar.ToString();
        }

        private void ShowBoolValue()
        {
            bool boolVar;
            boolVar = false ;
            txtEjemplo.Text = boolVar.ToString();
        }

        private void SalirClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
