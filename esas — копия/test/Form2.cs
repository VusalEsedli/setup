using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "vusal2017" && textBox2.Text == "2017")
            {
                Form1 Test = new Form1();
                Test.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("sehv giris etdiniz");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
