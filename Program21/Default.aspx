<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Program21._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>My First ASP.NET Web Application</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <h2>Building Secure Web Forms Applications</h2>
        <p>The two main types of attacks to be concerned about for a Web Forms application are: </p>
        <ul>
          <li>SQL Injection attacks</li>
          <li>Script exploits</li>
        </ul>
        <hr>
        
        <h2>SQL Injection Attacks</h2>
        <p>
            SQL Injection attack happens when a hacker enters a line of SQL code into an input field used to query a database in a form on a web page (such as the username and password text boxes in a login form).
            Malicious SQL code causes the database to act in an unexpected way or to allow the hacker to gain access to, alter, or damage the database.
        </p>
        <hr>

        <h2>Script exploits</h2>
        <p>
            A script exploit is a security flaw that takes advantage of the JavaScript engine in a user’s web browser. 
            Script exploits take advantage of one of the more common features of public Web Forms applications: enabling interaction among users.
        </p>
        <p style="background-color: #FFFFFF">Type "<span style="color: rgb(64, 64, 64); font-family: Georgia, &quot;Droid Serif&quot;, Times, serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(245, 238, 224); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">&lt;script&gt;msgbox()&lt;/script&gt;</span>&quot; in the textbox: Script exploits are blocked by default.</p>
        <p style="background-color: #FFFFFF">&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="230px"></asp:TextBox>
        </p>
    </div>
    
    

</asp:Content>
