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
    public class Makine
    {
        public string targa { get; set; }
        public string marka { get; set; }
        public string tipi { get; set; }
        public string ngjyra { get; set; }
        public  string cs = WebConfigurationManager.ConnectionStrings["Servis"].ConnectionString;

        public Makine(string tr,string mk,string tp,string ngjyr)
        {
            this.targa = tr;
            this.marka = mk;
            this.tipi = tp;
            this.ngjyra = ngjyr;
        }

        public Makine(string tr)
        {
            this.targa = tr;
        }
        public List<Makine> ListeMakine()
        {
            List<Makine> ls = new List<Makine>();
            using(SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "SELECT * FROM Makina";
                SqlCommand command = new SqlCommand(cmd, con);

                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if(reader.HasRows != null)
                    {
                        while(reader.Read())
                        {
                            Makine mak = new Makine(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
                            ls.Add(mak);
                        }
                    }

                }
                catch(Exception ex)
                {

                }
            }

            return ls;
        }

        public bool checkMakine(out string message)
        {
            bool flag;
            message = string.Empty;
            using(SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "SELECT * FROM Makina WHERE targa = '" + this.targa + "'";
                SqlCommand command = new SqlCommand(cmd, con);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows == true)
                {
                    message = "Makina ekziston ne databaze!";
                    flag = true;
                }
                else
                {
                    message = "Makina nuk ekziston ne databaze!";
                    flag = false;
                }
            }

            return flag;
        }
    }
}