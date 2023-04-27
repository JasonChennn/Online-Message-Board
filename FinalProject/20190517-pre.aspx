<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="20190517-pre.aspx.cs" Inherits="FinalProject._20190517_pre" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 24px;
        }
        .auto-style2 {
            height: 24px;
            width: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 28%;">
            <tr>
                <td class="auto-style2">帳號</td>
                <td class="auto-style1"><%Response.Write(Request.Form["TextBox1"]);%></td>
                
            </tr>
            <tr>
                <td class="auto-style2">email</td>
                <td><%Response.Write(Request.Form["TextBox4"]);%></td>
              
            </tr>
            <tr>
                <td class="auto-style2">phone</td>
                <td><%Response.Write(Request.Form["TextBox5"]);%></td>
             
            </tr>
        </table>
        <br />
       
        <asp:Button ID="Button1" runat="server" PostBackUrl="~/20190517-pro.aspx" Text="Button" />
       
        <br />
    
    </div>
    </form>
</body>
</html>
