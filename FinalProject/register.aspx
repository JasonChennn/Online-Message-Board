<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="FinalProject.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        帳號:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        密碼:<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        確認密碼:<asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        暱稱:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        信箱:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="你的信箱不符合格式!" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        地址:<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        性別:<asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True">
            <asp:ListItem>男</asp:ListItem>
            <asp:ListItem>女</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        電話:<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="完成註冊" />
&nbsp;<asp:Button ID="Button2" runat="server" Text="取消註冊" PostBackUrl="~/main.aspx" />
    
    </div>
    </form>
</body>
</html>
