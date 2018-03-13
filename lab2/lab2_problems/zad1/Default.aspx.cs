using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    private static readonly string[] Months = new[]
    {
        "Јануари",
        "Февруари",
        "Март",
        "Април",
        "Мај",
        "Јуни",
        "Јули",
        "Август",
        "Септември",
        "Октомври",
        "Ноември",
        "Декември"
    };

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            /* ==== ddlMesec ==== */
            ddlMesec.DataSource = Months;
            ddlMesec.DataBind();

            /* ==== ddlDen ==== */
            for (int i = 1; i <= 31; ++i)
                ddlDen.Items.Add(new ListItem(Convert.ToString(i), Convert.ToString(i)));

            /* ==== ddlGodina ==== */
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear; i <= currentYear + 4; ++i)
                ddlGodina.Items.Add(new ListItem(Convert.ToString(i), Convert.ToString(i)));

            /* ==== ddlVreme ==== */
            for (int i = 0; i < 24; ++i)
            {
                DateTime d = new DateTime(2018, 03, 12, i, 0, 0);
                ddlVreme.Items.Add(new ListItem(d.ToShortTimeString()));
            }

            pnlPanela1.Visible = false;
        }
    }

    protected void btnPodnesi_Click(object sender, EventArgs e)
    {
        if (ddlMesec.SelectedIndex != -1 && ddlDen.SelectedIndex != -1 && ddlDo.SelectedIndex != -1 &&
            ddlGodina.SelectedIndex != -1 && ddlOd.SelectedIndex != -1 && ddlVreme.SelectedIndex != -1 &&
            rblZona.SelectedIndex != -1 && rblKlasa.SelectedIndex != -1 && lstSredstvo.SelectedIndex != -1)
        {
            lblPatnik.Text = txbIme.Text + " " + txbPrezime.Text;
            lblSredstvo.Text = lstSredstvo.SelectedItem.Text;
            lblOd.Text = ddlOd.SelectedItem.Text;
            lblDo.Text = ddlDo.SelectedItem.Text;
            lblVreme.Text = ddlVreme.SelectedItem.Text;
            lblZona.Text = rblZona.SelectedItem.Text;
            lblKlasa.Text = rblKlasa.SelectedItem.Text;
            imgSlika.ImageUrl = lstSredstvo.SelectedItem.Value;
            lblPosluga.Text = "";
            foreach (ListItem item in cblPosluga.Items)
            {
                if (item.Selected)
                    lblPosluga.Text += (item.Text + " ");
            }

            pnlPanela1.Visible = true;
        }
    }

    protected void txbIme_TextChanged(object sender, EventArgs e)
    {
        lblPatnik.Text = "";
        lblPatnik.Text = txbIme.Text + " " + txbPrezime.Text;
    }

    protected void txbPrezime_TextChanged(object sender, EventArgs e)
    {
        txbIme_TextChanged(sender, e);
    }

    protected void ddlOd_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblOd.Text = ddlOd.SelectedItem.Text;
    }

    protected void ddlDo_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblDo.Text = ddlDo.SelectedItem.Text;
    }

    protected void ddlVreme_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblVreme.Text = ddlVreme.SelectedItem.Text;
    }

    protected void lstSredstvo_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblSredstvo.Text = lstSredstvo.SelectedItem.Text;
        imgSlika.ImageUrl = lstSredstvo.SelectedItem.Value;
    }

    protected void rblZona_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblZona.Text = rblZona.Text;
    }

    protected void rblKlasa_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblKlasa.Text = rblKlasa.Text;
    }

    protected void cblPosluga_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblPosluga.Text = "";
        foreach (ListItem item in cblPosluga.Items)
        {
            if (item.Selected)
                lblPosluga.Text += item.Text + " ";
        }
    }
}