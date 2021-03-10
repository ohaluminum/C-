<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TableMarkupDataBinding.aspx.cs" Inherits="Program26.TableMarkupDataBinding" %>

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
                        <asp:TableCell ID="TableCell1" runat="server" Text="<%# show.ID %>" Wrap="false"></asp:TableCell>
                        <asp:TableCell ID="TableCell2" runat="server" Text="<%# show.Channel %>" Wrap="false"></asp:TableCell>                        
                        <asp:TableCell ID="TableCell3" runat="server" Text="<%# show.EpisodeTitle %>" Wrap="false"></asp:TableCell>
                        <asp:TableCell ID="TableCell4" runat="server" Text="<%# show.ScheduledTime %>" Wrap="false"></asp:TableCell>
                        <asp:TableCell ID="TableCell5" runat="server" Text="<%# show.ShowTitle %>" Wrap="false"></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </div>
        </form>
    </body>
</html>
