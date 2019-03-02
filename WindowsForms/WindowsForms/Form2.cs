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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            radioButton1.CheckedChanged += TextBox1_TextChanged;
            radioButton2.CheckedChanged += TextBox1_TextChanged;
            radioButton3.CheckedChanged += TextBox1_TextChanged;
            radioButton4.CheckedChanged += TextBox1_TextChanged;
            radioButton5.CheckedChanged += TextBox1_TextChanged;
            textBox1.TextChanged += TextBox1_TextChanged;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            double resault;
            try
            {
                if (radioButton1.Checked)
                    label9.Text = textBox1.Text;
                if (radioButton2.Checked)
                {
                    label9.Text =
                (resault = Convert.ToDouble(textBox1.Text) + (Convert.ToDouble(textBox1.Text) / 100) * 5).ToString();
                }
                if (radioButton3.Checked)
                {
                    label9.Text =
                (resault = Convert.ToDouble(textBox1.Text) + (Convert.ToDouble(textBox1.Text) / 100) * 10).ToString();
                }
                if (radioButton4.Checked)
                {
                    label9.Text =
                (resault = Convert.ToDouble(textBox1.Text) + (Convert.ToDouble(textBox1.Text) / 100) * 15).ToString();
                }
                if (radioButton5.Checked)
                {
                    label9.Text =
                (resault = Convert.ToDouble(textBox1.Text) + (Convert.ToDouble(textBox1.Text) / 100) * 20).ToString();
                }
            }
            catch(FormatException)
            {
                label9.Text = "0";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label9.Text != "0")
            MessageBox.Show("Покупка успешна совершена ! Итого : " + label9.Text, "Интернет-магазин ООО\"Мебельный властелин\"", MessageBoxButtons.OK);
            else
                MessageBox.Show("Вы ничего не купили :( Попробуйте снова", "Интернет-магазин ООО\"Мебельный властелин\"", MessageBoxButtons.OK);
        }

    }
}
