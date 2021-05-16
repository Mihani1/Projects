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
    public class Pjese
    {
        public int idPjese { get; set; }
        public string emri { get; set; }
        public int sasia { get; set; }
        public string pershkrim { get; set; }
        public string cs = WebConfigurationManager.ConnectionStrings["Servis"].ConnectionString;

        public Pjese()
        {

        }

        public Pjese(string _emri,int _sasia,string _pershkrim)
        {
            this.emri = _emri;
            this.sasia = _sasia;
            this.pershkrim = _pershkrim;
        }

        public Pjese(int id,string _emri, int _sasia, string _pershkrim)
        {
            this.idPjese = id;
            this.emri = _emri;
            this.sasia = _sasia;
            this.pershkrim = _pershkrim;
        }




        public List<Pjese> ListePjesesh()
        {
            List<Pjese> ls = new List<Pjese>();
            using(SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "SELECT * FROM Pjeset";
                SqlCommand command = new SqlCommand(cmd, con);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows != null)
                {
                    while(reader.Read())
                    {
                        Pjese pjese = new Pjese(Convert.ToInt32(reader[0]), reader[1].ToString(), Convert.ToInt32(reader[2]), reader[3].ToString());
                        ls.Add(pjese);

                    }
                }
            }

            return ls;
        }
    }
}