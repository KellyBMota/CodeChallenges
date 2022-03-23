using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextJustification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void justify_click(object sender, EventArgs e)
        {
            var text = textBox1.Text.Split(' ');
            var justified_text_list = JustifyText.Justify(text, (int)numericUpDown1.Value);
            var justified_text_string = string.Join(Environment.NewLine, justified_text_list);
            textBox2.Text = justified_text_string;
        }
    }
}
