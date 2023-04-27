using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class Board : System.Web.UI.Page
    {
        private static string userName;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if(Session["Logined"] == "true") // 檢測有無登入
                {
                    ArrayList accountData = (ArrayList)Session["accountData"]; // 透過Session取得之前資料庫所得到的帳戶資訊
                    userName = accountData[2].ToString();
                    //*******版面初始設定*******
                    Label1.Text = "";
                    Label2.Text = accountData[2].ToString();
                    Label3.Text = accountData[3].ToString();
                    Label4.Text = accountData[4].ToString();
                    if (accountData[5].ToString() == "0")
                        accountData[5] = "男";
                    else if (accountData[5].ToString() == "1")
                        accountData[5] = "女";
                    else
                        accountData[5] = "無";
                    Label5.Text = accountData[5].ToString();
                    Label6.Text = accountData[6].ToString();
                    Label1.ForeColor = Color.Red;
                    Label2.ForeColor = Color.Blue;
                    TextBox1.Font.Size = 30;
                    TextBox1.ForeColor = Color.Red;
                    //****************************
                    //MS資料庫連線
                    string constr = "Data Source = localhost; port= 3306; Initial Catalog= asp; " +
                        "User Id = oit; password = oitmis";

                    using (MySqlConnection con = new MySqlConnection(constr))
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand("SELECT * FROM message");
                        cmd.Connection = con;
                        MySqlDataReader data = cmd.ExecuteReader();
                        if (data.HasRows == true)
                        {
                            while (data.Read())
                            {
                                //先將所有的留言在第一時間貼到Textbox上
                                SendMassage(data.GetString("msg_datetime"), data.GetString("msg_author"), data.GetString("msg_content"));
                            }
                        }
                        data.Close();
                        con.Close();
                    }
                }
                else
                {
                    Response.Redirect("main.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text.Length == 0)
                Label1.Text = "你的內容不可為空!";
            else if (TextBox2.Text.Length > 1000)
                Label1.Text = "留言字數長度過長!";
            else
            {
                //每當用戶一留言,就INSERT一筆資料到資料庫裡,以便下次讀取
                SendMassage(DateTime.Now.ToLocalTime().ToString(),userName, TextBox2.Text);

                string constr = "Data Source = localhost; port= 3306; Initial Catalog= asp; " +
                    "User Id = oit; password = oitmis";

                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    string sql = "INSERT INTO message (msg_id, msg_datetime, msg_author, msg_content) " +
                    "VALUES (NULL, '" + DateTime.Now.ToLocalTime().ToString() + "', '" + userName + "', '" + TextBox2.Text + "');";

                    con.Open();

                    using (MySqlCommand cmd = new MySqlCommand(sql))
                    {
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                    con.Close();
                }
                TextBox2.Text = "";
            }
        }

        public void SendMassage(string datetime,string author,string text)
        {
            //將使用者及日期及內容貼到Textbox上
            TextBox1.Text = " → " + text + "\n" + TextBox1.Text;
            TextBox1.Text = "* " + datetime + "," + author + ":\n" + TextBox1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //登出機制,確保回到Board不會有重複登入的問題
            Session["accountData"] = null;
            Session["Logined"] = null;
            Response.Redirect("main.aspx");
        }
    }
}