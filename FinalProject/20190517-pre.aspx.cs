using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class _20190517_pre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["url"] != "register")
            {
                Response.Redirect("20190517.aspx");
            }
            else
            {
                Session["url"] = "register-pre";
            }
            ArrayList profile = new ArrayList();
            profile.Add(Request.Form["TextBox1"]);
            profile.Add(Request.Form["TextBox2"]);
            profile.Add(Request.Form["TextBox4"]);
            profile.Add(Request.Form["TextBox5"]);
            Session["profile"] = profile;
        }
    }
}