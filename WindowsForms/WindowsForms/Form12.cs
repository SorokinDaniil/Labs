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
    public partial class Form12 : Form
    {
        AutoCompleteStringCollection namechange = new AutoCompleteStringCollection();
        AutoCompleteStringCollection datechange = new AutoCompleteStringCollection();
        AutoCompleteStringCollection pathchange = new AutoCompleteStringCollection();
        Label[] labels = new Label[10];
        int index;
        public Form12()
        {
            InitializeComponent();
            numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;
            openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            currentLabelToolStripMenuItem.Click += CurrentLabelToolStripMenuItem_Click;
            allLabelsToolStripMenuItem.Click += AllLabelsToolStripMenuItem_Click;
            editbutton.Click += Editbutton_Click;
            searchbutton.Click += Searchbutton_Click;
            for (int i = 0; i < labels.Length; i++)
                labels[i] = new Label();
            openFileDialog1.Filter = "Ярлык(*.lnk)|*.lnk";
            numericUpDown1.Maximum = labels.Length;
            namecombo.KeyPress += Namecombo_KeyPress;
            datecombo.KeyPress += Datecombo_KeyPress;
            pathcombo.KeyPress += Pathcombo_KeyPress;
        }

        private void Namecombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            datecombo.Text = "";
            pathcombo.Text = "";
        }

        private void Pathcombo_KeyPress(object sender, EventArgs e)
        {
            namecombo.Text = "";
            datecombo.Text = "";
        }

        private void Datecombo_KeyPress(object sender, EventArgs e)
        {
            namecombo.Text = "";
            pathcombo.Text = "";
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath;
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            filepath = openFileDialog1.FileName;
            name.Text = Path.GetFileNameWithoutExtension(filepath);
            date.Text = File.GetCreationTime(filepath).ToShortDateString();
            path.Text = filepath;
        }

        private void CurrentLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!IsArrayItemClear(index))
            {
                dataGridView1.RowCount = 2;
                ShowArrayItem(0, index);
            }
            else
                MessageBox.Show("Это элемент массива пуст");
        }

        private void AllLabelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = 1;
            int countrows = 0;
            bool IsCheckAllItemsClear = true;
            for (int i = 0; i < labels.Length; i++)
                ShowAllArray("1", "", ref countrows, ref IsCheckAllItemsClear, i);
            if (IsCheckAllItemsClear)
              MessageBox.Show("Массив пуст");
            
        }

        private void ShowAllArray (string valuearray , string valuecombobox,ref int countrows,ref bool IsCheckAllItemsClear,int i)
        {
            if (!IsArrayItemClear(i) || valuearray == valuecombobox)
            {
                dataGridView1.RowCount++;
                IsCheckAllItemsClear = false;
                ShowArrayItem(countrows, i);
                countrows++;
            }
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            //string searchdata;

            //if (namecombo.Text != "")
            //    searchdata = namecombo.Text;
            //if (datecombo.Text != "")
            //    searchdata = datecombo.Text;
            //if (pathcombo.Text != "")
            //    searchdata = pathcombo.Text;
            //for (int i = 0; i < labels.Length; i++)
            //{
            //    if (labels[i].LabelName == namecombo.Text)

            //}



        }

        private void Editbutton_Click(object sender, EventArgs e)
        {

            labels[index].LabelName = name.Text;
            labels[index].DataCreate = Convert.ToDateTime(date.Text);
            labels[index].FilePath = path.Text;
            MessageBox.Show("Элемент успешно добавлен(отредактирован)");
            UpdateComboBoxItems();
        }

        private void UpdateComboBoxItems()
        {
            namechange.Clear();
            datechange.Clear();
            pathchange.Clear();
            for (int i=0;i<labels.Length;i++)
            {
                if(!IsArrayItemClear(i))
                {
                    namechange.Add(labels[i].LabelName);
                    datechange.Add(labels[i].DataCreate.ToShortDateString());
                    pathchange.Add(labels[i].FilePath);
                }
            }
            namecombo.AutoCompleteCustomSource = namechange;
            datecombo.AutoCompleteCustomSource = datechange;
            pathcombo.AutoCompleteCustomSource = pathchange;
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            index = (int)numericUpDown1.Value - 1;
        }

        private void ShowArrayItem(int countrows,int index)
        {
            dataGridView1.Rows[countrows].Cells[0].Value = $"Label[{index + 1}]";
            dataGridView1.Rows[countrows].Cells[1].Value = labels[index].LabelName;
            dataGridView1.Rows[countrows].Cells[2].Value = labels[index].DataCreate.ToShortDateString();
            dataGridView1.Rows[countrows].Cells[3].Value = labels[index].FilePath;
        }

        private bool IsArrayItemClear(int index)
        {
            if (labels[index].LabelName == null && labels[index].DataCreate == Convert.ToDateTime("01.01.0001 0:00:00") && labels[index].FilePath == null) return true;
            return false;
        }
    }
}
