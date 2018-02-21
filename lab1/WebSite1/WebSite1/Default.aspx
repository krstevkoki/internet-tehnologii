<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblVreme1" runat="server" Font-Names="Arial" Font-Size="Medium" ForeColor="Navy" Text="Контрола за приказ на време"></asp:Label>
        </div>
        <asp:Label ID="lblVreme2" runat="server" Text="Label" Font-Names="Arial" Font-Size="Medium" ForeColor="Navy"></asp:Label>
        <p>
            <asp:Button ID="btnVreme" runat="server" Text="Button" Font-Names="Arial" Font-Size="Medium" ForeColor="Navy" OnClick="btnVreme_Click" />
        </p>
        <asp:HyperLink ID="hlSledno" runat="server" NavigateUrl="~/Default2.aspx">Go to Default2.aspx</asp:HyperLink>
    </form>
</body>
</html>
