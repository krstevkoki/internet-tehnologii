<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UspesnoGlasanje.aspx.cs" Inherits="UspesnoGlasanje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Uspesno Glasanje | Kol1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" ScrollBars="Vertical" Width="219px">
                <asp:Label ID="lblStatus" runat="server"></asp:Label>
                <br />
                <br />
                <br />
                <br />
                <asp:Button ID="btnRezultati" runat="server" OnClick="btnRezultati_Click" Text="Резултати" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
