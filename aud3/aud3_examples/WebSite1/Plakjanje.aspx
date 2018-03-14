<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Plakjanje.aspx.cs" Inherits="Plakjanje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Plakjanje | Example</title>
    <style type="text/css">
        .auto-style1 {
            width: 37%;
        }
        .auto-style2 {
            width: 91px;
        }
        .auto-style3 {
            height: 226px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblSodrzina" runat="server" Font-Bold="True" Text="Содржина на купувачката кошничка"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">
                        <asp:ListBox ID="lstKosnicka" runat="server" Height="222px" Width="541px"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblVkupno" runat="server" Font-Bold="True" Text="Вкупно:"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblVkupnoDenari" runat="server" Font-Bold="True"></asp:Label>
&nbsp;денари.</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
