//Aaron Hebert
//SE256 - 05
//Lab 1
//10/13/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Text.RegularExpressions;

public partial class _Default : System.Web.UI.Page
{
    void Page_Load()
    {
        if (Session["Memory"] != null && Convert.ToString(Session["Memory"]) != "")
        {
            
            TextSpecial.Text = "M " + Convert.ToString(Session["Memory"]);
        } else
        {

        }
    }

    protected void TextLCD_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Text_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        TextLCD.Text = TextLCD.Text + Button1.Text;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextLCD.Text = TextLCD.Text + Button2.Text;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        TextLCD.Text = TextLCD.Text + Button3.Text;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        TextLCD.Text = TextLCD.Text + Button4.Text;
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        TextLCD.Text = TextLCD.Text + Button5.Text;
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        TextLCD.Text = TextLCD.Text + Button6.Text;
    }

<<<<<<< HEAD
    protected void Button7_Click(object sender, EventArgs e)
    {
        TextLCD.Text = TextLCD.Text + Button7.Text;
    }
=======
        int num = 0;
        if (Int32.TryParse(string e.CommandArgument, num) == true)
        {
            //tempstr is the current number being "typed" into the display
            tempStr += Convert.ToString(num);
            //outputs the newest tempStr to txtLCD.Text
            txtLCD.Text = tempStr;
            
        }

        switch (e.CommandName)
        {
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "0":
               



            case "-":
                break;
        }
>>>>>>> 4e8482df42c57aa0b845fde16f0e8a5ecff12894

    protected void Button8_Click(object sender, EventArgs e)
    {
        TextLCD.Text = TextLCD.Text + Button8.Text;
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        TextLCD.Text = TextLCD.Text + Button9.Text;
    }

    protected void Button0_Click(object sender, EventArgs e)
    {
        TextLCD.Text = TextLCD.Text + Button0.Text;
    }

    protected void ButtonDiv_Click(object sender, EventArgs e)
    {
        double temp1 =/ Convert.ToDouble(TextLCD.Text);
        Session["total"] = Convert.ToString(temp1);
        TextLCD.Text = "";
    }

    protected void ButtonMulti_Click(object sender, EventArgs e)
    {
        double temp1 = double temp1 * Convert.ToDouble(TextLCD.Text);
        Session["total"] = Convert.ToString(temp1);
        TextLCD.Text = "";
    }

    protected void ButtonSub_Click(object sender, EventArgs e)
    {
        double temp1 =- Convert.ToDouble(TextLCD.Text);
        Session["total"] = Convert.ToString(temp1);
        TextLCD.Text = "";
    }

    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
       double temp1 =+ Convert.ToDouble(TextLCD.Text);
        Session["total"] = Convert.ToString(temp1);
        TextLCD.Text = "";
    }

    protected void ButtonMS_Click(object sender, EventArgs e)
    {
        Session["Memory"] = TextLCD.Text;
        TextSpecial.Text = "M " + TextLCD.Text;
    }

    protected void ButtonMR_Click(object sender, EventArgs e)
    {
        TextLCD.Text = Convert.ToString(Session["Memory"]);
    }

    protected void ButtonMC_Click(object sender, EventArgs e)
    {
        Session["Memory"] = "";
        TextSpecial.Text = "";
    }

    protected void ButtonEquals_Click(object sender, EventArgs e)
    {
        string total = Convert.ToString(Session["total"]);
       

        if (String.IsNullOrEmpty(TextLCD.Text)|| String.IsNullOrEmpty(total))
        {

        }
        else
        {
double temp1 = Convert.ToDouble(total);
            double temp2 = temp1 + Convert.ToDouble(TextLCD.Text);
            TextLCD.Text = Convert.ToString(temp2);
            Session["total"] = "";
        }
    }

    protected void ButtonDecimal_Click(object sender, EventArgs e)
    {
        if (Regex.IsMatch(TextLCD.Text, @"([.])"))
        {

        }
        else
        {
            TextLCD.Text = TextLCD.Text + ".";
        }
    }

    protected void ButtonClear_Click(object sender, EventArgs e)
    {
        TextLCD.Text = "";
        Session["total"] = "";
    }
}
