<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Example</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 233px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Име на испит</td>
                    <td>
                        <asp:TextBox ID="txtIspit" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtIspit" ErrorMessage="Внесете испит" Font-Bold="True" Font-Size="Smaller" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Добиена оцена</td>
                    <td>
                        <asp:TextBox ID="txtOcena" runat="server"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtOcena" ErrorMessage="Внесете оцена 5-10" Font-Bold="True" Font-Size="Smaller" ForeColor="Red" MaximumValue="10" MinimumValue="5" Type="Integer" Display="None"></asp:RangeValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtOcena" ErrorMessage="Внесете оцена" Font-Bold="True" Font-Size="Smaller" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Датум на полагање</td>
                    <td>
                        <asp:TextBox ID="txtDatum" runat="server" ToolTip="Формат: YYYY-MM-DD"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtDatum" ErrorMessage="Датумот треба да е пред 2007-10-05 " Font-Bold="True" Font-Size="Smaller" ForeColor="Red" Operator="LessThan" Type="Date" ValueToCompare="2007-10-05" Display="None"></asp:CompareValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDatum" ErrorMessage="Внесете датум на полагање" Font-Bold="True" Font-Size="Smaller" ForeColor="Red" Display="None"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtDatum" Display="None" ErrorMessage="Невалиден формат" Font-Bold="True" Font-Size="Smaller" ForeColor="Red" ValidationExpression="\d{4}-\d{2}-\d{2}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnSuccess" runat="server" OnClick="btnSuccess_Click" Text="Внеси" />
                        <asp:Label ID="lblSuccess" runat="server" ForeColor="#009933"></asp:Label>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="Red" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
