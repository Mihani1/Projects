using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace servisi.Models
{
    public class DetajeSherbimi
    {
        public int idSherbimi { get; set; }
        public int idPjese { get; set; }
        public int sasia { get; set; }
        public int cmimi { get; set; }
        public int cmimiTotal { get; set; }
        public string cs = WebConfigurationManager.ConnectionStrings["Servis"].ConnectionString;

        public DetajeSherbimi(int _idSh,int _idP,int _sasia,int _cmimi)
        {
            this.idSherbimi = _idSh;
            this.idPjese = _idP;
            this.sasia = _sasia;
            this.cmimi = _cmimi;
        }

        public DetajeSherbimi(int idSh)
        {
            this.idSherbimi = idSh;
        }

        public void ShtoDetajeNeDataBaze(out string message)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "INSERT INTO detajesherbim VALUES(" + this.idSherbimi + "," + this.idPjese + "," + this.sasia + ","+this.cmimi+")";
                SqlCommand command = new SqlCommand(cmd, con);
                try
                {
                    command.ExecuteNonQuery();
                    message = "Shtimi i pjeses ne sherbim u krye me sukses!";
                }
                catch(Exception ex)
                {
                    message = "Dicka shkoi gabim :" + ex.Message;
                }
            }
        }

        public void LlogaritCmim(out string message)
        {
            message = string.Empty;
            
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "SELECT SUM(sasia*cmimpernjesi) FROM detajesherbim WHERE idsh = " + this.idSherbimi + "";
                
                SqlCommand command = new SqlCommand(cmd,con);
                

                try
                {
                    this.cmimiTotal = Convert.ToInt32(command.ExecuteScalar());
                    string cmd2 = "UPDATE sherbim SET cmimi = " + this.cmimiTotal + " WHERE Idsh = " + idSherbimi + "";
                    SqlCommand command2 = new SqlCommand(cmd2, con);
                    command2.ExecuteNonQuery();
                    message = "Cmimi u llogarit. Sherbimi u hap me sukses!";
                }
                catch(Exception ex)
                {
                    message = "Dicka shkoi gabim:" + ex.Message;
                }

            }
        }
    }
}