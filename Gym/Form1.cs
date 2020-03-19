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
    
    
    
    public partial class Form1 : Form
    {
        public static string SetVaulueForname = "";
        public Form1()
        {
            InitializeComponent();
            MNB.Items.Add("1");
            MNB.Items.Add("2");
            MNB.Items.Add("3");
            MNB.Items.Add("4");
            MNB.Items.Add("5");
            MNB.Items.Add("6");
            EM.Items.Add("Airdyne Bike");
            EM.Items.Add("Treadmill");
            EM.Items.Add("Elliptical Trainer");
            EM.Items.Add("Rowing Machine");
            EM.Items.Add("Stair Stepper");
            EM.Items.Add("Weights (10 reps)");
            

    }

    private void submit_Click(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                MessageBox.Show("Please complete all sections", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); /// Error Box
            }
            else
            {
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"H:\app\name.txt", true)) /// Change this location to somewhere on your own computer or it wont work. 
                {
                    file.WriteLine("First Name\r\n " + name.Text +  "\r\n\r\n_____________________\r\n\r\n"); /// This is how the message is formatted in the output file 
                    ///file.WriteLine("First Name\r\n " + First_Name.Text + "\r\n\r\nLastName\r\n" + Last_Name.Text + "\r\n\r\nFilm\r\n" + FilmBox.Text + "\r\n\r\nSpecial Requirements\r\n" + SR.Text + "\r\n\r\nRows\r\n" + Rows.Text + "\r\n\r\nSeats\r\n" + Seats.Text + "\r\n\r\n_____________________\r\n\r\n");
                }
            }
        }

        public void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MNB.Text == "6")
            {
                EM.Items.Clear();
                EM.Items.Add("Airdyne Bike");
                EM.Items.Add("Treadmill");
                EM.Items.Add("Elliptical Trainer");
                EM.Items.Add("Rowing Machine");
                EM.Items.Add("Stair Stepper");
                EM.Items.Add("Weights (10 reps)");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            T2 secondForm = new T2();


            secondForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
