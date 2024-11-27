<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            width: 166px;
        }
        .auto-style5 {
            width: 140px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            width: 140px;
            height: 26px;
        }
        .auto-style8 {
            width: 166px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style5">Enter name </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Image ID="Image1" runat="server" Height="100px" Width="100px" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style5">image</td>
                    <td class="auto-style4">
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style7">signature</td>
                    <td class="auto-style8">
                        <asp:FileUpload ID="FileUpload2" runat="server" />
                    </td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6">
                        <asp:Image ID="Image2" runat="server" Height="55px" Width="152px" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
