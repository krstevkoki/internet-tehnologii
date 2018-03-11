<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Example 2</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            margin-left: 0px;
        }
        .auto-style3 {
            width: 210px;
        }
        .auto-style4 {
            width: 210px;
            height: 32px;
        }
        .auto-style5 {
            height: 32px;
        }
        .auto-style6 {
            width: 172px;
        }
        .auto-style7 {
            width: 172px;
            height: 32px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">Корисник:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtKorisnik" runat="server" ToolTip="Внесете го вашето име"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtKorisnik" ErrorMessage="Морате да го внесете вашето име" Font-Bold="True" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Лозинка:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtLozinka" runat="server" CssClass="auto-style2" TextMode="Password" ToolTip="Внесете ја вашата лозинка"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLozinka" ErrorMessage="Морате да ја внесете вашата лозинка" Font-Bold="True" Font-Size="Smaller" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Потврди лозинка:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtPotvrdi" runat="server" TextMode="Password" ToolTip="Потврдете ја лозинката"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtLozinka" ControlToValidate="txtPotvrdi" ErrorMessage="Лозинките не се исти" Font-Bold="True" Font-Size="Smaller" ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Button ID="btnSuccess" runat="server" OnClick="btnSuccess_Click" Text="Готово" />
                        <asp:Label ID="lblSuccess" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
