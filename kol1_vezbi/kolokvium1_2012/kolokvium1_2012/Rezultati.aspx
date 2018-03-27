<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Rezultati.aspx.cs" Inherits="Rezultati" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rezultati | Kol1</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            margin-left: 0px;
        }
        .auto-style4 {
            width: 191px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">
                        <asp:ListBox ID="lstPredmeti" runat="server" AutoPostBack="True" Height="79px" OnSelectedIndexChanged="lstPredmeti_SelectedIndexChanged" Width="191px"></asp:ListBox>
                    </td>
                    <td>
                        <asp:ListBox ID="lstGlasovi" runat="server" CssClass="auto-style3" Height="79px" Width="40px"></asp:ListBox>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
