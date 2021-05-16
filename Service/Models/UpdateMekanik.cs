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
    public class UpdateMekanik
    {
        int Id { get; set; }
        string NePune { get; set; }
        public string cs = WebConfigurationManager.ConnectionStrings["Servis"].ConnectionString;

        public UpdateMekanik(int Id,string npu)
        {
            this.Id = Id;
            this.NePune = npu;
        }
        public void UpdateMekaniktodb(out string mess)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                string cmd = "UPDATE Mekaniku SET NePune =  '" + this.NePune + "' WHERE Isdn = '" + this.Id + "'";
                    SqlCommand command = new SqlCommand(cmd, con);
                
                try
                { 
                    command.ExecuteNonQuery();
                    mess= "Statusi u updateua!";
                }
                catch (Exception ex)
                {
                    mess = "Dicka shkoi gabim: " + ex.Message;
                }

            }
        }
    }
}