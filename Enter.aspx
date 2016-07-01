<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Enter.aspx.cs" Inherits="WebApplicationSportSearch.Enter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" ForeColor="#FF3300"></asp:Label>
        <br />
        <br />
        Логин<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Пароль<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Вход" />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
