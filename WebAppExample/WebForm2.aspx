<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebAppExample.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:BulletedList ID="BulletedList1" runat="server">
                <asp:ListItem>opcja1</asp:ListItem>
                <asp:ListItem>opcja2</asp:ListItem>
                <asp:ListItem>opcja3</asp:ListItem>
            </asp:BulletedList>
        </div>
        <div>
            <asp:CheckBox ID="CheckBox1" runat="server" Text ="Stawka vat 23%" Checked="True" />
        </div>
        <div>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" TextAlign="Left">
                <asp:ListItem Value="a">opcja a</asp:ListItem>
                <asp:ListItem Value="b">opcja b</asp:ListItem>
                <asp:ListItem Selected="True" Value="c">opcja c</asp:ListItem>
                <asp:ListItem Value="d">opcja d</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <div>
            <asp:TextBox ID="TextBox1" runat="server" Width="400px"></asp:TextBox>
        </div>
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem Value="red">czerwony</asp:ListItem>
                <asp:ListItem Value="green">zielony</asp:ListItem>
                <asp:ListItem Value="blue">niebieski</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            <asp:Image ID="Image1" runat="server" Height="236px" ImageUrl="~/Content/zameczek1.jpg" Width="335px" />
        </div>
        <div>
            <asp:ListBox ID="ListBox1" runat="server" Rows="10">
                <asp:ListItem Value="0">stawka 0</asp:ListItem>
                <asp:ListItem Value="8">stawka 8</asp:ListItem>
                <asp:ListItem Value="23">stawka 23</asp:ListItem>
            </asp:ListBox>
        </div>
        <div>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Value="rb">RobertB</asp:ListItem>
                <asp:ListItem Value="ad">AndrzejD</asp:ListItem>
                <asp:ListItem Value="rt">RafałT</asp:ListItem>
            </asp:RadioButtonList>
        </div>

        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Button ID="Button1" runat="server" Text="Wyślij" />
        </div>
    </form>
</body>
</html>
