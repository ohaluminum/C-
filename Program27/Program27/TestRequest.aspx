<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestRequest.aspx.cs" Inherits="Program27.TestRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Make an request!<br />
            <asp:Button ID="RequestButton" runat="server" OnClick="RequestButton_Click" Text="Request" />
        </div>
    </form>
</body>
</html>
