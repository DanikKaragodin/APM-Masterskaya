using System;
using System.Windows.Forms;

namespace BD5
{
    public partial class Guaranty : Form
    {
        public Guaranty()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Гарантия". При необходимости она может быть перемещена или удалена.
            this.гарантияTableAdapter.Fill(this.мастерскаяDataSet.Гарантия);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            гарантияBindingSource.MoveFirst();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            гарантияBindingSource.MoveLast();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            гарантияBindingSource.MovePrevious();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            гарантияBindingSource.MoveNext();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.гарантияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.мастерскаяDataSet);

        }
        private void button6_Click(object sender, EventArgs e)
        {
            гарантияBindingSource.AddNew();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            гарантияBindingSource.RemoveCurrent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GuarantyTable Fr6 = new GuarantyTable();
            Fr6.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GuarantyReport fr7 = new GuarantyReport();
            fr7.ShowDialog();
        }

        private void гарантияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.гарантияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.мастерскаяDataSet);

        }
    }
}
