using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnightProbability
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void result_buttonClick(object sender, EventArgs e)
        {
            result_textBox.Text = "";
            var n = int.Parse(n_textBox.Text);
            var k = int.Parse(k_textBox.Text);
            var row = int.Parse(row_textBox.Text);
            var column = int.Parse(column_textBox.Text);
            result_textBox.Text = KnightProbability.GetProbability(n, k, row, column).ToString();
        }

        private void n_textBox_ValueChanged(object sender, EventArgs e)
        {
            result_textBox.Text = "";
        }

        private void k_textBox_ValueChanged(object sender, EventArgs e)
        {
            result_textBox.Text = "";
        }

        private void row_textBox_ValueChanged(object sender, EventArgs e)
        {
            result_textBox.Text = "";
        }

        private void column_textBox_ValueChanged(object sender, EventArgs e)
        {
            result_textBox.Text = "";
        }
    }
}
