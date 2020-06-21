<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditVisit.aspx.cs" Inherits="MyDoctor.EditVisit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Edycja statusu zgłoszenia</h3>

    <table border ="0" class="table">
        <tr>
        <td>Zmiana statusu</td>
            <td>
                <asp:DropDownList ID="ddlStatus" runat="server">
                    <asp:ListItem Value="0">---</asp:ListItem>
                    <asp:ListItem Value="1">Akceptacja</asp:ListItem>
                    <asp:ListItem Value="-1">Anulowano</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan ="2">
                <asp:Label ID="lblStatus" runat="server" Text="" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan ="2">
                <asp:Button ID="btnOk" runat="server" Text="Zmień status" OnClick="btnOk_Click" />
            </td>
        </tr>

        <asp:HiddenField ID="tbHiddenId" runat="server" />



    </table>



</asp:Content>
