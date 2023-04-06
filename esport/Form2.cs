using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace esport
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name1 = textBox1.Text;
            string name2 = textBox2.Text;
            string name3 = textBox3.Text;
            string name4 = textBox4.Text;


            //เข้าตาราง
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = name1;
            dataGridView1.Rows[n].Cells[1].Value = name2;
            dataGridView1.Rows[n].Cells[2].Value = name3;
            dataGridView1.Rows[n].Cells[3].Value = name4;

            //เคลีย
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void newPlayerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 addtem = new Form1();
            addtem.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 addtem = new Form1();
            addtem.Controls.Clear();
        }
    }
}
