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
    public partial class Form3 : Form
    {
        int count = -1;
        List<PictureBox> pictureBoxes;
        public Form3()
        {
            InitializeComponent();
            pictureBoxes = new List<PictureBox>();
            pictureBoxes.Add(pictureBox1);
            pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3);
            pictureBoxes.Add(pictureBox4);
      
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (count != pictureBoxes.Count - 1)
            {
                pictureBoxes[++count].Visible = true;
                pictureBoxes[count - 1].Visible = false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count -1  >=0)
            {
                pictureBoxes[--count].Visible = true;
                pictureBoxes[count + 1].Visible = false;
            }
              
        }

        private void Form3_Click(object sender, EventArgs e)
        {
            if (count == -1)
            {
                count = 0;
                button1.Visible = true;
                button2.Visible = true;
                pictureBoxes[0].Visible = true;
            }
        }

      
    }
}
