using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Adoptimi
{
    public partial class Identifikohu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login(object sender, EventArgs e)
        {
            Session["Username"] = Username.Text.Trim();
            string username = Session["Username"].ToString() ;
            label1.Text = "Mirëserdhe" + Username;
            if (Session["username"] == null)
                Response.Redirect("Identifikohu.aspx");
        }

        protected void Logout(object sender, EventArgs e)
        {
            Session.Remove("Username");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Server.Transfer("butonat.html");
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("index1.html");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("Regjistrim.aspx");
        }
    }
}