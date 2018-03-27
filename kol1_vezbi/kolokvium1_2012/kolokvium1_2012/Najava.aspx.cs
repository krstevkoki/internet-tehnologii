using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Najava : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*Session.Abandon();
        Request.Cookies.Clear();
        Response.Cookies.Clear();
        Application.Clear();*/
    }

    protected void btnNajavi_Click(object sender, EventArgs e)
    {
        Session["korisnik"] = new[] {txtIme.Text, txtEmail.Text};
        Response.Redirect("Glasaj.aspx");
    }
}