using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class login_succeed : System.Web.UI.Page
    {
        private static int time = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                time = 0;
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            time++;
            Label1.Text = (3 - time).ToString();
            if (time > 2)
                Response.Redirect("Board.aspx");
        }
    }
}