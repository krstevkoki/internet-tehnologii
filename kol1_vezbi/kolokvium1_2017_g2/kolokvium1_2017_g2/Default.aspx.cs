using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private readonly string[] _dramaMovies = new string[]
    {
        "Forrest Gump",
        "Good will hunting",
        "A beautiful mind"
    };

    private readonly int[] _dramaMoviesPrices = new int[] {150, 130, 100};

    private readonly string[] _comedyMovies = new string[]
    {
        "Keeping up with the Joneses",
        "Masterminds",
        "Ted2"
    };

    private readonly int[] _comedyMoviesPrices = new int[] {120, 170, 180};

    private readonly string[] _actionMovies = new string[]
    {
        "Batman vs Superman",
        "Deadpool 3D",
        "The Accountant"
    };

    private readonly int[] _actionMoviesPrices = new int[] {350, 300, 200};

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            this.Refresh(false);
        }
    }

    protected void btnNajava_Click(object sender, EventArgs e)
    {
        this.Refresh(true);
        this.btnKupi.Enabled = false;
    }

    private void Refresh(bool status)
    {
        imgLogo.Visible = status;
        chkFilmovi.Visible = status;
        lstZanrovi.Visible = status;
        txtKolicina1.Visible = status;
        txtKolicina2.Visible = status;
        txtKolicina3.Visible = status;
        btnKupi.Visible = status;
        lblCena.Visible = status;
    }

    protected void lstZanrovi_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstZanrovi.SelectedItem.Text == "Акција")
        {
            chkFilmovi.DataSource = _actionMovies;
            chkFilmovi.DataBind();
            for (int i = 0; i < lstZanrovi.Items.Count; ++i)
                chkFilmovi.Items[i].Value = _actionMoviesPrices[i].ToString();
        }

        if (lstZanrovi.SelectedItem.Text == "Драма")
        {
            chkFilmovi.DataSource = _dramaMovies;
            chkFilmovi.DataBind();
            for (int i = 0; i < lstZanrovi.Items.Count; ++i)
                chkFilmovi.Items[i].Value = _dramaMoviesPrices[i].ToString();
        }

        if (lstZanrovi.SelectedItem.Text == "Комедија")
        {
            chkFilmovi.DataSource = _comedyMovies;
            chkFilmovi.DataBind();
            for (int i = 0; i < lstZanrovi.Items.Count; ++i)
                chkFilmovi.Items[i].Value = _comedyMoviesPrices[i].ToString();
        }

        txtKolicina1_TextChanged(sender, e);
    }

    protected void btnKupi_Click(object sender, EventArgs e)
    {
        int totalPrice = 0;
        for (int i = 0; i < chkFilmovi.Items.Count; ++i)
        {
            if (chkFilmovi.Items[i].Selected)
                totalPrice += int.Parse(chkFilmovi.Items[i].Value) * int.Parse(GetTextBox(i + 1).Text);
        }

        lblCena.Text = "Вкупната цена изнесува " + totalPrice.ToString() + " MKD";
    }

    private TextBox GetTextBox(int i)
    {
        if (i == 1)
            return txtKolicina1;
        if (i == 2)
            return txtKolicina2;
        if (i == 3)
            return txtKolicina3;
        return null;
    }

    protected void txtKolicina1_TextChanged(object sender, EventArgs e)
    {
        if (chkFilmovi.SelectedIndex == -1)
        {
            btnKupi.Enabled = false;
            return;
        }

        for (int i = 0; i < chkFilmovi.Items.Count; ++i)
        {
            if (chkFilmovi.Items[i].Selected && GetTextBox(i + 1).Text == "")
            {
                btnKupi.Enabled = false;
                return;
            }
        }

        btnKupi.Enabled = true;
    }

    protected void chkFilmovi_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtKolicina1_TextChanged(sender, e);
    }

    protected void txtKolicina2_TextChanged(object sender, EventArgs e)
    {
        txtKolicina1_TextChanged(sender, e);
    }

    protected void txtKolicina3_TextChanged(object sender, EventArgs e)
    {
        txtKolicina1_TextChanged(sender, e);
    }
}