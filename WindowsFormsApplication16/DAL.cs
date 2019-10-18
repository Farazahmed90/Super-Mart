using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
    class DAL
    {
        SqlConnection con = new SqlConnection(" Data Source=DESKTOP-5NDQC5S;Initial Catalog=inbasemgm;Integrated Security=True");
        public bool login(string name,string pw) 
        {
            string s = "select name, pw from users where name='" + name + "'and pw='"+ pw +"'";
            SqlCommand com = new SqlCommand(s,con);
            SqlDataReader rdr;
            con.Open();
            rdr = com.ExecuteReader();
            return rdr.Read();
        
        }
        public void insert(int batch, string name, int price) 
        {
            string s = "insert into products values('"+batch+"','"+name+"','"+price+"');";
            SqlCommand com = new SqlCommand(s,con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        
        }
        public void update(int id, int batch, string name, int prices)
        {

            string s = "update products set batch='" + batch + "',name='" + name + "',price='" + prices + "' where pid='" + id + "'";
            SqlCommand com = new SqlCommand(s, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        public void delete(int id)
        {

            string s = "delete from products where pid='" + id + "'";
            SqlCommand com = new SqlCommand(s, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();


        }

   
    }
}
