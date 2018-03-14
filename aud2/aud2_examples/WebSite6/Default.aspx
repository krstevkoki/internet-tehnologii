<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Example</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td style="background-color: #FFFF99">Валидациона група 1</td>
                </tr>
                <tr>
                    <td style="background-color: #FFFF99">
                        <asp:TextBox ID="txtValGrupa1" runat="server" ValidationGroup="grupa1"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtValGrupa1" ErrorMessage="Внесете текст" Font-Bold="True" Font-Size="Smaller" ForeColor="Red" ValidationGroup="grupa1"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="background-color: #FFFF99">
                        <asp:Button ID="btnValGrupa1" runat="server" OnClick="btnValGrupa1_Click" Text="Внеси" ValidationGroup="grupa1" />
                        <asp:Label ID="lblValGrupa1" runat="server" ForeColor="#009900"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td style="background-color: #CCFF66">Валидациона група 2</td>
                </tr>
                <tr>
                    <td style="background-color: #CCFF66">
                        <asp:TextBox ID="txtValGrupa2" runat="server" ValidationGroup="grupa2"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtValGrupa2" ErrorMessage="Внесете текст" Font-Bold="True" Font-Size="Smaller" ForeColor="Red" ValidationGroup="grupa2"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="background-color: #CCFF66">
                        <asp:Button ID="btnValGrupa2" runat="server" OnClick="btnValGrupa2_Click" Text="Внеси" ValidationGroup="grupa2" />
                        <asp:Label ID="lblValGrupa2" runat="server" ForeColor="#009900"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
