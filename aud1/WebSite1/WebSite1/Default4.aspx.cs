using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void imbLogo_Click(object sender, ImageClickEventArgs e)
    {
        lblPosition.Text = "(" + e.X.ToString() + ", " + e.Y.ToString() + ")"; 
    }
}