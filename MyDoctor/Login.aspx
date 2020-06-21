<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MyDoctor.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>logowanie</h3>

    <table class="table">
        <tr>
            <td>
                login
            </td>
            <td>
                <asp:TextBox ID="tbLogin" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                hasło
            </td>
            <td>
                <asp:TextBox ID="tbPassword" textmode="Password" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblResult" runat="server" froecolor="red" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnLogin" runat="server" Text="Loguj" OnClick="btnLogin_Click" />
            </td>
        </tr>
    </table>



</asp:Content>
