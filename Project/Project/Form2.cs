using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                if(comboBox1.Text == "")
                {
                    MessageBox.Show("กรุณาเลือกประเทศ", "แจ้งเตือน");
                }
                else if(comboBox2.Text == "")
                {
                    MessageBox.Show("กรุณาเลือกประเทศ", "แจ้งเตือน");
                }
                else
                {
                    if(comboBox1.Text == "บูรไน")
                    {
                        double total, m = double.Parse(textBox1.Text);
                        total = (m / 2) * 24.2271;
                        textBox11.Text = total.ToString();

                    }
                }
            }
        }
    }
}
