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
    public partial class Form4 : Form
    {
        int m = 0;
        int s = 0;
        public Form4()
        {
            
            InitializeComponent();
  
            button1.Click += Button1_Click;
            textBox1.KeyPress += TextBox2_KeyPress;
            textBox2.KeyPress += TextBox2_KeyPress;
          
  
           
        }


        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!timer1.Enabled)
            {
                char number = e.KeyChar;
                if (!Char.IsDigit(number) && number != 8)
                    e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
                if (timer1.Enabled)
                {
                    textBox1.ReadOnly = false;
                    textBox2.ReadOnly = false;
                    textBox1.Text = "00";
                    textBox2.Text = "00";
                    button1.Text = "Start";
                    timer1.Stop();
                }
                else
            try
            {
                if (!timer1.Enabled)
                {
                    if (Convert.ToInt32(textBox1.Text) > 59 || Convert.ToInt32(textBox2.Text) > 59 || (textBox1.Text == "00" && textBox2.Text == "00")) throw new ArgumentException();
                    m = int.Parse(textBox1.Text);
                    s = int.Parse(textBox2.Text);
                        textBox1.ReadOnly = true;
                        textBox2.ReadOnly = true;
                        button1.Text = "Stop";
                    timer1.Start();
                }
             
            }
            catch(ArgumentException)
            {
                MessageBox.Show("Некорректное значение!", "Ошибка");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (s == 0 && m == 0) { MessageBox.Show("ВРЕМЯ ВЫШЛО", "Таймер"); timer1.Stop(); }
            if (s == 0)
            {
                s = 59;
                textBox2.Text = s.ToString();
                if (m != 0)
                    textBox1.Text = (--m).ToString();
            }
            if (m <= 9) textBox1.Text = $"0{m}";
            if (s <= 9)
            {
                textBox2.Text = s--.ToString();
                textBox2.Text = $"0{s}";
            }
            else
                textBox2.Text = s--.ToString();





        }

    }
}
