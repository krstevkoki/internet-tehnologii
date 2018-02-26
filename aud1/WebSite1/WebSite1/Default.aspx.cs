using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void lstTowns_SelectedIndexChanged(object sender, EventArgs e)
    {
        /*lblStatus.Text = "Вие го одбравте градот: \n<b>";
        lblStatus.Text += lstTowns.SelectedItem.Text;
        lblStatus.Text += "</b>";*/
        lblSelectedTowns.Text = "";
        foreach (ListItem item in lstTowns.Items)
        {
            if (item.Selected)
                lblSelectedTowns.Text += "<b>" + item.Text + "</b><br>";
        }
    }

    protected void btnChoice_Click(object sender, EventArgs e)
    {
        lblStatus.Text = "Вие го одбравте градот: \n<b>";
        lblStatus.Text += lstTowns.SelectedItem.Text;
        lblStatus.Text += "</b>";
        lblStatus.Text += " и тој е оддалечен <b>" + lstTowns.SelectedItem.Value;
        lblStatus.Text += "</b> од вас.";
    }
}