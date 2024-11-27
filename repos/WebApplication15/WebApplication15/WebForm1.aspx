<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication15.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 333px;
        }
        .auto-style4 {
            height: 23px;
            width: 333px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                        <Columns>
                            <asp:TemplateField HeaderText="EMAIL_ID">
                                <HeaderTemplate>
                                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label3" runat="server" BackColor='<%# Bind("PASSWORD") %>' Text="Label"></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="PASSWORD"></asp:TemplateField>
                            <asp:TemplateField HeaderText="COMMAND"></asp:TemplateField>
                            <asp:HyperLinkField />
                        </Columns>
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <PagerTemplate>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="Label2" runat="server" Enabled='<%# Bind("EMAIL_ID") %>' Text="Label"></asp:Label>
                            &nbsp;
                            <asp:DropDownList ID="DropDownList1" runat="server" style="width: 77px">
                            </asp:DropDownList>
                        </PagerTemplate>
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#0000A9" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#000065" />
                    </asp:GridView>
                </td>
                <td>
                    <asp:Calendar ID="Calendar1" runat="server" VisibleDate="2024-09-02"></asp:Calendar>
                    <br />
                    <br />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style4"></td>
                <td class="auto-style2">
                    <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
                    <asp:Panel ID="Panel2" runat="server">
                        <asp:Table ID="Table1" runat="server">
                        </asp:Table>
                    </asp:Panel>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Panel ID="Panel1" runat="server">
                    </asp:Panel>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style4">
                    <input id="Checkbox1" type="checkbox" /><input id="Checkbox2" type="checkbox" /><input id="Checkbox3" type="checkbox" /><input id="Checkbox4" type="checkbox" /><input id="Checkbox5" type="checkbox" /><input id="Checkbox6" type="checkbox" /><input id="Checkbox7" type="checkbox" /><input id="Checkbox8" type="checkbox" /><input id="Checkbox9" type="checkbox" /><input id="Checkbox10" type="checkbox" /></td>
                <td class="auto-style2">
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                </td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    </asp:RadioButtonList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Substitution ID="Substitution1" runat="server" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
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
