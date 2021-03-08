<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Program25._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="TextToChange" runat="server" Font-Size="Large" OnLoad="ChangeTheColor" Text="This is the text to change."></asp:Label>
    <asp:Button ID="ChangeText" runat="server" OnClick="ChangeText_Click" Text="Click Me!" />

</asp:Content>
