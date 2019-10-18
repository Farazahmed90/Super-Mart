using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication16
{
    public partial class Form2 : Form
    {
        DataTable DataTb = new DataTable();
        SqlConnection con = new SqlConnection(" Data Source=DESKTOP-5NDQC5S;Initial Catalog=inbasemgm;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // VIEW/REFRESH

        private void button1_Click(object sender, EventArgs e)
        {

            con.Close();
            string s = "select * from products";
            SqlDataAdapter ad = new SqlDataAdapter(s, con);
            con.Open();
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            SearchTextBox.Clear();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            dal.insert(Convert.ToInt16(textBox1.Text),textBox2.Text,Convert.ToInt16(textBox3.Text));
            MessageBox.Show("Record have been enserted.....");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            dal.delete(Convert.ToInt32(textBox4.Text));
            MessageBox.Show("Record have been Removed.....");
            textBox4.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            dal.update(Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox5.Text), textBox6.Text, Convert.ToInt32(textBox7.Text));
            MessageBox.Show("Record have been Updated.....");
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
       
        private void Search_Function()
        {
            DataView DV = DataTb.DefaultView;
            DV.RowFilter = "name LIKE '%" + SearchTextBox.Text + "%'";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Search_Function();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-5NDQC5S;Initial Catalog=inbasemgm;Integrated Security=True");
            string s = "select * from products";
            SqlDataAdapter ad = new SqlDataAdapter(s, con);
            con.Open();
            ad.Fill(DataTb);
            dataGridView1.DataSource = DataTb;
            con.Close();
            
        }

       
    }
}
