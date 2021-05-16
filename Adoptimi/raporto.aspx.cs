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
    public partial class raporto : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(
               "Data Source=(local);" +
                 "Initial Catalog=ingsoft;" +
                 "Integrated Security=SSPI;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {//ruajtja e fotos ne databaze;
                string str = FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(Server.MapPath(".") + "//uploads" + str);
                string path = "~//uploads//" + str.ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand(" insert into Raporto(pershkrimi,em_foto,imazh) values( '" + TextBox1.Text + "','" + TextBox2.Text + "','" + path + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write( " Te dhenat u ngarkuan me sukses");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("update Raporto SET i_gjetur='po' WHERE  nr_raporti='" +nraporti.Text + "'", con);
            cmd1.ExecuteNonQuery();
            con.Close();
            Response.Write(" Ndryshimet u kryen me sukses");
        }
    }
}