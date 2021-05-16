using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Web.Configuration;

namespace servisi.Models
{
    public class Perdorues
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string cs = WebConfigurationManager.ConnectionStrings["Servis"].ConnectionString;

        public Perdorues()
        {

        }

        public Perdorues(string un,string pwd)
        {
            this.username = un;
            this.password = pwd;
        }

        public bool Identify(out int id,out string message)
        {
            bool flag = false; id = 0;
            using(SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "SELECT * FROM Perdorues WHERE username = '"+this.username+"' AND passwd = '"+this.password+"'";
                SqlCommand command = new SqlCommand(cmd, con);
                SqlDataReader rdr = command.ExecuteReader();

                if(rdr.HasRows == true)
                {
                    while(rdr.Read())
                    {
                        id = Convert.ToInt32(rdr[0]);
                    }
                    
                    flag = true;
                    message = "Login Successful!";
                }
                else
                {
                    flag = false;
                    message = "Login failed!";
                }
            }

            return flag;
        }
    }
}