<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="webservice.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        杏德科技網頁測試</div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 27px" Text="Button" />
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        帳號<asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        密碼<asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <asp:Button ID="register" runat="server" OnClick="regsiter" style="height: 27px" Text="註冊" />
        <br />
        <br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </form>
</body>
</html>
