using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form7 : Form
    {
        double x = 3.981 * Math.Pow(10, -2);
        double y = -1.625 * Math.Pow(10, 3);
        double z = 0.512;
        //double a = 1.26185;
        public Form7()
        {
            InitializeComponent();
            textBox1.KeyPress += TextBox1_KeyPress;
            textBox1.TextChanged += TextBox1_TextChanged;
            double resault = Math.Pow(2, -x) * (Math.Sqrt(x + (Math.Pow(Math.Abs(y), 1 / 4)))) * (Math.Pow(Math.Pow(Math.E, x - 1 / Math.Sin(z)), 1 / 3));
            label1.Text = resault.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int k;
            if (textBox1.TextLength >= 3)
            {
                k = textBox1.Text[textBox1.TextLength - 3];  label2.Text = k.ToString(); 
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }
    }
}
