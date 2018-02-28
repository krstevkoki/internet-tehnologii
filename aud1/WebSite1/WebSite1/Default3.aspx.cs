using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            string[] vrednosti = new string[10];
            for (int i = 0; i < vrednosti.Length; i++)
                vrednosti[i] = Convert.ToString(i + 1);

            lstBox.DataSource = vrednosti;
            lstBox.DataBind();

            ddlList.DataSource = vrednosti;
            ddlList.DataBind();

            chbList.DataSource = vrednosti;
            chbList.DataBind();

            rblList.DataSource = vrednosti;
            rblList.DataBind();
        }
    }
}