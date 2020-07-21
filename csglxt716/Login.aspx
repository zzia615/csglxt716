<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="csglxt716.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="t_code" runat="server"></asp:TextBox>
            <asp:TextBox ID="t_pwd" TextMode="Password" runat="server"></asp:TextBox>
            <asp:Button ID="b_login" runat="server" Text="登录" OnClick="b_login_Click"/>
        </div>
    </form>
</body>
</html>
