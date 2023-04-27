using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class _20190517_pro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList profile = (ArrayList)Session["profile"];
            string userName = Request.Cookies["userName"].Value;
            Response.Write(userName);
        }
    }
}