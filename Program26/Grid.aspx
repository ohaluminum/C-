<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grid.aspx.cs" Inherits="Program26.Grid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
        <link rel="stylesheet" type="text/css" href="gridview.css" />
    </head>

    <body>
        <form id="form1" runat="server">
            <div>
                This table displays all content information:<br />
                <br />
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                <br />
                This table displays partial content information:<br />
                <br />
                <asp:GridView ID="GridView2" runat="server"></asp:GridView>

            </div>
        </form>
    </body>
</html>
