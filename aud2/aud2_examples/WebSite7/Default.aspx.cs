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
        if (!this.IsPostBack)
        {
            mvRegistracija.ActiveViewIndex = 0;
        }
    }

    protected void btnNext0_Click(object sender, EventArgs e)
    {
        mvRegistracija.ActiveViewIndex += 1;
    }

    protected void btnPocetok_Click(object sender, EventArgs e)
    {
        mvRegistracija.SetActiveView(vwCekor1);
    }
}