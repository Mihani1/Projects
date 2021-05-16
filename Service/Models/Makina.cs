using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace servisi.Models
{
    public class Makina
    {
        public string Targa { get; set; }
        public string Marka { get; set; }
        public string tipi { get; set; }
        public string ngjyra { get; set; }
        public string cs = WebConfigurationManager.ConnectionStrings["Servis"].ConnectionString;

        public Makina(string Tr, string marka,string tip,string ngj)
        {
            this.Targa = Tr;
            this.Marka = marka;
            this.tipi = tip;
            this.ngjyra = ngj;

        }


        public void InsertDb( out string message)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "INSERT INTO Makina VALUES('" + this.Targa + "','" + this.Marka + "','" + this.tipi + "','" + this.ngjyra + "')";
                SqlCommand command = new SqlCommand(cmd, con);

                try
                {
                    command.ExecuteNonQuery();
                    message = "Shtimi u krye me sukses!";
                }
                catch (Exception ex)
                {
                    message = "Shtimi deshtoi! " + ex.Message;
                }
            }

        }
        
    }

}