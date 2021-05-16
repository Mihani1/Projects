using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace Adoptimi
{
    public partial class Regjistrim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(local);" +
                 "Initial Catalog=ingsoft;" +
                 "Integrated Security=SSPI;");



        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            String conString = "Data Source=(local);" +
                 "Initial Catalog=ingsoft;" +
                 "Integrated Security=SSPI;";

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from [Perdoruesit] where username=@username", con);
            cmd.Parameters.AddWithValue("@username", username.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                // "Ky username është në përdorim nga dikush tjetër";
            }
            else
            {
                //"Username është në dispozicion";

                String conString1 = "Data Source=(local);" +
                 "Initial Catalog=ingsoft;" +
                 "Integrated Security=SSPI;";
                SqlConnection con1 = new SqlConnection(conString1);
                SqlCommand cmd1 = new SqlCommand("INSERT INTO [dbo].[Perdoruesit](emer, mbiemer, mosha, email, username, fjalkalimi) VALUES (@emer,@mbiemer,@mosha,@email,@username,@fjalkalimi)", con1);
                con1.Open();
                cmd1.Parameters.AddWithValue("@emer", emer.Text);
                cmd1.Parameters.AddWithValue("@mbiemer", mbiemer.Text);
                cmd1.Parameters.AddWithValue("@mosha", mosha.Text);
                cmd1.Parameters.AddWithValue("@email", email.Text);
                cmd1.Parameters.AddWithValue("@username", username.Text);
                cmd1.Parameters.AddWithValue("@fjalkalimi", fjalkalimi.Text);

                try
                {
                    cmd1.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }


                con1.Close();
            }
        }

    }
}