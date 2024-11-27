<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 91px;
        }
        .auto-style3 {
            width: 91px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            width: 130px;
        }
        .auto-style6 {
            height: 23px;
            width: 130px;
        }
        .auto-style7 {
            width: 237px;
        }
        .auto-style8 {
            height: 23px;
            width: 237px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">NAME</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">ROLL NO</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td>
                    <asp:Image ID="Image1" runat="server" ForeColor="Red" Height="100px" Width="157px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style6"></td>
                <td class="auto-style8"></td>
                <td class="auto-style4">
                    <asp:LinkButton ID="LinkButton1" runat="server">SUBMIT</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style6"></td>
                <td class="auto-style8"></td>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:ImageMap ID="ImageMap1" runat="server">
                    </asp:ImageMap>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>
                    <asp:ImageButton ID="ImageButton1" runat="server" Width="122px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style6"></td>
                <td class="auto-style8"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    </asp:RadioButtonList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">
                    <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                    </asp:RadioButtonList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">
                    <asp:RadioButtonList ID="RadioButtonList3" runat="server">
                    </asp:RadioButtonList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
