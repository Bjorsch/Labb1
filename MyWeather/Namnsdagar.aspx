<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Namnsdagar.aspx.cs" Inherits="MyWeather.Namnsdagar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Skriv in ett namn för att se när det är namnsdag</h2>
        <asp:TextBox ID="TextBox1" runat="server" placeHolder="Namn"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Knapp" OnClick="Button1_Click" />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
