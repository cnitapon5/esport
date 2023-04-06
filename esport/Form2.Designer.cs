namespace esport
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            playerBindingSource1 = new BindingSource(components);
            playerBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            newPlayerToolStripMenuItem1 = new ToolStripMenuItem();
            playerToolStripMenuItem = new ToolStripMenuItem();
            existToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            label9 = new Label();
            button1 = new Button();
            button5 = new Button();
            เพิ่มผู้เล่นใหม่ = new GroupBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            เพิ่มผู้เล่นใหม่.SuspendLayout();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(93, 114);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 117);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 25;
            label4.Text = "สาขา";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(93, 85);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 88);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 24;
            label3.Text = "รหัสนักศึกษา";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 56);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 23;
            label2.Text = "นามสกุล";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 19;
            label1.Text = "ชื่อ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(-3, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(589, 426);
            dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            Column1.HeaderText = "ชื่อ";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "นามสกุล";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "รหัสนักศึกษา";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "สาขา";
            Column4.Name = "Column4";
            // 
            // newPlayerToolStripMenuItem1
            // 
            newPlayerToolStripMenuItem1.Name = "newPlayerToolStripMenuItem1";
            newPlayerToolStripMenuItem1.Size = new Size(180, 22);
            newPlayerToolStripMenuItem1.Text = "Add Team";
            newPlayerToolStripMenuItem1.Click += newPlayerToolStripMenuItem1_Click;
            // 
            // playerToolStripMenuItem
            // 
            playerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newPlayerToolStripMenuItem1 });
            playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            playerToolStripMenuItem.Size = new Size(51, 20);
            playerToolStripMenuItem.Text = "Player";
            // 
            // existToolStripMenuItem
            // 
            existToolStripMenuItem.Name = "existToolStripMenuItem";
            existToolStripMenuItem.Size = new Size(124, 22);
            existToolStripMenuItem.Text = "Close";
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(124, 22);
            saveFileToolStripMenuItem.Text = "Save File";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(124, 22);
            openFileToolStripMenuItem.Text = "Open File";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, saveFileToolStripMenuItem, existToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, playerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(845, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 471);
            label9.Name = "label9";
            label9.Size = new Size(301, 30);
            label9.TabIndex = 70;
            label9.Text = "หน้าจอสำหรับแสดงผู้เล่นทั้งหมด";
            // 
            // button1
            // 
            button1.Location = new Point(595, 427);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 79;
            button1.Text = "ลบ";
            button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(96, 160);
            button5.Name = "button5";
            button5.Size = new Size(97, 23);
            button5.TabIndex = 80;
            button5.Text = "ยืนยันเพิ่มผู้เล่น";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // เพิ่มผู้เล่นใหม่
            // 
            เพิ่มผู้เล่นใหม่.Controls.Add(button5);
            เพิ่มผู้เล่นใหม่.Controls.Add(textBox1);
            เพิ่มผู้เล่นใหม่.Controls.Add(label1);
            เพิ่มผู้เล่นใหม่.Controls.Add(label2);
            เพิ่มผู้เล่นใหม่.Controls.Add(textBox4);
            เพิ่มผู้เล่นใหม่.Controls.Add(textBox2);
            เพิ่มผู้เล่นใหม่.Controls.Add(label4);
            เพิ่มผู้เล่นใหม่.Controls.Add(label3);
            เพิ่มผู้เล่นใหม่.Controls.Add(textBox3);
            เพิ่มผู้เล่นใหม่.Location = new Point(601, 37);
            เพิ่มผู้เล่นใหม่.Name = "เพิ่มผู้เล่นใหม่";
            เพิ่มผู้เล่นใหม่.Size = new Size(232, 183);
            เพิ่มผู้เล่นใหม่.TabIndex = 81;
            เพิ่มผู้เล่นใหม่.TabStop = false;
            เพิ่มผู้เล่นใหม่.Text = "groupBox1";
            // 
            // button2
            // 
            button2.Location = new Point(758, 427);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 82;
            button2.Text = "ปิด";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 510);
            Controls.Add(button2);
            Controls.Add(เพิ่มผู้เล่นใหม่);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Name = "Form2";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)playerBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            เพิ่มผู้เล่นใหม่.ResumeLayout(false);
            เพิ่มผู้เล่นใหม่.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private BindingSource playerBindingSource1;
        private BindingSource playerBindingSource;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private ToolStripMenuItem newPlayerToolStripMenuItem1;
        private ToolStripMenuItem playerToolStripMenuItem;
        private ToolStripMenuItem existToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Label label9;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button1;
        private Button button5;
        private GroupBox เพิ่มผู้เล่นใหม่;
        private Button button2;
    }
}