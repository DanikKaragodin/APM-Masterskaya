using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BD5
{
    public partial class MasterTable : Form
    {
        public MasterTable()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewColumn col = dataGridView1.Columns[0];
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    col = dataGridView1.Columns[0];
                    break;
                case 1:
                    col = dataGridView1.Columns[1];
                    break;
                default:
                    col = dataGridView1.Columns[0];
                    break;
            }
            if (radioButton1.Checked)
                dataGridView1.Sort(col, ListSortDirection.Ascending);
            else
                dataGridView1.Sort(col, ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
                мастерBindingSource.Filter = "ФИО='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            мастерBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    dataGridView1[i, j].Style.BackColor = Color.White;
                    dataGridView1[i, j].Style.ForeColor = Color.Black;
                }
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                    if (!string.IsNullOrEmpty(textBox1.Text) && true == dataGridView1[i, j].Value.ToString().Contains(textBox1.Text))
                    {
                        dataGridView1[i, j].Style.BackColor = Color.AliceBlue;
                        dataGridView1[i, j].Style.ForeColor = Color.Blue;
                    }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Мастер". При необходимости она может быть перемещена или удалена.
            this.мастерTableAdapter.Fill(this.мастерскаяDataSet.Мастер);

        }
    }
}
