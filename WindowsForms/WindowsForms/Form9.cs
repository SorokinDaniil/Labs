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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            textBox1.KeyPress += TextBox1_KeyPress;
            button1.Click += Button1_Click;
            radioButton1.Checked = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
            string str = "";
            if (radioButton1.Checked == true) {
                string[] masstr = textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i=0;i<masstr.Length;i++)
                {
                    masstr[i] = masstr[i].Remove(0, 1).Insert(0, (char.ToUpper(masstr[i][0])).ToString());
                    str += masstr[i] + " ";
                }
            }
            else
             if (radioButton2.Checked == true)
              str = textBox1.Text.ToUpper();
            MessageBox.Show(str);
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != ' ' && l != 8)
            {
                e.Handled = true;
            }
        }
    }
}
