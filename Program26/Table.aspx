<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Table.aspx.cs" Inherits="Program26.Table" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                This is a table.<br />
                <br />
                <asp:Table ID="Table1" runat="server" Height="50px" Width="60px">
                    <asp:TableRow runat="server">
                        <asp:TableCell ID="TableCell11" runat="server"></asp:TableCell>
                        <asp:TableCell ID="TableCell12" runat="server"></asp:TableCell>                        
                        <asp:TableCell ID="TableCell13" runat="server"></asp:TableCell>
                    </asp:TableRow>

                    <asp:TableRow runat="server">
                        <asp:TableCell ID="TableCell21" runat="server"></asp:TableCell>
                        <asp:TableCell ID="TableCell22" runat="server"></asp:TableCell>                        
                        <asp:TableCell ID="TableCell23" runat="server"></asp:TableCell>
                    </asp:TableRow>

                    <asp:TableRow runat="server">
                        <asp:TableCell ID="TableCell31" runat="server"></asp:TableCell>
                        <asp:TableCell ID="TableCell32" runat="server"></asp:TableCell>                        
                        <asp:TableCell ID="TableCell33" runat="server"></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>

            </div>
        </form>
    </body>
</html>
