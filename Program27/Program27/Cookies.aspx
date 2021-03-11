<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookies.aspx.cs" Inherits="Program27.Cookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="CookieValue" runat="server" TextMode="MultiLine"></asp:TextBox>
            <asp:Button ID="GetCookieButton" runat="server" Text="Get Cookie" />
        </div>
    </form>
</body>
</html>
