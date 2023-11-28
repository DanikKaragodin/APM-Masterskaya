using System;
using System.Windows.Forms;

namespace BD5
{
    public partial class Detail: Form
    {
        public Detail()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Запчасти". При необходимости она может быть перемещена или удалена.
            this.запчастиTableAdapter.Fill(this.мастерскаяDataSet.Запчасти);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            запчастиBindingSource.MoveFirst();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            запчастиBindingSource.MoveLast();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            запчастиBindingSource.MovePrevious();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            запчастиBindingSource.MoveNext();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.запчастиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.мастерскаяDataSet);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            запчастиBindingSource.AddNew();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            запчастиBindingSource.RemoveCurrent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DetailTable Fr6 = new DetailTable();
            Fr6.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DetailReport fr7 = new DetailReport();
            fr7.ShowDialog();
        }

        private void запчастиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.запчастиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.мастерскаяDataSet);

        }
    }
}
