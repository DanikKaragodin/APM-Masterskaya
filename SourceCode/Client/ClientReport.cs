using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD5
{
    public partial class ClientReport : Form
    {
        public ClientReport()
        {
            InitializeComponent();
        }

        private void СlientReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.мастерскаяDataSet.Клиент);

            this.reportViewer1.RefreshReport();
        }
    }
}
