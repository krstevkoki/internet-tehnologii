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

    protected void btnSoberi_Click(object sender, EventArgs e)
    {
        int op1 = Convert.ToInt32(txtOperand1.Text);
        int op2 = Convert.ToInt32(txtOperand2.Text);
        lblRezultat.Text = Convert.ToString(op1 + op2);
    }

    protected void chbVidlivo_CheckedChanged(object sender, EventArgs e)
    {
        if (chbVidlivo.Checked)
            pnlPanela.Visible = true;
        else
            pnlPanela.Visible = false;
    }

    protected void txtOperand2_TextChanged(object sender, EventArgs e)
    {
        int op1 = Convert.ToInt32(txtOperand1.Text);
        int op2 = Convert.ToInt32(txtOperand2.Text);
        lblRezultat.Text = Convert.ToString(op1 + op2);
    }
}