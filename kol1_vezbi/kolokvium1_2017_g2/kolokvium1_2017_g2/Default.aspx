<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kolokvium1 | Internet Tehnologii</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 179px;
        }
        .auto-style4 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblIme" runat="server" Text="Корисничко име:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="validatorIme" runat="server" ControlToValidate="txtIme" ErrorMessage="внесете корисничко име" Font-Bold="True" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblLozinka" runat="server" Text="Лозинка:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtLozinka" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="validatorLozinka" runat="server" ControlToValidate="txtLozinka" ErrorMessage="внесете лозинка" Font-Bold="True" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="validatorEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="невалидна e-mail адреса" Font-Bold="True" Font-Size="Smaller" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnNajava" runat="server" OnClick="btnNajava_Click" Text="Најави се" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td rowspan="2">
                        <asp:Image ID="imgLogo" runat="server" Height="200px" ImageAlign="Left" ImageUrl="~/the-movies-logo.gif" Width="200px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:ListBox ID="lstZanrovi" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lstZanrovi_SelectedIndexChanged">
                            <asp:ListItem>Драма</asp:ListItem>
                            <asp:ListItem>Комедија</asp:ListItem>
                            <asp:ListItem>Акција</asp:ListItem>
                        </asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" rowspan="3">
                        <asp:CheckBoxList ID="chkFilmovi" runat="server" AutoPostBack="True" OnSelectedIndexChanged="chkFilmovi_SelectedIndexChanged">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtKolicina1" runat="server" OnTextChanged="txtKolicina1_TextChanged" AutoPostBack="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtKolicina2" runat="server" AutoPostBack="True" OnTextChanged="txtKolicina2_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtKolicina3" runat="server" AutoPostBack="True" OnTextChanged="txtKolicina3_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="2">
                        <asp:Button ID="btnKupi" runat="server" CausesValidation="False" OnClick="btnKupi_Click" Text="Купи" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblCena" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
