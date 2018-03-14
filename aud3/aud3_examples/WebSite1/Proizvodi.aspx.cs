using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Proizvodi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ArrayList lista;
        if (Session["kosnicka"] != null)
        {
            lista = (ArrayList) Session["kosnicka"];
            lstKosnicka.DataSource = lista;
            lstKosnicka.DataBind();
        }

        if (!this.IsPostBack)
        {
            string[] tehnickaLiteratura = new[]
            {
                "Tehnicka Kniga 1",
                "Tehnicka Kniga 2",
                "Tehnicka Kniga 3"
            };
            string[] tehnickaLiteraturaCeni = new string[]
            {
                "1400",
                "2930",
                "2500",
            };

            string[] naucnaFantastika = new[]
            {
                "Naucna Kniga 1",
                "Naucna Kniga 2",
                "Naucna Kniga 3"
            };
            string[] naucnaFantastikaCeni = new string[]
            {
                "1400",
                "2930",
                "2500",
            };
            string[] avtomobili = new[]
            {
                "Avtomobil 1",
                "Avtomobil 2",
                "Avtomobil 3"
            };
            string[] avtomobiliCeni = new string[]
            {
                "2300",
                "4300",
                "2010",
            };

            lblKategorija.Text = Request.QueryString["ime"];
            int category = Convert.ToInt32(Request.QueryString["id"]);

            if (category == 1)
            {
                lstProizvodi.DataSource = tehnickaLiteratura;
                lstCeni.DataSource = tehnickaLiteraturaCeni;
            }
            else if (category == 2)
            {
                lstProizvodi.DataSource = naucnaFantastika;
                lstCeni.DataSource = naucnaFantastikaCeni;
            }
            else if (category == 3)
            {
                lstProizvodi.DataSource = avtomobili;
                lstCeni.DataSource = avtomobiliCeni;
            }

            lstProizvodi.DataBind();
            lstCeni.DataBind();
        }
    }

    protected void lstProizvodi_SelectedIndexChanged(object sender, EventArgs e)
    {
        lstCeni.SelectedIndex = lstProizvodi.SelectedIndex;
        if (ViewState["brPromeni"] == null)
        {
            ViewState["brPromeni"] = 1;
        }
        else
        {
            ViewState["brPromeni"] = (int) ViewState["brPromeni"] + 1;
        }

        lblBrPromeni.Text = ((int) ViewState["brPromeni"]).ToString();
    }

    protected void btnDodadi_Click(object sender, EventArgs e)
    {
        ArrayList lista;
        if (Session["kosnicka"] == null)
        {
            lista = new ArrayList();
        }
        else
        {
            lista = (ArrayList) Session["kosnicka"];
        }

        lista.Add(new ListItem(lstProizvodi.SelectedItem.Text, lstCeni.SelectedItem.Text));
        lstKosnicka.DataSource = lista;
        lstKosnicka.DataBind();
        Session["kosnicka"] = lista;
    }

    protected void btnKupi_Click(object sender, EventArgs e)
    {
        Response.Redirect("Plakjanje.aspx");
    }
}