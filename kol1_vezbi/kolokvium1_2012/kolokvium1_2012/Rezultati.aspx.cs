using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Rezultati : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            if (Session["predmeti"] != null)
            {
                string[] subjects = (string[]) Session["predmeti"];
                lstPredmeti.DataSource = subjects;
                lstPredmeti.DataBind();

                if (Application[subjects[0]] != null)
                    lstGlasovi.Items.Add(Convert.ToString(Application[subjects[0]]));
                else
                    lstGlasovi.Items.Add("0");

                if (Application[subjects[1]] != null)
                    lstGlasovi.Items.Add(Convert.ToString(Application[subjects[1]]));
                else
                    lstGlasovi.Items.Add("0");

                if (Application[subjects[2]] != null)
                    lstGlasovi.Items.Add(Convert.ToString(Application[subjects[2]]));
                else
                    lstGlasovi.Items.Add("0");
            }
        }
    }

    protected void lstPredmeti_SelectedIndexChanged(object sender, EventArgs e)
    {
        lstGlasovi.SelectedIndex = lstPredmeti.SelectedIndex;
    }
}