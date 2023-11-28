using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Windows.Forms;

namespace BD5
{
    public partial class Defects : Form
    {
        private Dictionary<int, string> details = new Dictionary<int, string>(); 
        public Defects()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Запчасти". При необходимости она может быть перемещена или удалена.
            this.запчастиTableAdapter.Fill(this.мастерскаяDataSet.Запчасти);
            this.неисправностьСЗапчастямиTableAdapter.Fill(this.мастерскаяDataSet.НеисправностьСЗапчастями);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мастерскаяDataSet.Неисправности". При необходимости она может быть перемещена или удалена.
            this.неисправностиTableAdapter.Fill(this.мастерскаяDataSet.Неисправности);
            foreach (System.Data.DataRow row in this.мастерскаяDataSet.НеисправностьСЗапчастями.Rows){
                details.Add((int)row[0], row[this.мастерскаяDataSet.НеисправностьСЗапчастями.Columns.Count-1].ToString());
            }
            CurrentDetail();
        }
        private void CurrentDetail() {
            DataRowView CurRow = (DataRowView)неисправностиBindingSource.Current;
            iD_ЗапчастиTextBox.Text = details[(int)CurRow.Row[0]];
        }
        private void SaveDetail() {
            SqlConnection con = new SqlConnection("Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=Мастерская;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand delCommand = new SqlCommand("DELETE Запчасти_Неисправности", con);
            delCommand.ExecuteNonQuery();
            SqlCommand insertCommand = new SqlCommand("INSERT INTO Запчасти_Неисправности (ID_Неисправности, ID_Запчасти) VALUES (@ID_Неисправности, @ID_Запчасти)", con);
            foreach (var detail in details)
            {
                var key = detail.Key;
                foreach (var value in detail.Value.Split(new[] { ", " }, StringSplitOptions.None))
                {

                    insertCommand.Parameters.Clear();
                    insertCommand.Parameters.AddWithValue("@ID_Неисправности", key);
                    if (Int32.TryParse(value, out int val)) {
                        // label1.Text += $"{key}, {val.ToString()}\n";
                        insertCommand.Parameters.AddWithValue("@ID_Запчасти", val);}
                    else continue;
                    insertCommand.ExecuteNonQuery();
                }
            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            неисправностиBindingSource.MoveFirst();
            CurrentDetail();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            неисправностиBindingSource.MoveLast();
            CurrentDetail();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            неисправностиBindingSource.MovePrevious();
            CurrentDetail();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            неисправностиBindingSource.MoveNext();
            CurrentDetail();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.неисправностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.мастерскаяDataSet);
            SaveDetail();
           
        }
        private void button6_Click(object sender, EventArgs e)
        {
            неисправностиBindingSource.AddNew();
            DataRowView CurRow = (DataRowView)неисправностиBindingSource.Current;
            details.Add((int)CurRow.Row[0], "");
            CurrentDetail();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            DataRowView CurRow = (DataRowView)неисправностиBindingSource.Current;
            details.Remove((int)CurRow.Row[0]);
            неисправностиBindingSource.RemoveCurrent();
            CurrentDetail();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            DefectsTable Fr6 = new DefectsTable();
            Fr6.ShowDialog();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            DefectsReport fr7 = new DefectsReport();
            fr7.ShowDialog();
        }
        private void неисправностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.неисправностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.мастерскаяDataSet);
            SaveDetail();
        }
        private void iD_ЗапчастиTextBox_TextChanged(object sender, EventArgs e)
        {
            DataRowView CurRow = (DataRowView)неисправностиBindingSource.Current;
            details[(int)CurRow.Row[0]] = iD_ЗапчастиTextBox.Text; 
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.запчастиBindingSource.MoveFirst();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            this.запчастиBindingSource.MoveLast();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            this.запчастиBindingSource.MovePrevious();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            this.запчастиBindingSource.MoveNext();
        }
    }
}