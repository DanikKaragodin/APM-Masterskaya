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
    public partial class DetailReport : Form
    {
        public DetailReport()
        {
            InitializeComponent();
        }

        private void MasterReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Запчасти". При необходимости она может быть перемещена или удалена.
            this.запчастиTableAdapter.Fill(this.мастерскаяDataSet.Запчасти);

            this.reportViewer1.RefreshReport();
        }
    }
}
