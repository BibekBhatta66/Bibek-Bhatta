using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace S_ID
{
    class Student
    {
       static public  string N;  
       static public  string C;  
       static public string  F;  
       static public  string M;  
        static public string P; 
        SqlConnection dbcon = new SqlConnection(@"Data Source=DESKTOP-I2QF65G\BHATTA;Initial Catalog=S_Login;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Boolean Login(string name, string password)
        {
            dbcon.Close();
            SqlCommand cmd = new SqlCommand("SELECT (id) from S_ID where name like" + "'" + name + "'" + "AND Password like" + "'" + password + "'",dbcon); 
            dbcon.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {

                return false;

            }

            dbcon.Close();
}



        public void Add_ID(string name, string password, string College_Name,string father_name ,string mother_name,string photo_url )

        {
            dbcon.Close();
            SqlCommand command = new SqlCommand("INSERT INTO S_ID(Name,Password,College_Name,Father_Name,Mother_Name,Photo) values('" + name + "'" + "," + "'" + password + "'" + "," +"'"+ College_Name + "'" + "," + "'" + father_name + "'" + "," + "'" + mother_name + "'" +"," +"'" + photo_url +"'" + ")",dbcon);
            dbcon.Open();
            command.ExecuteNonQuery();

            dbcon.Close();

        }


        public void getbio(string Name,string password)
        {
            dbcon.Close();
            SqlCommand command = new SqlCommand("SELECT * from  S_ID Where Name LIKE "+"'" +Name+"'" +"AND Password LIKE "+ "'" +password +"'",dbcon);
            command.CommandType = System.Data.CommandType.Text;
            dbcon.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                 N = reader["Name"].ToString();
                 C = reader["College_Name"].ToString();
                 F = reader["Father_Name"].ToString();
                 M  = reader["Mother_Name"].ToString();
                 P = reader["Photo"].ToString();


             }
            reader.Close();
            dbcon.Close();
        }



    }
}
