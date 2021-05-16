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
    public class Pjesa
    {
        
        public string emer { get; set; }
        public int sasia { get; set; }
        public string pershkrim { get; set; }
        public int cmimi { get; set; }
        public string cs = WebConfigurationManager.ConnectionStrings["Servis"].ConnectionString;



        public Pjesa(string _emer,int _sasi,string _pershkrim,int _cmim)
        {
            this.emer = _emer;
            this.sasia = _sasi;
            this.pershkrim = _pershkrim;
            this.cmimi = _cmim;
        }

        public Pjesa(string _emer,int _sasi)
        {
            this.emer = _emer;
            this.sasia = _sasi;
        }

        public Pjesa()
        {

        }


        public void ShtoNeDataBaze(out string message)
        {
            using(SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "INSERT INTO Pjeset VALUES('"+this.emer+"',"+this.sasia+",'"+this.pershkrim+"',"+this.cmimi+")";
                SqlCommand command = new SqlCommand(cmd, con);

                try
                {
                    command.ExecuteNonQuery();
                    message = "Shtimi u krye me sukses!";
                }
                catch(Exception ex)
                {
                    message = "Shtimi deshtoi! " + ex.Message;
                }
            }
        }

        public void UpdatePjese(out string message)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "UPDATE Pjeset SET sasia = sasia + "+this.sasia+" WHERE emri = '"+this.emer+"'";
                SqlCommand command = new SqlCommand(cmd, con);

                try
                {
                    command.ExecuteNonQuery();
                    message = "Update u krye me sukses!";
                }
                catch (Exception ex)
                {
                    message = "Update deshtoi! " + ex.Message;
                }
            }
        }


        public List<Pjesa> ShfaqPjeset()
        {
            List<Pjesa> pjeset = new List<Pjesa>();

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "SELECT * FROM Pjeset WHERE sasia < 3";
                SqlCommand command = new SqlCommand(cmd, con);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows != null)
                {
                    while(reader.Read())
                    {
                        Pjesa pjese = new Pjesa(reader[1].ToString(),Convert.ToInt32(reader[2]),reader[3].ToString(),Convert.ToInt32(reader[4]));
                        pjeset.Add(pjese);
                    }
                }

          
            }
            
            return pjeset;
        }
        
    }
}