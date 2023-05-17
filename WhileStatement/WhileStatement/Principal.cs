using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileStatement
{
    public partial class Principal : Form
    {
        private OpenFileDialog _openFileDialog = null;

        public Principal()
        {
            InitializeComponent();
            _openFileDialog = new OpenFileDialog();
            _openFileDialog.FileOk += OpenFileDialogFileOk;
        }

        private void OpenFileClick(object sender, EventArgs e)
        {
            _openFileDialog.ShowDialog();
        }

        private void OpenFileDialogFileOk(object sender, CancelEventArgs e)
        {
            string fullPathname = _openFileDialog.FileName;
            FileInfo src = new FileInfo(fullPathname);
            txtNombreArchivo.Text = src.FullName;
            TextReader reader = src.OpenText();
            DisplayData(reader);
        }

        private void DisplayData(TextReader reader)
        {
            txtOrigen.Text = "";
            string line = reader.ReadLine();

            while (line != null)
            {
                txtOrigen.Text += line + '\n';
                line = reader.ReadLine();
            }

            reader.Close();
        }

    }
}
