<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
                    <td>ListBox</td>
                    <td>DropDown List</td>
                </tr>
                <tr>
                    <td>
                        <asp:ListBox ID="lstBox" runat="server"></asp:ListBox>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlList" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>CheckBox List</td>
                    <td>RadioButton List</td>
                </tr>
                <tr>
                    <td>
                        <asp:CheckBoxList ID="chbList" runat="server" RepeatColumns="2">
                        </asp:CheckBoxList>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="rblList" runat="server" RepeatColumns="2" RepeatDirection="Horizontal">
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
