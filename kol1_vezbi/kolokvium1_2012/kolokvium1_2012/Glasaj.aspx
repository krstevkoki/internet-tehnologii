<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Glasaj.aspx.cs" Inherits="Glasaj" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Glasaj | Kol1</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 188px;
        }
        .auto-style3 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td colspan="2">
                        <asp:Image ID="imgLogoFinki" runat="server" Height="100px" ImageUrl="~/finki-logo.jpeg" Width="231px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblProfesor" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:ListBox ID="lstPredmeti" runat="server" AutoPostBack="True" Height="79px" OnSelectedIndexChanged="lstPredmeti_SelectedIndexChanged" Width="191px"></asp:ListBox>
                    </td>
                    <td>
                        <asp:ListBox ID="lstKrediti" runat="server" CssClass="auto-style3" Height="79px" Width="40px"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnGlasaj" runat="server" OnClick="btnGlasaj_Click" Text="Гласајте" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
