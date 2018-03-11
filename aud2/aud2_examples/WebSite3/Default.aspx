<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            width: 122px;
            height: 29px;
        }
        .auto-style4 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlGradovi" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlGradovi_SelectedIndexChanged" Width="135px">
                            <asp:ListItem Selected="True">-дата-</asp:ListItem>
                            <asp:ListItem>Скопје</asp:ListItem>
                            <asp:ListItem>Битола</asp:ListItem>
                            <asp:ListItem>Охрид</asp:ListItem>
                            <asp:ListItem>Неготино</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style4">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlGradovi" ErrorMessage="Изберете град" Font-Bold="True" Font-Size="Smaller" ForeColor="Red" InitialValue="-дата-"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:Button ID="btnSuccess" runat="server" OnClick="btnSuccess_Click" Text="Регистрирај се" />
                        <asp:Label ID="lblSuccess" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
