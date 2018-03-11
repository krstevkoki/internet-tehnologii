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
            width: 233px;
        }
        .auto-style3 {
            width: 171px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Име на испит</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtIspit" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtIspit" ErrorMessage="Внесете испит" Font-Bold="True" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Добиена оцена</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtOcena" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtOcena" ErrorMessage="Внесете оцена 5-10" Font-Bold="True" Font-Size="Smaller" ForeColor="Red" MaximumValue="10" MinimumValue="5" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Датум на полагање</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtDatum" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtDatum" ErrorMessage="CompareValidator" Font-Bold="True" Font-Size="Smaller" ForeColor="Red" Operator="LessThan" Type="Date" ValueToCompare="2007-10-05">Датумот треба да е пред 2007-10-05 </asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Button ID="btnSuccess" runat="server" OnClick="btnSuccess_Click" Text="Внеси" />
                        <asp:Label ID="lblSuccess" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
