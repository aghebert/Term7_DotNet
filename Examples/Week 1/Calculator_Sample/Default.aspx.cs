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

    protected void btn1_Click(object sender, EventArgs e)
    {
        txtLCD.Text += btn1.Text;
    }


    protected void btn2_Click1(object sender, EventArgs e)
    {
        txtLCD.Text += btn2.Text;

    }
    protected void btn3_Click1(object sender, EventArgs e)
    {
        txtLCD.Text += btn3.Text;

    }
    protected void btnPlus_Click(object sender, EventArgs e)
    {
        //Store LCD in Num1
        lblNum1.Text = txtLCD.Text;

        //Clear the LCD
        txtLCD.Text = "";

        //Store the operator
        lblOperator.Text = "+";

    }





    protected void btnEquals_Click(object sender, EventArgs e)
    {
        //Store the second #
        lblNum2.Text = txtLCD.Text;

        //Clear the LCD
        txtLCD.Text = "";

        //Calculate the sum
        double num1, num2, answer=0;

        //Convert to numers from strings
        num1 = Convert.ToInt32(lblNum1.Text);
        num2 = Convert.ToInt32(lblNum2.Text);

        if (lblOperator.Text == "+")
        {
            answer = num1 + num2;
        }

        //Place answer in textbox
        txtLCD.Text = answer.ToString();

    }
}
