<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form.aspx.cs" Inherits="Daatman_form.form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 132px;
        }
        .auto-style3 {
            margin-left: 0px;
        }
        .auto-style4 {
            width: 185px;
        }
        .auto-style5 {
            width: 145px;
        }
        .auto-style6 {
            width: 151px;
        }
        .auto-style7 {
            width: 151px;
            height: 23px;
        }
        .auto-style8 {
            width: 132px;
            height: 23px;
        }
        .auto-style9 {
            width: 185px;
            height: 23px;
        }
        .auto-style10 {
            width: 145px;
            height: 23px;
        }
        .auto-style11 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" Text="ADD" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button2" runat="server" Text="EDIT" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="Button3" runat="server" CssClass="auto-style3" Text="DELECT" />
                </td>
                <td>
                    <asp:Button ID="Button4" runat="server" Text="FIND" />
                </td>
                <td>
                    <asp:Button ID="Button5" runat="server" Text="SAVE" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">NAME</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">Date of Birth</td>
                <td class="auto-style4">
                    <asp:Calendar ID="Calendar2" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
                        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                        <OtherMonthDayStyle ForeColor="#CC9966" />
                        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                        <SelectorStyle BackColor="#FFCC66" />
                        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                    </asp:Calendar>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td>Age</td>
                <td>
                    <asp:TextBox ID="TextBox6" runat="server" Height="16px" Width="45px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">Date of Joining</td>
                <td class="auto-style4">
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
                        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                        <OtherMonthDayStyle ForeColor="#CC9966" />
                        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                        <SelectorStyle BackColor="#FFCC66" />
                        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                    </asp:Calendar>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td>Mobile</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">Address</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">City</td>
                <td class="auto-style4">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Select city</asp:ListItem>
                        <asp:ListItem>Kanpur</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">State</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td>Country</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8"></td>
                <td class="auto-style9"></td>
                <td class="auto-style10"></td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
                <td class="auto-style11"></td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">Class</td>
                <td class="auto-style4">College</td>
                <td class="auto-style5">Obtaining</td>
                <td>Obtained</td>
                <td>%</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>Overall %:</td>
                <td>
                    <asp:TextBox ID="TextBox22" runat="server" Height="16px" Width="41px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
