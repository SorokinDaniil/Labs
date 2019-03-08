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
    public partial class Form11 : Form
    {
        Room room;
        public Form11()
        {
            InitializeComponent();
            textBox1.KeyPress += TextBox1_KeyPress;
            textBox2.KeyPress += TextBox1_KeyPress;
            textBox3.KeyPress += TextBox1_KeyPress;
            textBox6.KeyPress += TextBox6_KeyPress;
            button1.Click += Button1_Click;
            room = new Room();
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox6.Text == "")
                MessageBox.Show("Некорректное значение");
            else
            {
                room.width = double.Parse(textBox1.Text);
                room.height = double.Parse(textBox2.Text);
                room.lenght = double.Parse(textBox3.Text);
                room.window = int.Parse(textBox6.Text);
                textBox4.Text = room.Volume(room.width, room.height, room.lenght).ToString();
                textBox5.Text = room.Square(room.width, room.height).ToString();
                textBox7.Text = room.window.ToString();

            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 48)
                e.Handled = true;
        }
        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 48)
                e.Handled = true;
        }

    }
}
