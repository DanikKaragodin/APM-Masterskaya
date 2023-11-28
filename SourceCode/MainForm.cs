using System;
using System.Windows.Forms;

namespace BD5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client form = new Client();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Master form = new Master();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guaranty form = new Guaranty();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Detail form = new Detail();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Defects form = new Defects();
            form.ShowDialog();
        }
    }
}
