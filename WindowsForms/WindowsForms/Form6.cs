using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsForms
{
    public partial class Form6 : Form
    {
        double byn = 0;
        double usd = 0;

        double eur = 0;
        public Form6()
        {
            InitializeComponent();

            //textBox3.TextChanged += TextBox3_TextChanged;
            textBox1.KeyPress += TextBox1_KeyPress;
            textBox2.KeyPress += TextBox1_KeyPress;
            textBox3    .KeyPress += TextBox1_KeyPress;
            textBox1.Enter += TextBox1_Enter;
            textBox2.Enter += TextBox1_Enter;
            textBox3.Enter += TextBox1_Enter;
            //textBox3.TextChanged += TextBox3_TextChanged;
            button1.Click += Button1_Click;
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if ((sender as TextBox).Name == "textBox1")
            {
                textBox1.TextChanged += TextBox1_TextChanged;
                textBox2.TextChanged -= TextBox2_TextChanged;
                textBox3.TextChanged -= TextBox3_TextChanged;
            }

             if ((sender as TextBox).Name == "textBox2")
            {
                textBox1.TextChanged -= TextBox1_TextChanged;
                textBox2.TextChanged += TextBox2_TextChanged;
                textBox3.TextChanged -= TextBox3_TextChanged;
            }
            if ((sender as TextBox).Name == "textBox3")
            {
                textBox1.TextChanged -= TextBox1_TextChanged;
                textBox2.TextChanged -= TextBox2_TextChanged;
                textBox3.TextChanged += TextBox3_TextChanged;
            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text != "")
            {
                byn = Convert.ToDouble(textBox1.Text);
                usd = byn / 2.14;
                eur = byn / 2.435;
                textBox2.Text = Math.Round(usd, 2).ToString();
                textBox3.Text = Math.Round(eur, 2).ToString();
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text != "")
            {
                usd = Convert.ToDouble(textBox2.Text);
                byn = usd * 2.14;
                eur = byn / 2.435;
                textBox1.Text = Math.Round(byn, 2).ToString();
                textBox3.Text = Math.Round(eur, 2).ToString();
            }
             
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text != "")
            {
                eur = Convert.ToDouble(textBox3.Text);
                byn = eur * 2.435;
                usd = byn / 2.14;
                textBox1.Text = Math.Round(byn, 2).ToString();
                textBox2.Text = Math.Round(usd, 2).ToString();
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
                e.Handled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("save.txt"))
            {
                sw.WriteLine(textBox1.Text);
                sw.WriteLine(textBox2.Text);
                sw.WriteLine(textBox3.Text);
            }
            using (StreamReader sr = new StreamReader("save.txt"))
            {
                textBox4.Text = sr.ReadLine();
                textBox5.Text = sr.ReadLine();
                textBox6.Text = sr.ReadLine();
            }
        }

    }

}
