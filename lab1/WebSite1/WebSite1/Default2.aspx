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
            height: 90px;
        }
        .auto-style3 {
            height: 90px;
            width: 1193px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table align="center" class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Panel ID="pnlPanela" runat="server" BackColor="#66FF33" Font-Names="Arial">
                        <asp:TextBox ID="txtOperand1" runat="server" EnableViewState="False"></asp:TextBox>
                        <asp:TextBox ID="txtOperand2" runat="server" AutoPostBack="True" OnTextChanged="txtOperand2_TextChanged"></asp:TextBox>
                        <asp:Button ID="btnSoberi" runat="server" OnClick="btnSoberi_Click" style="margin-bottom: 0px" Text="Soberi" />
                        <br />
                        <asp:Label ID="lblRezultat" runat="server" EnableViewState="False"></asp:Label>
                    </asp:Panel>
                </td>
                <td class="auto-style2">
                    <asp:CheckBox ID="chbVidlivo" runat="server" AutoPostBack="True" Checked="True" OnCheckedChanged="chbVidlivo_CheckedChanged" Text="Видливо" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
