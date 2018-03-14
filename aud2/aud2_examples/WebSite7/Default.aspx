<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Example</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            margin-left: 0px;
        }
        .auto-style3 {
            width: 108px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:MultiView ID="mvRegistracija" runat="server">
                <asp:View ID="vwCekor1" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style3">
                                <asp:Label ID="lblIme" runat="server" Text="Име"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtIme" runat="server" CssClass="auto-style2"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <asp:Label ID="lblPrezime" runat="server" Text="Презиме"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtPrezime" runat="server" CssClass="auto-style2"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">&nbsp;</td>
                            <td>
                                <asp:Button ID="btnNext0" runat="server" Text="&gt;&gt;" OnClick="btnNext0_Click" />
                            </td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="vwCekor2" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style3">
                                <asp:Label ID="lblDatum" runat="server" Text="Датум на рагање"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtDatum" runat="server" CssClass="auto-style2"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <asp:Label ID="lblMesto" runat="server" Text="Место на раѓање"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtMesto" runat="server" CssClass="auto-style2"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="btnPrev0" runat="server" Text="&lt;&lt;" CommandName="PrevView" />
                                &nbsp;&nbsp;
                                <asp:Button ID="btnNext1" runat="server" Text="&gt;&gt;" CommandName="NextView" />
                            </td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="vwCekor3" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style3">
                                <asp:Label ID="lblAdresa" runat="server" Text="Адреса"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtAdresa" runat="server" CssClass="auto-style2"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <asp:Label ID="lblTelefon" runat="server" Text="Телефон"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtTelefon" runat="server" CssClass="auto-style2"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="btnPrev1" runat="server" Text="&lt;&lt;" CommandName="PrevView" />
                                &nbsp;&nbsp;
                                <asp:Button ID="btnNext2" runat="server" Text="&gt;&gt;" CommandName="NextView" />
                            </td>
                        </tr>
                    </table>
                </asp:View>
                <asp:View ID="vwCekor4" runat="server">
                    <table class="auto-style1">
                        <tr>
                            <td>
                                <asp:Label ID="lblSuccess" runat="server" Text="Успешна регистрација" ForeColor="#33CC33"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="btnPocetok" runat="server" OnClick="btnPocetok_Click" Text="Врати се на почеток" Width="227px" />
                            </td>
                        </tr>
                    </table>
                </asp:View>

            </asp:MultiView>
        </div>
    </form>
</body>
</html>
