using System;
using System.Windows.Forms;

namespace BD5
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Мастер". При необходимости она может быть перемещена или удалена.
            this.мастерTableAdapter.Fill(this.мастерскаяDataSet.Мастер);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            мастерBindingSource.MoveFirst();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            мастерBindingSource.MoveLast();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            мастерBindingSource.MovePrevious();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            мастерBindingSource.MoveNext();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.мастерBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.мастерскаяDataSet);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            мастерBindingSource.AddNew();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            мастерBindingSource.RemoveCurrent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MasterTable Fr6 = new MasterTable();
            Fr6.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MasterReport fr7 = new MasterReport();
            fr7.ShowDialog();
        }

        private void мастерBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.мастерBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.мастерскаяDataSet);

        }

        private void мастерBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.мастерBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.мастерскаяDataSet);

        }
    }
}
