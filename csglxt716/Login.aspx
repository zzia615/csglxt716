<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="csglxt716.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="jaylosy.css" rel="stylesheet" />
    <style>
        body{
            padding:0;
            background:#105f9b;
        }
        form{
            background:rgba(231, 231, 231, 0.60);
            width:600px;
            min-height:50px;
            padding:20px 15px 20px 15px;
            margin:100px auto;
            border-radius:3px;
            box-shadow:#073a61 2px 2px 1px;
        }
        h1{
            padding:10px 0;
            color:#ffffff;
            -webkit-box-reflect: below -25px
            -webkit-gradient(linear,left top,left bottom, from(rgba(0,0,0,0)),to(rgba(255,255,255,0.4)));
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>欢迎登录-超市管理系统</h1>
        </div>
        <div>
            <asp:TextBox CssClass="input" ID="t_code" placeholder="请输入账号" runat="server"></asp:TextBox>
            <asp:TextBox CssClass="input" ID="t_pwd" placeholder="请输入密码"  TextMode="Password" runat="server"></asp:TextBox>
            <asp:CheckBox ForeColor="White" ID="CheckBox1" runat="server" Text="记住我"/>
            <asp:Button CssClass="btn btn-success" ID="b_login" runat="server" Text="登录" OnClick="b_login_Click"/>
        </div>
    </form>
</body>
</html>
