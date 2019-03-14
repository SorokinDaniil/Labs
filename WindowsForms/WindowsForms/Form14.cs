using System;
using System.Collections;
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
    public partial class Form14 : Form
    {
        AutoCompleteStringCollection namechange = new AutoCompleteStringCollection();
        AutoCompleteStringCollection datechange = new AutoCompleteStringCollection();
        AutoCompleteStringCollection pathchange = new AutoCompleteStringCollection();
        List<Label> labels = new List<Label>();
        //Label[] labels = new Label[10];
        int index;
        public Form14()
        {
            InitializeComponent();
            numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;
            openToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            currentLabelToolStripMenuItem.Click += CurrentLabelToolStripMenuItem_Click;
            allLabelsToolStripMenuItem.Click += AllLabelsToolStripMenuItem_Click;
            editbutton.Click += Editbutton_Click;
            searchbutton.Click += Searchbutton_Click;
            addToolStripMenuItem.Click += AddToolStripMenuItem_Click;
            deleteToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            //for (int i = 0; i < labels.Count; i++)
            //    labels[i] = new Label();
            namecombo.KeyPress += Namecombo_KeyPress;
            datecombo.KeyPress += Datecombo_KeyPress;
            pathcombo.KeyPress += Pathcombo_KeyPress;

            openFileDialog1.Filter = "Ярлык(*.lnk)|*.lnk";
            numericUpDown1.Maximum = labels.Count;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (labels.Count != 0)
            {
                labels.RemoveAt(index);
                numericUpDown1.Maximum = labels.Count;
                MessageBox.Show("Элемент успешно удален");
            }
            else
                MessageBox.Show("Список пуст");
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labels.Add(new Label());
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = labels.Count;
            MessageBox.Show("Элемент успешно добавлен");
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
            if (labels.Count != 0)
            {
                string filepath;
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                filepath = openFileDialog1.FileName;
                name.Text = Path.GetFileNameWithoutExtension(filepath);
                date.Text = File.GetCreationTime(filepath).ToShortDateString();
                path.Text = filepath;
            }
            else
                MessageBox.Show("Список пуст");
        }

        private void CurrentLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (labels.Count != 0)
            {
                if (!IsArrayItemClear(index))
            {
                dataGridView1.RowCount = 2;
                ShowArrayItem(0, index);
            }
            else
                MessageBox.Show("Это элемент списка пуст");
        }
            else
                MessageBox.Show("Список пуст");
        }

        private void AllLabelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (labels.Count != 0)
            {
                IsCheckAllArrayItemsClear();
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = 1;
            int countrows = 0;
            for (int i = 0; i < labels.Count; i++)
                ShowAllArray("", "", ref countrows, i);
            }
            else
                MessageBox.Show("Список пуст");
        }

        private void ShowAllArray(string valuearray, string valuecombobox, ref int countrows, int i)
        {
            if (labels.Count != 0)
            {
                if (!IsArrayItemClear(i) && valuearray == valuecombobox)
            {
                dataGridView1.RowCount++;
                ShowArrayItem(countrows, i);
                countrows++;
            }
        }
            else
                MessageBox.Show("Список пуст");
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            IsCheckAllArrayItemsClear();
            int countrows = 0;
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = 1;
            if (namecombo.Text != "")
                for (int i = 0; i < labels.Count; i++)
                    ShowAllArray(labels[i].LabelName, namecombo.Text, ref countrows, i);
            if (datecombo.Text != "")
                for (int i = 0; i < labels.Count; i++)
                    ShowAllArray(labels[i].DataCreate.ToShortDateString(), datecombo.Text, ref countrows, i);
            if (pathcombo.Text != "")
                for (int i = 0; i < labels.Count; i++)
                    ShowAllArray(labels[i].FilePath, pathcombo.Text, ref countrows, i);
        }

        private void IsCheckAllArrayItemsClear()
        {
            bool check = true;
            for (int i = 0; i < labels.Count; i++)
            {
                if (!IsArrayItemClear(i))
                    check = false;
            }
            if (check)
                MessageBox.Show("Список пуст");
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
            for (int i = 0; i < labels.Count; i++)
            {
                if (!IsArrayItemClear(i))
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

        private void ShowArrayItem(int countrows, int index)
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
