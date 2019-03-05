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
        List<int> list;
        public Form7()
        {
            InitializeComponent();
            textBox1.KeyPress += TextBox1_KeyPress;
            textBox1.TextChanged += TextBox1_TextChanged;
            textBox2.KeyPress += TextBox2_KeyPress;
            textBox3.KeyPress += TextBox2_KeyPress;
            textBox4.KeyPress += TextBox2_KeyPress;
            button4.Click += Button4_Click;
            button1.Click += Button1_Click;
            button3.Click += Button3_Click;
            //Laba 4
            list = new List<int>();
            textBox5.KeyPress += TextBox1_KeyPress;
            button2.Click += Button2_Click;
            //Laba 1
            double x = 3.981 * Math.Pow(10, -2);
            double y = -1.625 * Math.Pow(10, 3);
            double z = 0.512;
            double resault = Math.Pow(2, -x) * (Math.Sqrt(x + (Math.Pow(Math.Abs(y), 1 / 4)))) * (Math.Pow(Math.Pow(Math.E, x - 1 / Math.Sin(z)), 1 / 3));
            label1.Text = resault.ToString();
        }

      







        //Laba 2
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            int k;
            if (textBox1.TextLength >= 3)
            {
                k = int.Parse(textBox1.Text[textBox1.TextLength - 3].ToString());  label2.Text = k.ToString(); 
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

    

        //Laba 3
        private void Button1_Click(object sender, EventArgs e)
        {
          if (int.Parse(textBox2.Text) > 31  || int.Parse(textBox3.Text) > 31 ||  int.Parse(textBox4.Text) > 31  || (int.Parse(textBox2.Text) == int.Parse(textBox3.Text) && int.Parse(textBox3.Text) == int.Parse(textBox4.Text)))
            {
                label12.Text = "Некорректное значение";
            } 
            else
                label12.Text = Math.Min(int.Parse(textBox2.Text), Math.Min(int.Parse(textBox3.Text), int.Parse(textBox4.Text))).ToString();
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (number == 48 || !Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }
        
        //Laba 4
        private void Button2_Click(object sender, EventArgs e)
        {
            list.Add(int.Parse(textBox5.Text));
            if (list.First() != 0)
                textBox6.Text += list.Last() + ",";
            else
            {
                DialogResult result = MessageBox.Show("Первый элемент равен 0! Попробуйте снова.", "Ошибка");
                if (result == DialogResult.OK) list.Remove(0);
            }

            if (list.Contains(0))
            {
            int min = list.Max();
            for (int i =0; i < list.IndexOf(0);i++)
            {
                if (list[i] < min)
                {
                    min = list[i];
                }
            }
            textBox7.Text = min.ToString();
            }
        }

        //Laba 5
        private void Button3_Click(object sender, EventArgs e)
        {
            int resault = 0;
            Random random = new Random();
            int[] mas = new int[10];
            label13.Text = "";
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(-10, 20);
                label13.Text += mas[i].ToString() + ",";
            }
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < 0)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        resault +=Math.Abs(mas[j]);
                    }
                    break;
                }
            }
            label16.Text = resault.ToString();
        }
        //Laba 6
        private void Button4_Click(object sender, EventArgs e)
        {
            int resault = 0;
            Random random = new Random();
            int[] sum = new int[5];
            int[,] mas = new int[5,5];
            label18.Text = "";
            label21.Text = "";
            label19.Text = "";
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i,j] = random.Next(-10, 20);
                    sum[i] += mas[i, j];
                    label18.Text += mas[i,j].ToString() + "  ";
                }
                label21.Text += sum[i].ToString() + "\n";
                label18.Text += "\n";
            }
            label19.Text = sum.Min().ToString();
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    if (mas[i] < 0)
            //    {
            //        for (int j = i; j < mas.Length; j++)
            //        {
            //            resault += mas[j];
            //        }
            //        break;
            //    }
            //}
            //label16.Text = resault.ToString();
        }

     
    }
}
