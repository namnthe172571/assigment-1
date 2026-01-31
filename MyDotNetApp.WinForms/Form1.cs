using System;
using System.Windows.Forms;

namespace MyDotNetApp.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("xin chào");
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Xin chao");
    }

    private void button2_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Tam biet");
    }
}
