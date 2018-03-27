using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Glasaj : System.Web.UI.Page
{
    public static readonly string[] Subjects = new string[]
    {
        "Интернет Технологии",
        "Интернет",
        "Дигитална Електроника"
    };

    private static readonly string[] Credits = new string[]
    {
        "6",
        "5.5",
        "5.5"
    };

    private static readonly string[] Professors = new string[]
    {
        "Проф. д-р Гоце Арменски",
        "Доц. д-р Магдалена Костовска",
        "Проф. д-р Иван Чорбев"
    };

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            lstPredmeti.DataSource = Subjects;
            lstPredmeti.DataBind();
            for (int i = 0; i < Professors.Length; i++)
                lstPredmeti.Items[i].Value = Professors[i];


            lstKrediti.DataSource = Credits;
            lstKrediti.DataBind();

            if (Session["predmeti"] == null)
                Session["predmeti"] = Subjects;
        }
    }

    protected void lstPredmeti_SelectedIndexChanged(object sender, EventArgs e)
    {
        lstKrediti.SelectedIndex = lstPredmeti.SelectedIndex;
        lblProfesor.Text = lstPredmeti.SelectedValue;
    }

    protected void btnGlasaj_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/UspesnoGlasanje.aspx?subject=" + lstPredmeti.SelectedItem.Text);
    }
}