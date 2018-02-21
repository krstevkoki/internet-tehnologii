<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtLozinka" runat="server" TextMode="Password"></asp:TextBox>
            <asp:TextBox ID="txtPoraka" runat="server" AutoPostBack="True" OnTextChanged="txtPoraka_TextChanged" ReadOnly="True" Rows="5" TextMode="MultiLine"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="btnProveri" runat="server" OnClick="btnProveri_Click" Text=" Провери" />
            <asp:Button ID="btnPrvaStrana" runat="server" Enabled="False" PostBackUrl="~/Default.aspx" Text="Прва Страна" />
        </p>
    </form>
</body>
</html>
