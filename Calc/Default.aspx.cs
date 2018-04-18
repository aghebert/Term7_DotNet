using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

public partial class _Default : System.Web.UI.Page
{

    public static double tempNum = 0;
    public static string tempStr = "";

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void btnNum_Click(object sender, CommandEventArgs e)
    {
        tempStr += Convert.ToString(e.CommandArgument);
        txtLCD.Text += tempStr;
    }

    public void btnPlus_Click(object sender, EventArgs e)
    {
       
        tempNum += Convert.ToDouble(tempStr);
       txtLCD.Text += " + ";
    }

    protected void btnEquals_Click(object sender, EventArgs e)
    {

    }

    protected void txtLCD_TextChanged(object sender, EventArgs e)
    {
        
    }



    protected void btnDivide_Click(object sender, EventArgs e)
    {

    }

    protected void btnMulti_Click(object sender, EventArgs e)
    {

    }

    protected void btnSub_Click(object sender, EventArgs e)
    {

    }
}