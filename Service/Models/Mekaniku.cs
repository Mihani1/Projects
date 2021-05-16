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
    public class Mekaniku
    {
        public int isdn { get; set; }
        public string emri { get; set; }
        public string mbiemri { get; set; }
        public int mosha { get; set; }
        public string specializim { get; set; }
        public string cs = WebConfigurationManager.ConnectionStrings["Servis"].ConnectionString;


        public Mekaniku()
        {

        }
        public Mekaniku(int _isdn,string _emri, string _mbiemri, int _mosha, string specializim)
        {
            this.isdn = _isdn;
            this.emri = _emri;
            this.mbiemri = _mbiemri;
            this.mosha = _mosha;
            this.specializim = specializim;
        }


        public Mekaniku(string _emri,string _mbiemri,int _mosha,string specializim)
        {
            this.emri = _emri;
            this.mbiemri = _mbiemri;
            this.mosha = _mosha;
            this.specializim = specializim;
        }

        public List<Mekaniku> ListeMekanikesh()
        {
            List<Mekaniku> ls = new List<Mekaniku>();
            using(SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                string cmd = "SELECT * FROM Mekaniku";
                SqlCommand command = new SqlCommand(cmd, con);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows != null)
                {
                    while (reader.Read())
                    {
                        Mekaniku mek = new Mekaniku(Convert.ToInt32(reader[0]),reader[1].ToString(), reader[2].ToString(), Convert.ToInt32(reader[3]), reader[4].ToString());
                        ls.Add(mek);
                    }

                }
            }

            return ls;
        }
    }
}