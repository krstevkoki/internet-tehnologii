<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>Валута</td>
                    <td>
                        <asp:TextBox ID="txtValuta" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Вредност</td>
                    <td>
                        <asp:TextBox ID="txtVrednost" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Додади" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:RadioButtonList ID="rblValuti" runat="server">
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
