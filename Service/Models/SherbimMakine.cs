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
    public class SherbimMakine
    {
        public int idSherbimi { get; set; }
        public string targa { get; set; }
        public DateTime date { get; set; }
        public int status { get; set; }
        public string emer { get; set;}
        public string cs = WebConfigurationManager.ConnectionStrings["Servis"].ConnectionString;

        public SherbimMakine(int idSH,int status)
        {
            this.idSherbimi = idSH;
            this.status = status;
        }

        public SherbimMakine(int idSh,string tr,DateTime data,int st)
        {
            this.idSherbimi = idSh;
            this.targa = tr;
            this.date = data;
            this.status = st;
        }

        public SherbimMakine(int idSh,string emr, string tr, int st)
        {
            this.idSherbimi = idSh;
            this.emer = emr;
            this.targa = tr;
            this.status = st;
        }

        public SherbimMakine(int idSh,string emr)
        {
            this.idSherbimi = idSh;
            this.emer = emr;
        }

        public SherbimMakine()
        {

        }

        public SherbimMakine(string tr)
        {
            this.targa = tr;
        }


        public void ShtoNeDataBaze(out string message)
        {
            using(SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "INSERT INTO SherbimMakine VALUES ("+idSherbimi+",'"+targa+"','"+date+"',"+status+")";
                SqlCommand command = new SqlCommand(cmd, con);

                try
                {
                    command.ExecuteNonQuery();
                    message = "Sherbimi i makines u hap me sukses!";
                }
                catch(Exception ex)
                {
                    message = "Dicka shkoi gabim: " + ex.Message;
                }

            }
        }

        public List<SherbimMakine> ListeSherbimi()
        {
            List<SherbimMakine> ls = new List<SherbimMakine>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "SELECT * FROM sherbim INNER JOIN SherbimMakine ON sherbim.Idsh = SherbimMakine.idsh WHERE Targa = '"+this.targa+"'";
                SqlCommand command = new SqlCommand(cmd, con);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows != false)
                {
                    while(reader.Read())
                    {
                        SherbimMakine sherb = new SherbimMakine(Convert.ToInt32(reader[0]),reader[1].ToString(),reader[7].ToString(),Convert.ToInt32(reader[9]));
                        ls.Add(sherb);
                    }
                }
            }
            return ls;
        }

        public void UpdateStatus(out string message)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "UPDATE SherbimMakine SET statusi = "+this.status+" WHERE idsh = "+this.idSherbimi+"";
                SqlCommand command = new SqlCommand(cmd, con);

                try
                {
                    command.ExecuteNonQuery();
                    message = "Statusi u updateua!";
                }
                catch (Exception ex)
                {
                    message = "Dicka shkoi gabim: " + ex.Message;
                }

            }
        }
    }
}