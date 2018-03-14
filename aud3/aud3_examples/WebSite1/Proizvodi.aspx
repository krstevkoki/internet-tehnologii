<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Proizvodi.aspx.cs" Inherits="Proizvodi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Proizvodi | Example</title>
    <style type="text/css">
        .auto-style1 {
            width: 38%;
        }
        .auto-style2 {
            width: 525px;
        }
        .auto-style3 {
            margin-top: 0px;
        }
        .auto-style4 {
            margin-left: 54px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="3" style="text-align: center">
                        <asp:Label ID="lblKategorija" runat="server" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2" style="text-align: center">
                        <asp:Label ID="lblKategorijaTekst" runat="server" Font-Bold="True">Производи</asp:Label>
                    </td>
                    <td style="text-align: center">
                        <asp:Label ID="lblCeniTekst" runat="server" Font-Bold="True">Цени</asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:ListBox ID="lstProizvodi" runat="server" AutoPostBack="True" Height="224px" OnSelectedIndexChanged="lstProizvodi_SelectedIndexChanged" Width="470px"></asp:ListBox>
                    </td>
                    <td>
                        <asp:ListBox ID="lstCeni" runat="server" CssClass="auto-style3" Height="222px" Width="117px"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HyperLink ID="hlKatalog" runat="server" NavigateUrl="~/Katalog.aspx">Каталог</asp:HyperLink>
                    </td>
                    <td>
                        <asp:Button ID="btnDodadi" runat="server" CssClass="auto-style4" OnClick="btnDodadi_Click" Text="Додади во кошничка" Width="253px" />
                    </td>
                    <td>
                        <asp:Label ID="lblBrPromeni" runat="server" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:ListBox ID="lstKosnicka" runat="server" Height="224px" Width="470px"></asp:ListBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3" style="text-align: center">
                        <asp:Button ID="btnKupi" runat="server" OnClick="btnKupi_Click" Text="Купи" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
