<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="A2.aspx.cs" Inherits="One_page_to_another_page.A2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            second page
<LABEL FOR="FIRST NAME">FIRST NAME</LABEL>
<INPUT TYPE="TEXT"><BR></BR>
<LABEL FOR="SECOND NAME">SECOND NAME</LABEL>
<INPUT TYPE="PASSWORD">


<INPUT TYPE="TEXT"><BR></BR>

<INPUT TYPE="AGE" PLACEHOLDER="YOUR AGE">

<BR></BR>
<INPUT TYPE="DATE"ID="CALENDAR"NAME="CALENDAR">
            <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" SelectedDate="10/22/2024 21:28:35" ShowGridLines="True" Width="220px">
                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                <OtherMonthDayStyle ForeColor="#CC9966" />
                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                <SelectorStyle BackColor="#FFCC66" />
                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
            </asp:Calendar>

<BR></BR>
<INPUT TYPE="TIME"ID="TIME"NAME="WATCH">
<BR>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" Text="submit" />
</BR>



        </div>
    </form>
</body>
</html>
