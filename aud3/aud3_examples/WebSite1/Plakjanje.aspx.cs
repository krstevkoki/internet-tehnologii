using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Plakjanje : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["kosnicka"] != null)
        {
            int vkupno = 0;
            ArrayList lista = (ArrayList) Session["kosnicka"];
            lstKosnicka.DataSource = lista;
            lstKosnicka.DataBind();
            foreach (ListItem item in lista)
                vkupno += Convert.ToInt32(item.Value);
            lblVkupnoDenari.Text = vkupno.ToString();
        }
        else
        {
            lblVkupnoDenari.Text = 0.ToString();

        }
    }
}