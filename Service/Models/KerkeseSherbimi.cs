using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace servisi.Models
{
    public class KerkeseSherbimi
    {
        public int idKerkeseSherbimi { get; set; }
        public string targa { get; set; }
        public string tipi { get; set; }
        public string pershkrim { get; set; }
        public string vendodhja { get; set; }
        public int statusiKerkeses { get; set; }
        public string cs = WebConfigurationManager.ConnectionStrings["Servis"].ConnectionString;

        public KerkeseSherbimi()
        {

        }

        public KerkeseSherbimi(int id)
        {
            this.idKerkeseSherbimi = id;
        }

        public KerkeseSherbimi(string tr,string tip,string pershk,string vendodh,int status)
        {
            this.targa = tr;
            this.tipi = tip;
            this.pershkrim = pershk;
            this.vendodhja = vendodh;
            this.statusiKerkeses = status;
        }


        public List<KerkeseSherbimi> ListoKerkesa()
        {
            List<KerkeseSherbimi> ls = new List<KerkeseSherbimi>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "SELECT * FROM KerkeseSherbimi WHERE statusikerkeses = 0";
                SqlCommand command = new SqlCommand(cmd, con);
                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows != null)
                {
                    while(reader.Read())
                    {
                        KerkeseSherbimi kerk = new KerkeseSherbimi(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), Convert.ToInt32(reader[5]));
                        ls.Add(kerk);
                    }
                }
            }

            return ls;
        }
        public List<KerkeseSherbimi> ListoKerkesId()
        {
            List<KerkeseSherbimi> ls = new List<KerkeseSherbimi>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "SELECT * FROM KerkeseSherbimi WHERE statusikerkeses = 0";
                SqlCommand command = new SqlCommand(cmd, con);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows != null)
                {
                    while (reader.Read())
                    {
                        KerkeseSherbimi kerk = new KerkeseSherbimi(Convert.ToInt32(reader[0]));
                        ls.Add(kerk);
                    }
                }
            }

            return ls;
        }

        public List<KerkeseSherbimi> ListoKerkese()
        {
            List<KerkeseSherbimi> ls = new List<KerkeseSherbimi>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "SELECT * FROM KerkeseSherbimi WHERE Idksh = "+this.idKerkeseSherbimi+"";
                SqlCommand command = new SqlCommand(cmd, con);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows != null)
                {
                    while (reader.Read())
                    {
                        KerkeseSherbimi kerk = new KerkeseSherbimi(reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), Convert.ToInt32(reader[5]));
                        ls.Add(kerk);
                    }
                }
            }

            return ls;
        }

        public void UpdateStatusKerkese()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "UPDATE KerkeseSherbimi SET statusikerkeses = 1 WHERE  Idksh = " + this.idKerkeseSherbimi + "";
                SqlCommand command = new SqlCommand(cmd, con);
                command.ExecuteNonQuery();
            }
        }
    }
}