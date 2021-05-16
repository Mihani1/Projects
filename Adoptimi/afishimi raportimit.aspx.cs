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
    public partial class afishimi_raportimit : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(
              "Data Source=(local);" +
                "Initial Catalog=ingsoft;" +
                "Integrated Security=SSPI;");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select nr_raporti,pershkrimi, i_gjetur, imazh from Raporto", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            DataBind();
        }
    }
}