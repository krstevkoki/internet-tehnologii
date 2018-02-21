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
    }

    protected void btnProveri_Click(object sender, EventArgs e)
    {
        if (txtLozinka.Text == "мрежно програмирање")
        {
            txtPoraka.Text = "";
            txtPoraka.ReadOnly = false;
        }
        else
        {
            txtPoraka.Text = "Лозинката е погрешна. Обидете се повторно!!!";
            txtPoraka.ReadOnly = true;
        }
    }

    protected void txtPoraka_TextChanged(object sender, EventArgs e)
    {
        btnPrvaStrana.Enabled = true;
    }
}