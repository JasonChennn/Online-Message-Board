<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register-succeed.aspx.cs" Inherits="FinalProject.register_succeed" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        註冊完成!<br />
        倒數<asp:Label ID="Label1" runat="server" Text="3"></asp:Label>
        秒後<br />
        將自動前往登入頁面...</div>
        <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick">
        </asp:Timer>
    <asp:ScriptManager ID="ScriptManager" runat="server">
    </asp:ScriptManager>
    </form>
</body>
</html>
