<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Weather_webform.aspx.cs" Inherits="MyWeather.Weather_webform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>Klicka för att se vädret imorgon! </p>
        <asp:Button ID="Button1" runat="server" Text="Klicka på mig" OnClick="Button1_Click" />
        <asp:Label ID="Label1" runat="server" ></asp:Label>
    
    </div>
    </form>
</body>
</html>
