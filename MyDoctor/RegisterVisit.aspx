<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterVisit.aspx.cs" Inherits="MyDoctor.RegisterVisit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <script 
        src="https://cdnjs.cloudflare.com/ajax/libs/jquery.mask/1.14.16/jquery.mask.js">
    </script>

    <script type="text/javascript">
        $(function () {
            //$("#mainContent_tbPesel").mask("99999999999"); --nazwa kontrolki po stronie html
            $("#<%=tbPesel.ClientID%>").mask("99999999999"); //nazwa kontrolki po stronie asp.net
        });
    </script>

    <h3>Nowa wizyta</h3>

    <table border="0" class="table">
        <tr>
            <td>
                Imię

            </td>
            <td>
                <asp:TextBox ID="tbFName" Width="200" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator1" 
                    Display ="Dynamic" 
                    ForeColor="Red" 
                    runat="server" 
                    ErrorMessage="Podaj imię" 
                    ControlToValidate="tbFname">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                Nazwisko

            </td>
            <td>
                <asp:TextBox ID="tbLName" Width="200" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator2" 
                    Display ="Dynamic" 
                    ForeColor="Red" 
                    runat="server" 
                    ErrorMessage="Podaj nazwisko" 
                    ControlToValidate="tbLname">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                Pesel
                
            </td>
            <td>
                <asp:TextBox ID="tbPesel" Width="200" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator4" 
                    Display ="Dynamic" 
                    ForeColor="Red" 
                    runat="server" 
                    ErrorMessage="Podaj PESEL" 
                    ControlToValidate="tbPesel">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                Email

            </td>
            <td>
                <asp:TextBox ID="tbMail" Width="200" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator 
                    ID="RegularExpressionValidator1"
                    controlToValidate="tbmail"
                    ForeColor ="Red"
                    runat="server" 
                    Display ="Dynamic"
                    validationexpression ="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ErrorMessage="Podaj Email">*
                </asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator 
                    ID="RequiredFieldValidator3" 
                    Display ="Dynamic" 
                    ForeColor="Red" 
                    runat="server" 
                    ErrorMessage="Podaj Email" 
                    ControlToValidate="tbmail">*
                </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                Lekarz

            </td>
            <td>
                <asp:DropDownList ID="ddDoctor" runat="server">
                    <asp:ListItem Value="-1">-----</asp:ListItem>
                    <asp:ListItem Value="1">Jan Kowalski - pediatra</asp:ListItem>
                    <asp:ListItem Value="2">Jarosław Ziętek - Dermatolog</asp:ListItem>
                    <asp:ListItem Value="3">Adam Nowak - Kardiolog</asp:ListItem>
                </asp:DropDownList>
                <asp:RangeValidator 
                    ID="RangeValidator1" 
                    runat="server" 
                    ForeColor ="RED"
                    ErrorMessage="Wybierz Lekarza"
                    ControlToValidate="ddDoctor" Type="Integer" MinimumValue="1" MaximumValue="999999">*
                </asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td>
                Data wizyty

            </td>
            <td>
                <asp:Calendar ID="calVisitDate" runat="server" Height="200px" ShowGridLines="True" Width="300px"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td>
                Client VIP

            </td>
            <td>
                <asp:CheckBox ID="cbVip" runat="server" AutoPostBack="True" OnCheckedChanged="cbVip_CheckedChanged" />
                <br />
                <asp:TextBox ID="tbVipNumber" Visible="false" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td colspan="2">
                <asp:ValidationSummary ID="ValidationSummary1" ForeColor="Red" runat="server" />
            </td>

        </tr>


        <tr>
            <td colspan="2">
                <asp:Button ID="btnOk" runat="server" Text="Zapisz na wizytę" OnClick="btnOk_Click" />
            </td>
        </tr>
    </table>

</asp:Content>
