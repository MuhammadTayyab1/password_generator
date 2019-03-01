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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random r = new Random();

                int limit = Convert.ToInt32(textBox1.Text);
                string save = "";

                if (radioButton1.Checked)
                {

                    for (int i = 0; i < limit; i++)
                    {
                        int a = r.Next(0, 10);
                        save += Convert.ToString(a);
                    }
                }
                else if (radioButton2.Checked)
                {
                    int limit1 = limit / 2;
                    for (int i = 0; i < limit1; i++)
                    {
                        int a = r.Next(71, 91);
                        save += Convert.ToString((char)a + "" + a);
                    }
                }
                else if (radioButton3.Checked)
                {
                    int limit2 = limit / 3;
                    Random q = new Random();
                    for (int i = 0; i < limit2; i++)
                    {
                        int a = r.Next(71, 91);
                        int b = q.Next(33, 47);
                        save += Convert.ToString((char)a + "" + a + "" + (char)b);
                    }
                }
                textBox2.Text = save;
                label3.Text = "Your Password is";
            }
            catch
            {
                label4.Text = "Please complete steps carefully";
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved Successfully");
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press ctrl + c for copy your generated password");
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press ctrl + v for paste your generated password");
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printer is not connected");
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            Form3 my = new Form3();
            my.Show();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ibi is level ka nahi ata");
        }
    }
}