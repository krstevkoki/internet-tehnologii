<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 459px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Валута</td>
                    <td>
                        <asp:TextBox ID="txtValuta" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Вредност</td>
                    <td>
                        <asp:TextBox ID="txtVrednost" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Додади" />
                    </td>
                    <td>
                        <asp:Button ID="btnOtstrani" runat="server" OnClick="btnOtstrani_Click" Text="Отстрани" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:RadioButtonList ID="rblValuti" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rblValuti_SelectedIndexChanged">
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblStatus" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtKonverzija" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblValuta" runat="server"></asp:Label>
                        =
                        <asp:Label ID="lblKonverzija" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
