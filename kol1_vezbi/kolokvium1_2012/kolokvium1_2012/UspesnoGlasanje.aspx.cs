using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UspesnoGlasanje : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string[] glasac = (string[]) Session["korisnik"];
        if (Request.Cookies["korisnik"] == null || Request.Cookies["korisnik"].Value != glasac[1])
        {
            Response.Cookies.Add(new HttpCookie("korisnik", glasac[1]));
            lblStatus.Text =
                "<b>" +
                glasac[0] +
                "</b>, Ви благодариме за учеството во акцијата за избор на најинтересен предмет на ФИНКИ. Вашиот избор беше " +
                Request.QueryString[0] +
                ". Резултатите од гласањето ќе ги добиете по електронска пошта, на " +
                "<b>" + glasac[1] + "</b>.";

            string subj = Request.QueryString[0];
            Application.Lock();
            if (Application[subj] == null)
            {
                Application[subj] = 1;
                Application.UnLock();
            }
            else
            {
                Application[subj] = (int)Application[subj] + 1;
                Application.UnLock();
            }
        }
        else
        {
            lblStatus.Text =
                "<b>" +
                glasac[0] +
                "</b>, веќе учествувавте во гласањето. Секој корисник има право да гласа само еднаш. Ви благодариме!";
        }
    }

    protected void btnRezultati_Click(object sender, EventArgs e)
    {
        Response.Redirect("Rezultati.aspx");
    }
}