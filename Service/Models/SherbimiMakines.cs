using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;


namespace servisi.Models
{
    public class SherbimiMakines
    {
        public int idsh { get; set; }
        public string Targa { get; set; }
        public string data { get; set; }
        public int statusi { get; set; }
        public string cs = WebConfigurationManager.ConnectionStrings["Servis"].ConnectionString;

        public SherbimiMakines()
        {

        }

        public SherbimiMakines(string targa)
        {
            this.Targa = targa;
        }

        public void SetStatus()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "SELECT TOP(1) statusi FROM SherbimMakine WHERE Targa =  '"+this.Targa+"'";
                SqlCommand command = new SqlCommand(cmd, con);
                this.statusi = Convert.ToInt32(command.ExecuteScalar());
            }
        }
    }
}