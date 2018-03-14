<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Katalog.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Katalog | Example</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="lnkTehnickaLiteratura" runat="server" Font-Bold="True" Font-Underline="True" OnClick="lnkTehnickaLiteratura_Click"> Техничка литература</asp:LinkButton>
            <br />
            <asp:LinkButton ID="lnkNaucnaFantastika" runat="server" Font-Bold="True" Font-Underline="True" OnClick="lnkNaucnaFantastika_Click">Научна фантастика</asp:LinkButton>
            <br />
            <asp:LinkButton ID="lnkAvtomobili" runat="server" Font-Bold="True" Font-Underline="True" OnClick="lnkAvtomobili_Click">Автомобили</asp:LinkButton>
        </div>
    </form>
</body>
</html>
