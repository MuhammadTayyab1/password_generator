using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace log
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text=="" || textBox3.Text=="")
            {
                label4.Text = "Please enter complete information";
            }
            else
            {
                Form3 my = new Form3();
                my.Show();
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
