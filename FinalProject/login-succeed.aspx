<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login-succeed.aspx.cs" Inherits="FinalProject.login_succeed" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        登入成功!<br />
        倒數<asp:Label ID="Label1" runat="server" Text="3"></asp:Label>
        秒後<br />
        將自動前往留言板...</div>
        <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
        </asp:Timer>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </form>
</body>
</html>
