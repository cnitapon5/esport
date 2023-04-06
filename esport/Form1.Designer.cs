namespace esport
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            addTeamToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem1 = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbName = new TextBox();
            button5 = new Button();
            label1 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label9 = new Label();
            button1 = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripDropDownButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1190, 25);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, saveFileToolStripMenuItem, closeToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(38, 22);
            toolStripDropDownButton1.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(124, 22);
            openFileToolStripMenuItem.Text = "Open File";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(124, 22);
            saveFileToolStripMenuItem.Text = "Save File";
            saveFileToolStripMenuItem.Click += saveFileToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(124, 22);
            closeToolStripMenuItem.Text = "Close";
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { addTeamToolStripMenuItem, closeToolStripMenuItem1 });
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(48, 22);
            toolStripDropDownButton2.Text = "Team";
            // 
            // addTeamToolStripMenuItem
            // 
            addTeamToolStripMenuItem.Name = "addTeamToolStripMenuItem";
            addTeamToolStripMenuItem.Size = new Size(119, 22);
            addTeamToolStripMenuItem.Text = "All Team";
            addTeamToolStripMenuItem.Click += addTeamToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem1
            // 
            closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            closeToolStripMenuItem1.Size = new Size(119, 22);
            closeToolStripMenuItem1.Text = "Close";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column8, Column5, Column9, Column6, Column10, Column7, Column11 });
            dataGridView1.Location = new Point(12, 27);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(828, 368);
            dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "ชื่อทีม";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column2.HeaderText = "สมาชิกทีมคนที่1";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "ชื่อในเกมคนที่1";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "สมาชิกทีมคนที่2";
            Column4.Name = "Column4";
            // 
            // Column8
            // 
            Column8.HeaderText = "ชื่อในเกมคนที่2";
            Column8.Name = "Column8";
            // 
            // Column5
            // 
            Column5.HeaderText = "สมาชิกทีมคนที่3";
            Column5.Name = "Column5";
            // 
            // Column9
            // 
            Column9.HeaderText = "ชื่อในเกมคนที่3";
            Column9.Name = "Column9";
            // 
            // Column6
            // 
            Column6.HeaderText = "สมาชิกทีมคนที่4";
            Column6.Name = "Column6";
            // 
            // Column10
            // 
            Column10.HeaderText = "ชื่อในเกมคนที่4";
            Column10.Name = "Column10";
            // 
            // Column7
            // 
            Column7.HeaderText = "สมาชิกทีมคนที่5";
            Column7.Name = "Column7";
            // 
            // Column11
            // 
            Column11.HeaderText = "ชื่อในเกมคนที่5";
            Column11.Name = "Column11";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 211);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 59;
            label6.Text = "ชื่อ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 182);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 57;
            label5.Text = "ชื่อ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(120, 61);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 60;
            label7.Text = "ชื่อสมาชิก";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 153);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 55;
            label4.Text = "ชื่อ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 124);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 53;
            label3.Text = "ชื่อ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 95);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 51;
            label2.Text = "ชื่อ";
            // 
            // tbName
            // 
            tbName.Location = new Point(97, 17);
            tbName.Name = "tbName";
            tbName.Size = new Size(206, 23);
            tbName.TabIndex = 48;
            // 
            // button5
            // 
            button5.Location = new Point(134, 246);
            button5.Name = "button5";
            button5.Size = new Size(97, 23);
            button5.TabIndex = 66;
            button5.Text = "ยืนยันเพิ่มผู้เล่น";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 49;
            label1.Text = "ชื่อ Team";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(225, 61);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 67;
            label8.Text = "ชื่อในเกม";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox10);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(841, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 270);
            groupBox1.TabIndex = 68;
            groupBox1.TabStop = false;
            groupBox1.Text = "เพิ่มข้อมูลผู้เล่น";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(194, 208);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 77;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(194, 176);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 76;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(194, 147);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 75;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(194, 118);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 74;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(194, 86);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 73;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(88, 208);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 72;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(88, 176);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 71;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(88, 147);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 70;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(88, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 69;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 68;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 411);
            label9.Name = "label9";
            label9.Size = new Size(172, 30);
            label9.TabIndex = 69;
            label9.Text = "หน้าจอทีมทั้งหมด";
            label9.Click += label9_Click;
            // 
            // button1
            // 
            button1.Location = new Point(846, 372);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 78;
            button1.Text = "ลบทีม";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 450);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem addTeamToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column11;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbName;
        private Button button5;
        private Label label1;
        private Label label8;
        private GroupBox groupBox1;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label9;
        private Button button1;
    }
}