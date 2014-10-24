using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metrics
{
    public partial class Form1 : Form
    {
        private CodeAnalyzer _codeAnalyzer;

        public Form1()
        {
            InitializeComponent();
        }


        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "D:\\",
                Filter = @"txt files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _codeAnalyzer = new CodeAnalyzer(openFileDialog.FileName);
                TextCode.Text = _codeAnalyzer.Code;
            }
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void методХолстедаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_codeAnalyzer==null)
                MessageBox.Show(@"Вы оставили поле пустым ^_^",@"Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                _codeAnalyzer.SeparateCode();
                _codeAnalyzer.Search_n1();
                TextAnalyzeCode.Text = string.Join(Environment.NewLine, _codeAnalyzer.ValueN1);
                TextAnalyzeCode.AppendText(Environment.NewLine+string.Join(Environment.NewLine, _codeAnalyzer.n1)); 
            }
        }

        private void TextCode_TextChanged(object sender, EventArgs e)
        {
            if (_codeAnalyzer == null)
                 _codeAnalyzer = new CodeAnalyzer();
            _codeAnalyzer.Code = TextCode.Text;
        }
    }
}
