using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["Logined"] == "true") //檢測若已經做過登入,就不需要再登入一次
                {
                    Response.Redirect("Board.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "")
                Response.Write("帳號或密碼不得為空!");
            else
            {
                string constr = "Data Source = localhost; port= 3306; Initial Catalog= asp; " +
                    "User Id = oit; password = oitmis";

                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM member WHERE mem_account = '" + TextBox1.Text + "' AND mem_password = '" + TextBox2.Text + "'");
                    cmd.Connection = con;
                    MySqlDataReader data = cmd.ExecuteReader();
                    ArrayList accountData = new ArrayList();
                    if (data.HasRows == true)
                    {
                        while (data.Read())
                        {
                            //透過讀取到的資料庫寫到ArrayList透過Session傳到下個頁面
                            accountData.Add(data.GetString("mem_account"));
                            accountData.Add(data.GetString("mem_password"));
                            accountData.Add(data.GetString("mem_nickname"));
                            accountData.Add(data.GetString("mem_email"));
                            accountData.Add(data.GetString("mem_address"));
                            accountData.Add(data.GetString("mem_gender"));
                            accountData.Add(data.GetString("mem_phone"));
                            Session["accountData"] = accountData;
                            Session["Logined"] = "true";
                            Response.Redirect("login-succeed.aspx");
                        }
                    }
                    else
                    {
                        Response.Write("帳號或密碼有誤!");
                    }
                    data.Close();
                    con.Close();
                }
            }
        }
    }
}