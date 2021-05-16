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
    public class KerkesaSherbimit
    {
        public int IdKsh { get; set; }
        public string targa { get; set; }
        public string tipi { get; set; }
        public string pershkrim { get; set; }
        public string venndndodhja { get; set; }
        public int statusikerkeses { get; set; }
        public string cs = WebConfigurationManager.ConnectionStrings["Servis"].ConnectionString;

        public KerkesaSherbimit()
        {

        }

        public KerkesaSherbimit( string tr, string tip, string per, string vend, int stat)
        {
           
            this.targa = tr;
            this.tipi = tip;
            this.pershkrim = per;
            this.venndndodhja = vend;
            this.statusikerkeses = stat;
        }

        public KerkesaSherbimit(int idksh,string tr,string tip,string per,string vend,int stat)
        {
            this.IdKsh = idksh;
            this.targa = tr;
            this.tipi = tip;
            this.pershkrim = per;
            this.venndndodhja = vend;
            this.statusikerkeses = stat;
        }

        public void InsertToDB()
        {
            using(SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "INSERT INTO KerkeseSherbimi VALUES('" + this.targa + "','" + this.tipi + "','" + this.pershkrim + "','" + this.venndndodhja + "',0)";
                SqlCommand command = new SqlCommand(cmd, con);
                command.ExecuteNonQuery();
            }

        }
    
    }
}