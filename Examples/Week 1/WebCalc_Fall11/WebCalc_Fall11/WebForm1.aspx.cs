using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCalc_Fall11
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the current date and time from the server
            // and place it within the text of the label
            lblTime.Text = DateTime.Now.ToString();
        }
    }
}