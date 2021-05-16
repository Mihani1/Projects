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
    public class Sherbim
    {
        public string emer { get; set; }
        
        public string tipi { get; set; }
        public string pershkrim { get; set; }
        public int idSherbimi { get; set; }
        public int idmekanik { get; set; }
       
        public string cs = WebConfigurationManager.ConnectionStrings["Servis"].ConnectionString;

        public Sherbim(string _emer,int _idMekanik,string _tipi,string _pershkrim)
        {
            this.emer = _emer;
            
            this.tipi = _tipi;
            this.pershkrim = _pershkrim;
            this.idmekanik = _idMekanik;
           
        }

        public Sherbim(int idSherb,string em)
        {
            this.idSherbimi = idSherb;
            this.emer = em;
        }

        public Sherbim()
        {

        }

        public void ShtoSherbimNeDatabaze(out string message,out int idSherbimi)
        {
            message = string.Empty;
            idSherbimi = Int32.MinValue;
            using(SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "INSERT INTO sherbim(emri,pershkrim,isdn,tipi) VALUES ('" + this.emer + "','" + this.pershkrim + "'," + this.idmekanik + ",'" + this.tipi + "');SELECT SCOPE_IDENTITY()";
                SqlCommand command = new SqlCommand(cmd, con);
                
                try
                {
                    idSherbimi = Convert.ToInt32(command.ExecuteScalar());
                    message = "Shtimi u krye me sukses!";
                }
                catch(Exception ex)
                {
                    message = "Dicka shkoi gabim:" + ex.Message;
                }
                    
            
                
            }
        }

        public List<Sherbim> ListeSherbimi()
        {
            List<Sherbim> ls = new List<Sherbim>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "SELECT * FROM sherbim";
                SqlCommand command = new SqlCommand(cmd, con);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows != false)
                {
                    while(reader.Read())
                    {
                        Sherbim sherb = new Sherbim(Convert.ToInt32(reader[0]),reader[1].ToString());
                        ls.Add(sherb);
                    }
                }
            }
            return ls;
        }


        
   
    }
}