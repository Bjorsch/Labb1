<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Movies.aspx.cs" Inherits="MyWeather.Movies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>Skriv in en filmtitel för att se när den gjordes</h3>
        <asp:TextBox ID="TextBox1" runat="server" placeHolder="Titel"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br/><br/>
        <asp:Button ID="Button1" runat="server" Text="Resultat" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
