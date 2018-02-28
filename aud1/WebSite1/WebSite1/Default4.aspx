<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 17px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl="~/vosok.jpg" Width="100px" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPosition" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:ImageButton ID="imbLogo" runat="server" Height="400px" ImageUrl="~/vosok.jpg" OnClick="imbLogo_Click" Width="400px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
