<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Program27.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <!-- Shows the current path -->
                <asp:SiteMapPath ID="SiteMapPath1" Runat="server">
                </asp:SiteMapPath>
 
                <!-- Specifies the data source -->
                <asp:SiteMapDataSource ID="SiteMapDataSource1" Runat="server"/>
 
                <!-- Displays the map in tree form -->
                <asp:TreeView ID="TreeView1" Runat="Server" DataSourceID="SiteMapDataSource1"></asp:TreeView>
                
                <br />
                
                <!-- Displays child site -->
                Child site list:<br />
                <asp:ListBox ID="ListBox1" runat="server" Width="250px" Height="80px"></asp:ListBox>
            </div>
        </form>
    </body>
</html>
