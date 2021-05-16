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
    public partial class adopto : System.Web.UI.Page
    {
        SqlConnection con= new SqlConnection(
            "Data Source=(local);" + 
              "Initial Catalog=ingsoft;" + 
              "Integrated Security=SSPI;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void Button2_Click(object sender, EventArgs e)
        {
            if ( FileUpload1.HasFile)
             {//ruajtja e fotos ne databaze;
                string str= FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(Server.MapPath(".")+"//uploads"+str);
                string path="~//uploads//"+str.ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand(" insert into Adoptim(em_kafshes,mosha,email,nr_kontakti,sasia,em_foto,imazh) values( '" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + path + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                L1.Text=" Te dhenat u ngarkuan me sukses ";

             }
            else {
                L1.Text=" Ngarko te dhenat ";
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {con.Open();
            SqlCommand cmd1= new SqlCommand("update Adoptim SET adoptuar='po' WHERE  nr_adoptimi='"+adoptuar.Text +"'",con);
            cmd1.ExecuteNonQuery();
            con.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand("update Adoptim SET sasia='"+TextBox7.Text+"' WHERE  nr_adoptimi='" + TextBox8.Text + "'", con);
            cmd2.ExecuteNonQuery();
            con.Close();

        }

       


        
    }
}