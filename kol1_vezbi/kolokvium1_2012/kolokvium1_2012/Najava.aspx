<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Najava.aspx.cs" Inherits="Najava" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Najava | Kol1</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 326px;
        }
        .auto-style3 {
            margin-left: 0px;
        }
        .auto-style4 {
            width: 125px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label1" runat="server" Text="Име"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="validatorIme" runat="server" ControlToValidate="txtIme" ErrorMessage="Внесете име" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label2" runat="server" Text="Лозинка"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtLozinka" runat="server" CssClass="auto-style3" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLozinka" ErrorMessage="Внесете лозинка" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label3" runat="server" Text="е-адреса"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Невалиден формат" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td colspan="2">
                        <asp:Button ID="btnNajavi" runat="server" OnClick="btnNajavi_Click" Text="Најавете се" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
