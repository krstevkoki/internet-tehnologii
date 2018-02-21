using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // na sekoj refresh na stranicata se menuva vremeto, 
        // no so dodavanje na uslovot toa ne se menuva na refresh
        if (!Page.IsPostBack)
            lblVreme1.Text = DateTime.Now.ToString();
    }

    protected void btnVreme_Click(object sender, EventArgs e)
    {
        lblVreme2.Text = DateTime.Now.ToString();
    }
}