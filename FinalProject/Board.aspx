<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Board.aspx.cs" Inherits="FinalProject.Board" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<style type="text/css">
    #DIV2{
    border:2px green solid;
    }
</style>
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="DIV2" style="float:left; height: 599px; width: 160px;">您好!<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        信箱:<br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        地址:<br />
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        性別:<br />
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        手機:<br />
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="登出" />
        </div>
    <div id="DIV2" style="float:left; width: 1034px;">
        留言板:<br />
        <asp:TextBox ID="TextBox1" runat="server" Height="425px" TextMode="MultiLine" Width="998px" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
        _______________________________________________________________________________________________________________<br />
        <br />
        你想說什麼:<br />
        <asp:TextBox ID="TextBox2" runat="server" Height="35px" Width="998px"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="送出留言" />
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
