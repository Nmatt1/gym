using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym
{
    public partial class T2 : Form
    {
        public T2()
        {
            InitializeComponent();
            box1.Items.Add("test");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void C_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void test_Click_1(object sender, EventArgs e)
        {
            {
                if (box1.Text == "" | box1.Text == ""| name.Text == "")
                {
                    MessageBox.Show("Please complete all sections", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); /// Error Box
                }
                else
                {
                    using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"H:\app\booking.txt", true)) /// Change this location to somewhere on your own computer or it wont work. 
                    {
                        file.WriteLine("First Name\r\n " + box1.Text + "\r\n\r" + box1.Text + "\r\n\r\n_____________________\r\n\r\n"); /// This is how the message is formatted in the output file 

                    }
                }
            }
        }
    }
}