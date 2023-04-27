using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace FinalProject
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            Label1.Text = "";
            Label1.ForeColor = Color.Red;
            RegularExpressionValidator1.ForeColor = Color.Red;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == ""
                 || TextBox5.Text == "" || TextBox6.Text == "" || TextBox7.Text == "") { Label1.Text = "你尚有欄位為空!"; }
            else if(TextBox1.Text.Length > 20)
                Label1.Text = "你的帳號太長了!";
            else if (TextBox2.Text.Length > 20)
                Label1.Text = "你的密碼太長了!";
            else if (TextBox2.Text != TextBox3.Text)
                Label1.Text = "你的密碼與確認密碼不符!";
            else if (TextBox4.Text.Length > 20)
                Label1.Text = "你的暱稱太長了!";
            else if (TextBox5.Text.Length > 50)
                Label1.Text = "你的信箱太長了!";
            else if (TextBox6.Text.Length > 50)
                Label1.Text = "你的地址太長了!";
            else if (TextBox7.Text.Length != 10)
                Label1.Text = "你的電話長度有誤!";
            else if (RadioButtonList1.SelectedIndex == -1)
                Label1.Text = "你沒有選擇性別!";
            else
            {
                string constr = "Data Source = localhost; port= 3306; Initial Catalog= asp; " +
                    "User Id = oit; password = oitmis";

                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    //這邊的性別是直接抓RadioButton的index
                    string sql = "INSERT INTO member (mem_id, mem_account, mem_password, mem_nickname, mem_email, mem_address, mem_gender, mem_phone) " +
                    "VALUES (NULL, '" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox4.Text + "', '" + 
                    TextBox5.Text + "', '" + TextBox6.Text + "', '" + RadioButtonList1.SelectedIndex.ToString() + "', '" +
                    TextBox7.Text + "');";

                    con.Open();

                    using (MySqlCommand cmd = new MySqlCommand(sql))
                    {
                        cmd.Connection = con;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                    con.Close();
                    Response.Redirect("register-succeed.aspx");
                }
            }
        }
    }
}