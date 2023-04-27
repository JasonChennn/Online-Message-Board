<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="FinalProject.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server">
            帳號:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            密碼:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="登入" />
            &nbsp;<asp:Button ID="Button2" runat="server" PostBackUrl="~/register.aspx" Text="註冊" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
