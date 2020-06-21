<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebAppExample.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b>To jest strona w ASP.NET</b>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" BorderStyle ="Dotted" Text="kontrolka label" ForeColor="Green"></asp:Label>
        </div>
        <div>
            <p>Informacja na temat requestu:</p>
            <asp:Label ID="lblInfo" runat="server" Text="Label" Font-Size="Large"></asp:Label>
        </div>
        <div>
            Podaj imię: <asp:TextBox ID="tbName" Width =" 200" runat="server" ToolTip="bla bla bla" BackColor="Aqua"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="btnOk" runat="server" Text="Pokaz imię" OnClick="btnOk_Click" />
        </div>
    </form>
</body>
</html>
