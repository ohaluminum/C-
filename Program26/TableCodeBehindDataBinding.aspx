<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TableCodeBehindDataBinding.aspx.cs" Inherits="Program26.TableCodeBehindDataBinding" %>

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
                        <asp:TableCell ID="TableCell1" runat="server" Wrap="false"></asp:TableCell>
                        <asp:TableCell ID="TableCell2" runat="server" Wrap="false"></asp:TableCell>                        
                        <asp:TableCell ID="TableCell3" runat="server" Wrap="false"></asp:TableCell>
                        <asp:TableCell ID="TableCell4" runat="server" Wrap="false"></asp:TableCell>
                        <asp:TableCell ID="TableCell5" runat="server" Wrap="false"></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </div>
        </form>
    </body>
</html>
