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
    public partial class Form1 : Form
    {
        
        public Form1()
        { 
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = (Math.Round(Convert.ToDouble(textBox1.Text) / 2.205,3)).ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number !=8 && number !=44)
                e.Handled = true;
        }

    }
}
