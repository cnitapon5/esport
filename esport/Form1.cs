using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace esport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);

                string readAllText = File.ReadAllText(openFileDialog.FileName);
                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string allDATARAW = readAllLine[i];
                    string[] allDATASplited = allDATARAW.Split(',');
                    this.dataGridView1.Rows.Add(allDATASplited[0], allDATASplited[1], allDATASplited[2], allDATASplited[3], allDATASplited[4]);
                }
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null && dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV(.csv)|.csv";
                if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
                {
                    try
                    {
                        int columnCount = dataGridView1.Columns.Count;
                        string columnNames = "";
                        string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                        for (int i = 0; i < columnCount; i++)
                        {
                            columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                        }
                        outputCSV[0] += columnNames;
                        for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < columnCount; j++)
                            {
                                var cellValue = dataGridView1.Rows[i - 1].Cells[j].Value;
                                outputCSV[i] += cellValue != null ? cellValue.ToString() + "," : ",";
                            }
                        }
                        File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);
                        MessageBox.Show("Exported to CSV successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void addTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 addteamfrom = new Form2();
            addteamfrom.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string name1 = textBox1.Text;
            string name2 = textBox2.Text;
            string name3 = textBox3.Text;
            string name4 = textBox4.Text;
            string name5 = textBox5.Text;
            string name6 = textBox6.Text;
            string name7 = textBox7.Text;
            string name8 = textBox8.Text;
            string name9 = textBox9.Text;
            string name10 = textBox10.Text;


            //เข้าตาราง
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = name;
            dataGridView1.Rows[n].Cells[1].Value = name1;
            dataGridView1.Rows[n].Cells[2].Value = name2;
            dataGridView1.Rows[n].Cells[3].Value = name3;
            dataGridView1.Rows[n].Cells[4].Value = name4;
            dataGridView1.Rows[n].Cells[5].Value = name5;
            dataGridView1.Rows[n].Cells[6].Value = name6;
            dataGridView1.Rows[n].Cells[7].Value = name7;
            dataGridView1.Rows[n].Cells[8].Value = name8;
            dataGridView1.Rows[n].Cells[9].Value = name9;

            //เคลีย
            tbName.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndax = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndax);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}