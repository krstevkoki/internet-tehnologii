<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Example 1</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            margin-left: 0px;
        }
        .auto-style3 {
            width: 228px;
        }
        .auto-style4 {
            width: 175px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
            <asp:Label ID="lblBroj" runat="server" Text="Внесете го вашиот број"></asp:Label>
                    </td>
                    <td class="auto-style4">
            <asp:TextBox ID="txtBroj" runat="server" MaxLength="9" ToolTip="Внесете го вашиот број (формат: 07XYYYZZZ)" CssClass="auto-style2"></asp:TextBox>
                    </td>
                    <td>
            <asp:RegularExpressionValidator ID="revBroj" runat="server" ControlToValidate="txtBroj" ErrorMessage="Бројот не е валиден" ValidationExpression="^07[0-35-9]\d{6}" Font-Bold="True" Font-Size="Smaller" ForeColor="Red"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
            <asp:Button ID="btnSuccess" runat="server" OnClick="btnSuccess_Click" Text="Клик" />
                        <asp:Label ID="lblSuccess" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
