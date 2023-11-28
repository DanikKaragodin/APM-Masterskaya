using System;
using System.Windows.Forms;

namespace BD5
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.мастерскаяDataSet.Клиент);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            клиентBindingSource.MoveFirst();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            клиентBindingSource.MoveLast();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            клиентBindingSource.MovePrevious();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            клиентBindingSource.MoveNext();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.мастерскаяDataSet);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            клиентBindingSource.AddNew();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            клиентBindingSource.RemoveCurrent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ClientTable Fr6 = new ClientTable();
            Fr6.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ClientReport fr7 = new ClientReport();
            fr7.ShowDialog();
        }

        private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.мастерскаяDataSet);

        }
    }
}
