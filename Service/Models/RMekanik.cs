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
    public class RMekanik
    {
        public int NRid { get; set; }
        public string emri { get; set; }
        public string mb { get; set; }
        public int mosha { get; set; }
        public string sp { get; set; }
        public string npu { get; set; }
        public string cs = WebConfigurationManager.ConnectionStrings["Servis"].ConnectionString;

        public RMekanik(int NRid, string emri, string mb, int mosha, string sp, string npu)
        {

            this.NRid = NRid;
            this.emri = emri;
            this.mb = mb;
            this.mosha = mosha;
            this.sp = sp;
            this.npu = npu;

        }
        public void InserttoDb(out string message)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "INSERT INTO Mekaniku VALUES('" + this.NRid + "','" + this.emri + "','" + this.mb + "','" + this.mosha + "' ,'" + this.sp + "','" + this.npu + "')";
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