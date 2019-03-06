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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            inputToolStripMenuItem.Click += InputToolStripMenuItem_Click;
            workToolStripMenuItem.Click += WorkToolStripMenuItem_Click;
        }

        private void WorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            
            form10.Show();
        }

        private void InputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            
            form9.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
