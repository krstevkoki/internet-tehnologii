<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Vezba1</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 84px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1" align="center">
            <tr>
                <td>Градови:</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:ListBox ID="lstTowns" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lstTowns_SelectedIndexChanged" SelectionMode="Multiple">
                        <asp:ListItem Value="0km">Скопје</asp:ListItem>
                        <asp:ListItem Value="40km">Куманово</asp:ListItem>
                        <asp:ListItem Value="100km">Пробиштип</asp:ListItem>
                        <asp:ListItem Value="99km">Неготино</asp:ListItem>
                    </asp:ListBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnChoice" runat="server" OnClick="btnChoice_Click" Text="Избери" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblStatus" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    Ги имате избрано следните градови:</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSelectedTowns" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
