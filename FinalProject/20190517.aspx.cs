using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class _20190517 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["url"] = "register";
            Response.Cookies["userName"].Value = "CTHUANG";
            Response.Cookies["userName"].Expires = DateTime.Now.AddDays(1);
            //****
            HttpCookie aCookie = new HttpCookie("lastVisit");
            aCookie.Value = DateTime.Now.ToString();
            aCookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(aCookie);

            string path1, path2;
            path1 = Request.ServerVariables["PATH_INFO"];
            Response.Write("相對路徑:" + path1);

            path2 = Server.MapPath(path1);
            Response.Write("絕對路徑:" + path2);

            string newDir = Server.MapPath("file\\cthuang");
            Directory.CreateDirectory(newDir);
            Response.Write("DONE");

            string fileName = Server.MapPath("demo.txt");
            FileInfo file = new FileInfo(fileName);
            file.CreateText();
            Response.Write("DONE");
        }
    }
}