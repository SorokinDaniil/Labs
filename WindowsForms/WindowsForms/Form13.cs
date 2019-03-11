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
using System.ComponentModel.DataAnnotations;

namespace WindowsForms
{
    public partial class Form13 : Form
    {
        List<FileInfo> listfile;
        DateTime from;
        DateTime to;
        int index;
        int indexopenfile;
        public Form13()
        {
            InitializeComponent();
            createfileToolStripMenuItem.Click += CreatefileToolStripMenuItem_Click;
            showFileToolStripMenuItem.Click += ShowFileToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;
            button1.Click += Button1_Click;
            dataGridView1.EditingControlShowing += DataGridView1_EditingControlShowing;
         
            listfile = new List<FileInfo>();
            from = new DateTime(2000, 01, 01);
            to = new DateTime(2019, 03, 11);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.AllowUserToAddRows == false) throw new Exception("Не выбран ни один список");
                else
                if (dataGridView1.Rows.Count == 1) throw new Exception("Вы не сделали ни одну запись");
                else
                if (IsCellClear()) throw new Exception("Введите полную информацию");
                else
                {
                    StreamWriter sw = new StreamWriter(listfile[indexopenfile].FullName);
        
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        string date = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        if (DateTime.TryParse(date, out from))
                        {
                            if (DateTime.Parse(date) >= from && DateTime.Parse(date) <= to)
                            {
                                //Если значение даты прошло валидацию , то мы перезаписываем значения в файле
                                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    sw.WriteLine(dataGridView1.Rows[i].Cells[j].Value);
                                }
                               
                            }
                            else throw new Exception("Неверный формат даты");
                        }
                        else
                            throw new Exception("Неверный формат даты");
                    }

                    sw.Close();
                    dataGridView1.Rows.Clear();
                    dataGridView1.AllowUserToAddRows = false;
                    MessageBox.Show("Все ок");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void ShowFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
                if (listfile.Count == 0) MessageBox.Show("Не найден ни одни файл");
                else
                {
                    string textfile = " ";
                    using (StreamReader sr = new StreamReader(listfile[index].FullName))
                    {
                           
                            textfile = sr.ReadLine();
                    if (textfile == null)
                    {
                        DialogResult result = MessageBox.Show("Файл пуст. Хотите добавить записи ?", "Сообщение", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            //dataGridView1.RowCount = 2;
                            //dataGridView1.Rows[0].Cells[0].Value = "123";
                            //dataGridView1.Rows[0].Cells[1].Value = "asfsda";
                            //dataGridView1.Rows[0].Cells[2].Value = "sdfsdf";
                            //dataGridView1.Rows[0].Cells[3].Value = "22.05.2000";
                            //dataGridView1.Rows[1].Cells[0].Value = "464";
                            //dataGridView1.Rows[1].Cells[1].Value = "asfsda";
                            //dataGridView1.Rows[1].Cells[2].Value = "sdfsdf";
                            //dataGridView1.Rows[1].Cells[3].Value = "22.06.2004";
                            indexopenfile = index;
                            dataGridView1.AllowUserToAddRows = true;
                            label3.Text = Path.GetFileNameWithoutExtension(listfile[index].FullName);
                        }
                    }
                    else
                    {
                        dataGridView1.Rows.Clear();
                       
                        dataGridView1.AllowUserToAddRows = true;
                        indexopenfile = index;
                        label3.Text = Path.GetFileNameWithoutExtension(listfile[index].FullName);
                        
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            dataGridView1.RowCount++;
                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                dataGridView1.Rows[i].Cells[j].Value = textfile;
                                textfile = sr.ReadLine();
                            }
                            if (textfile == null) break;

                        }

                        //while (true)
                        //{


                        //    if (textfile == "")
                        //    {
                        //        dataGridView1.RowCount++;
                        //        countrow++;
                        //        countcolumn = 0;
                        //    }
                        //    else
                        //    if (textfile == null) break;
                        //    else
                        //     countcolumn++;
                        //}
                    }
                }

            }
        
            
                    
          
        }

        private bool IsCellClear()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == null) return true;
                }
            }
            return false;
        }

        private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;
            tb.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);

            e.Control.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);
        }

        private void dataGridViewTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;
            switch (columnindex)
            {
                case 0:
                    {
                        number = e.KeyChar;
                        if (!Char.IsDigit(number) && number != 8 && number != 48)
                            e.Handled = true;
                    }
                    break;
                case 1:
                    {
                        number = e.KeyChar;
                        if (!Char.IsLetter(number) && number != 8 && number != 32)
                            e.Handled = true;
                    }
                    break;
                case 2:
                    {
                        number = e.KeyChar;
                        if (!Char.IsLetterOrDigit(number) && number != 8 && number != 44 && number != 46 && number != 32)
                            e.Handled = true;

                    }
                    break;
                case 3:
                    {
                        number = e.KeyChar;
                        if (!Char.IsDigit(number) && number != 8 && number != 46)
                            e.Handled = true;
                    }
                    break;
                default: break;
            }

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            index = (int)numericUpDown1.Value - 1;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAllFiles();
            Application.Exit();
        }

        private void CreatefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listfile.Add(new FileInfo($"Список повышеного спроса №{listfile.Count + 1}.txt"));
            FileStream fs = listfile[listfile.Count - 1].Create();
            fs.Close();
            MessageBox.Show("Файл создан");
            numericUpDown1.Maximum = listfile.Count;
            numericUpDown1.Minimum = 1;
          
        }

        private void Form13_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeleteAllFiles();
        }

        private void DeleteAllFiles ()
        {
            if (listfile.Count != 0)
                foreach (FileInfo fi in listfile)
                        if (fi.Exists)
                            fi.Delete();
        }
    }
}
