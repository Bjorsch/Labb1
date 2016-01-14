<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MovieFromYear.aspx.cs" Inherits="MyWeather.MovieFromYear" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="2012" OnClick="Button1_Click"/>
        <asp:Button ID="Button2" runat="server" Text="2013" />
        <asp:Button ID="Button3" runat="server" Text="2014" />
        <asp:Button ID="Button4" runat="server" Text="2015" />   
        <br/>
        <br/>     
        <%--<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>--%>
        <asp:TextBox ID="TextBox1" runat="server" Height="403px" TextMode="MultiLine" Width="531px" ></asp:TextBox>
    </div>
    </form>
</body>
</html>
