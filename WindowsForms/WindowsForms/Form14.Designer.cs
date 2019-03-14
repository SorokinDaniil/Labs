namespace WindowsForms
{
    partial class Form14
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.editbutton = new System.Windows.Forms.Button();
            this.allLabelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pathcombo = new System.Windows.Forms.ComboBox();
            this.datecombo = new System.Windows.Forms.ComboBox();
            this.namecombo = new System.Windows.Forms.ComboBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "File Path:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Label Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.path);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.editbutton);
            this.groupBox1.Location = new System.Drawing.Point(20, 357);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(637, 129);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Data Create:";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(105, 44);
            this.date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(0, 17);
            this.date.TabIndex = 4;
            // 
            // path
            // 
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(84, 68);
            this.path.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(0, 17);
            this.path.TabIndex = 3;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(105, 21);
            this.name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 17);
            this.name.TabIndex = 5;
            // 
            // editbutton
            // 
            this.editbutton.Location = new System.Drawing.Point(529, 96);
            this.editbutton.Margin = new System.Windows.Forms.Padding(4);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(100, 26);
            this.editbutton.TabIndex = 2;
            this.editbutton.Text = "Edit";
            this.editbutton.UseVisualStyleBackColor = true;
            // 
            // allLabelsToolStripMenuItem
            // 
            this.allLabelsToolStripMenuItem.Name = "allLabelsToolStripMenuItem";
            this.allLabelsToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.allLabelsToolStripMenuItem.Text = "All labels";
            // 
            // currentLabelToolStripMenuItem
            // 
            this.currentLabelToolStripMenuItem.Name = "currentLabelToolStripMenuItem";
            this.currentLabelToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.currentLabelToolStripMenuItem.Text = "Current label";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentLabelToolStripMenuItem,
            this.allLabelsToolStripMenuItem});
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Label";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pathcombo);
            this.groupBox2.Controls.Add(this.datecombo);
            this.groupBox2.Controls.Add(this.namecombo);
            this.groupBox2.Controls.Add(this.searchbutton);
            this.groupBox2.Location = new System.Drawing.Point(16, 257);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(764, 96);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "File Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date Create";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Label Name";
            // 
            // pathcombo
            // 
            this.pathcombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.pathcombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.pathcombo.DropDownWidth = 300;
            this.pathcombo.FormattingEnabled = true;
            this.pathcombo.Location = new System.Drawing.Point(351, 44);
            this.pathcombo.Margin = new System.Windows.Forms.Padding(4);
            this.pathcombo.Name = "pathcombo";
            this.pathcombo.Size = new System.Drawing.Size(296, 24);
            this.pathcombo.TabIndex = 7;
            // 
            // datecombo
            // 
            this.datecombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.datecombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.datecombo.FormattingEnabled = true;
            this.datecombo.Location = new System.Drawing.Point(181, 44);
            this.datecombo.Margin = new System.Windows.Forms.Padding(4);
            this.datecombo.Name = "datecombo";
            this.datecombo.Size = new System.Drawing.Size(160, 24);
            this.datecombo.TabIndex = 7;
            // 
            // namecombo
            // 
            this.namecombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.namecombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.namecombo.FormattingEnabled = true;
            this.namecombo.Location = new System.Drawing.Point(12, 44);
            this.namecombo.Margin = new System.Windows.Forms.Padding(4);
            this.namecombo.Name = "namecombo";
            this.namecombo.Size = new System.Drawing.Size(160, 24);
            this.namecombo.TabIndex = 7;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(656, 44);
            this.searchbutton.Margin = new System.Windows.Forms.Padding(4);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(100, 26);
            this.searchbutton.TabIndex = 2;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.showToolStripMenuItem,
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(68, 33);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 22);
            this.numericUpDown1.TabIndex = 17;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "File Path";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 91;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date Create";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 112;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Label Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 112;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Array Item";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(16, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(764, 185);
            this.dataGridView1.TabIndex = 16;
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form14";
            this.Text = "Form14";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label path;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.ToolStripMenuItem allLabelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pathcombo;
        private System.Windows.Forms.ComboBox datecombo;
        private System.Windows.Forms.ComboBox namecombo;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}