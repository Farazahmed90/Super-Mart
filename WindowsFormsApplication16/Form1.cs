using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            bool check = dal.login(textBox1.Text, textBox2.Text);
            if (check == true)
            {
                progressBar1.Show();
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 2000;
                for (int i = 0; i < 2000; i++)
                {
                    progressBar1.Value = i;

                }
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Invalid User id or and Password ");
                textBox1.Clear();
                textBox2.Clear();
            
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
