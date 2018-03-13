<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Example</title>
    <style type="text/css">
        .auto-style1 { width: 100%; }

        .auto-style2 { height: 24px; }

        .auto-style3 { height: 27px; }

        .auto-style4 { height: 26px; }

        .auto-style5 { width: 123px; }

        .auto-style6 {
            height: 27px;
            width: 123px;
        }

        .auto-style7 {
            height: 26px;
            width: 123px;
        }

        .auto-style8 {
            height: 24px;
            width: 123px;
        }
        .auto-style9 {
            width: 124px;
        }
        .auto-style10 {
            width: 158px;
        }
        </style>
</head>
<body>
<form id="form1" runat="server">
    <div>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lblIme" runat="server">Име</asp:Label>
                        </td>
                        <td>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtIme" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="validatorIme" runat="server" ControlToValidate="txtIme" Display="None" ErrorMessage="Внеси име!"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lblPrezime" runat="server">Презиме</asp:Label>
                        </td>
                        <td>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtPrezime" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="validatorPrezime" runat="server" ControlToValidate="txtPrezime" Display="None" ErrorMessage="Внеси презиме!"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            <asp:Label ID="lblID" runat="server">ФИНКИ ID</asp:Label>
                        </td>
                        <td class="auto-style3">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                            <asp:Label ID="lblMail" runat="server" Font-Bold="False" ForeColor="Gray">@finki.ukim.mk</asp:Label>
                            <asp:RequiredFieldValidator ID="validatorID" runat="server" ControlToValidate="txtID" Display="None" ErrorMessage="Внеси ФИНКИ ID!"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="validatorFormatID" runat="server" ControlToValidate="txtID" Display="None" ErrorMessage="Неправилен формат на ID" ValidationExpression="[a-z]+((_)|(\.))[a-z]+\d*"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7"></td>
                        <td class="auto-style4">
                            <asp:Label ID="lblPoraka" runat="server" Font-Size="Smaller" ForeColor="#CCCCCC">може да ги содржи знаците: a-z, 0-9 и максимум една точка</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style8">
                            <asp:Label ID="lblLozinka" runat="server">Лозинка</asp:Label>
                        </td>
                        <td class="auto-style2">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtLozinka" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="validatorLozinka" runat="server" ControlToValidate="txtLozinka" Display="None" ErrorMessage="Внеси лозинка!"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="lblPotvrdi" runat="server">Потврда</asp:Label>
                        </td>
                        <td>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:TextBox ID="txtPotvrdi" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="validatorPotvrda" runat="server" ControlToValidate="txtPotvrdi" Display="None" ErrorMessage="Внеси потврда!"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="validatorIstiLozinki" runat="server" ControlToCompare="txtLozinka" ControlToValidate="txtPotvrdi" Display="None" ErrorMessage="Различни лозинки"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="btnNext" runat="server" Text="&gt;&gt;" Width="66px" OnClick="btnNext_Click"/>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"/>
                        </td>
                    </tr>
                </table>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style9">
                            <asp:Label ID="lblAdresa" runat="server">Адреса</asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="txtAdresa" runat="server"></asp:TextBox>
                            &nbsp;<asp:RequiredFieldValidator ID="validatorAdresa" runat="server" ControlToValidate="txtAdresa" ErrorMessage="Внеси адреса" Font-Bold="False" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style9" rowspan="2">
                            <asp:Label ID="lblTel" runat="server">Тел</asp:Label>
                        </td>
                        <td class="auto-style10" rowspan="2">
                            <asp:TextBox ID="txtTel" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="validatorTel" runat="server" ControlToValidate="txtTel" ErrorMessage="Внеси телефон" Font-Bold="False" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:RegularExpressionValidator ID="validatorFormatLozinka" runat="server" ControlToValidate="txtTel" ErrorMessage="Неправилен формат" ForeColor="Red" ValidationExpression="^(\+389)\s(((2\s)\d{4}\s\d{3})|(7[0-35-9]\s\d{3}\s\d{3}))"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:Label ID="lblPol" runat="server">Пол:</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RadioButtonList ID="rblPol" runat="server">
                                <asp:ListItem>М</asp:ListItem>
                                <asp:ListItem>Ж</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:RequiredFieldValidator ID="validatorPol" runat="server" ControlToValidate="rblPol" ErrorMessage="Избери пол" Font-Bold="False" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:Label ID="lblDatum" runat="server">Датум на раѓање</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:Calendar ID="calendar" runat="server" Font-Underline="False" VisibleDate="1965-06-01">
                                <DayStyle Font-Underline="True" />
                                <NextPrevStyle Font-Underline="True" />
                                <OtherMonthDayStyle Font-Underline="True" />
                                <SelectedDayStyle Font-Underline="False" />
                                <TitleStyle Font-Bold="False" Font-Underline="False" />
                                <TodayDayStyle Font-Underline="False" />
                            </asp:Calendar>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4" colspan="3"></td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:Button ID="btnPrev" runat="server" CausesValidation="False" OnClick="btnPrev_Click" Text="&lt;&lt;" Width="83px" />
                            &nbsp;&nbsp;
                            <asp:Button ID="btnNext1" runat="server" OnClick="btnNext_Click" Text="&gt;&gt;" Width="83px" />
                        </td>
                    </tr>
                </table>
            </asp:View>
            <asp:View ID="View3" runat="server">
                <table class="auto-style1">
                    <tr>
                        <td>
                            <asp:Label ID="lblZanimanje" runat="server">Занимање</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="ddlZanimanje" runat="server">
                                <asp:ListItem>-занимање-</asp:ListItem>
                                <asp:ListItem>Програмер</asp:ListItem>
                                <asp:ListItem>Тестер</asp:ListItem>
                                <asp:ListItem>Човечки ресурси</asp:ListItem>
                                <asp:ListItem>Цајкан</asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="validatorZanimanje" runat="server" ControlToValidate="ddlZanimanje" ErrorMessage="Внеси занимање" Font-Bold="False" ForeColor="Red" InitialValue="-занимање-"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblGodini" runat="server">Години на вршење на избраната дејност</asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtGodini" runat="server" Width="102px"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="validatorGodini" runat="server" ControlToValidate="txtGodini" ErrorMessage="Недозволена вредност" ForeColor="Red" ValidationExpression="\d+"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnPrev1" runat="server" CausesValidation="False" OnClick="btnPrev_Click" Text="&lt;&lt;" Width="83px" />
                            &nbsp;&nbsp;
                            <asp:Button ID="btnPodnesi" runat="server" OnClick="btnPodnesi_Click" Text="Поднеси" Width="83px" />
                        </td>
                    </tr>
                </table>
            </asp:View>
            <asp:View ID="View4" runat="server">
                <asp:Label ID="lblUspesnoKreiranje" runat="server">Креиран е корисникот </asp:Label>
                <asp:Label ID="lblKorisnik" runat="server"></asp:Label>
                <asp:Label ID="lblKorisnikMail" runat="server" ForeColor="Gray"></asp:Label>
                <br />
                <asp:Label ID="lblGreska" runat="server" ForeColor="Red"></asp:Label>
                <br />
                <asp:Button ID="btnPocetok" runat="server" CausesValidation="False" OnClick="btnPocetok_Click" Text="Врати се на почеток" Width="306px" />
            </asp:View>
        </asp:MultiView>
    </div>
</form>
</body>
</html>