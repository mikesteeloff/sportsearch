<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WebApplicationSportSearch.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 291px; width: 1121px">
    
        <asp:Label ID="Label1" runat="server" Text="Имя"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Фамилия"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Возраст"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Вес"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="КолТравм"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="Соревнование"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Добавить" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" Width="618px">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="Имя" HeaderText="Имя" SortExpression="Имя" />
                <asp:BoundField DataField="Фамилия" HeaderText="Фамилия" SortExpression="Фамилия" />
                <asp:BoundField DataField="Возраст" HeaderText="Возраст" SortExpression="Возраст" />
                <asp:BoundField DataField="Вес" HeaderText="Вес" SortExpression="Вес" />
                <asp:BoundField DataField="КолТравм" HeaderText="КолТравм" SortExpression="КолТравм" />
                <asp:BoundField DataField="Соревнование" HeaderText="Соревнование" SortExpression="Соревнование" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SportSearchConnectionString %>" DeleteCommand="DELETE FROM [MainSport] WHERE [ID] = @ID" InsertCommand="INSERT INTO [MainSport] ([ID], [Имя], [Фамилия], [Возраст], [Вес], [КолТравм], [Соревнование]) VALUES (@ID, @Имя, @Фамилия, @Возраст, @Вес, @КолТравм, @Соревнование)" SelectCommand="SELECT * FROM [MainSport]" UpdateCommand="UPDATE [MainSport] SET [Имя] = @Имя, [Фамилия] = @Фамилия, [Возраст] = @Возраст, [Вес] = @Вес, [КолТравм] = @КолТравм, [Соревнование] = @Соревнование WHERE [ID] = @ID">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ID" Type="Int32" />
                <asp:Parameter Name="Имя" Type="String" />
                <asp:Parameter Name="Фамилия" Type="String" />
                <asp:Parameter Name="Возраст" Type="Int32" />
                <asp:Parameter Name="Вес" Type="Int32" />
                <asp:Parameter Name="КолТравм" Type="Int32" />
                <asp:Parameter Name="Соревнование" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Имя" Type="String" />
                <asp:Parameter Name="Фамилия" Type="String" />
                <asp:Parameter Name="Возраст" Type="Int32" />
                <asp:Parameter Name="Вес" Type="Int32" />
                <asp:Parameter Name="КолТравм" Type="Int32" />
                <asp:Parameter Name="Соревнование" Type="String" />
                <asp:Parameter Name="ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
