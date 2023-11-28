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
    public partial class GuarantyReport : Form
    {
        public GuarantyReport()
        {
            InitializeComponent();
        }

        private void GuarantyReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Гарантия". При необходимости она может быть перемещена или удалена.
            this.гарантияTableAdapter.Fill(this.мастерскаяDataSet.Гарантия);

            this.reportViewer1.RefreshReport();
        }
    }
}
