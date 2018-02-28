using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        ListItem item = new ListItem(txtValuta.Text, txtVrednost.Text);

        if (!rblValuti.Items.Contains(item))
        {
            rblValuti.Items.Add(new ListItem(txtValuta.Text, txtVrednost.Text));
            lblStatus.Text = Convert.ToString(rblValuti.Items.Count);
        }
    }

    protected void btnOtstrani_Click(object sender, EventArgs e)
    {
        if (rblValuti.SelectedIndex != -1)
        {
            rblValuti.Items.Remove(rblValuti.SelectedItem);
            lblStatus.Text = Convert.ToString(rblValuti.Items.Count);
        }
        else
            lblStatus.Text = "<span style='color: red '>Немате селектирано ставка од листата</span>";
    }

    protected void rblValuti_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblValuta.Text = rblValuti.SelectedItem.Text;
        try
        {
            lblKonverzija.Text = Convert.ToString(
                Convert.ToDouble(rblValuti.SelectedItem.Value) * Convert.ToDouble(txtKonverzija.Text));
        }
        catch (Exception exception)
        {
            lblKonverzija.Text = exception.Message;
        }
        
    }
}