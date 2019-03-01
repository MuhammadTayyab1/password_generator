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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin" && textBox2.Text=="1234")
            {
                Form3 my = new Form3();
                my.Show();
            }
            else
            {
                label3.Text = "Incorrect username or password";
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.Show();
        }

       
    }
}
