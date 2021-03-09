<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInput.aspx.cs" Inherits="Program26.UserInput" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <h2>USER INPUT TEXTBOX</h2>
                1. The TextBox<br />
                <asp:TextBox ID="TextBox1" runat="server" Placeholder="Enter Text..."></asp:TextBox>
                <br />
                <br />
                2. The TextArea<br />
                <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Placeholder="Enter Text..."></asp:TextBox>
                <br />
                <br />
                3. The Password<br />
                <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Placeholder="Enter Password..."></asp:TextBox>
                <br />
                <br />
                4. Email<br />
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Email" Placeholder="Enter Email..."></asp:TextBox>
                <br />
                <br />
                5. Phone<br />
                <asp:TextBox ID="TextBox5" runat="server" TextMode="Email" Placeholder="Enter Number..."></asp:TextBox>
                <br />
                <br />
                6. URL<br />
                <asp:TextBox ID="TextBox6" runat="server" TextMode="URL" Placeholder="Enter URL..."></asp:TextBox>
                <br />
                <br />

                <h2>SINGLE-ITEM SELECTION</h2>
                1. The Checkbox<br />
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Click me"/>
                <br />
                <br />
                2. The Radio Button List<br />
                <br />
                Ex. Gender:
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem Selected="True">Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
                <br />

                3. The Drop-Down List<br />
                <br />
                Ex. Classification:&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Selected="True">Freshman</asp:ListItem>
                    <asp:ListItem>Sophomore</asp:ListItem>
                    <asp:ListItem>Junior</asp:ListItem>
                    <asp:ListItem>Senior</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />

                <h2>MULTIPLE-ITEM SELECTION</h2>
                1. Checkbox List<br/>
                <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                    <asp:ListItem>Choose me</asp:ListItem>
                    <asp:ListItem>Choose me</asp:ListItem>
                    <asp:ListItem>Choose me</asp:ListItem>
                    <asp:ListItem>Choose me also</asp:ListItem>
                </asp:CheckBoxList>
                <br/>
                2. Listbox<br/>
                <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple" Height="90px" Width="80px">
                    <asp:ListItem>Item 1</asp:ListItem>
                    <asp:ListItem>Item 2</asp:ListItem>
                    <asp:ListItem>Item 3</asp:ListItem>
                    <asp:ListItem>Item 4</asp:ListItem>
                </asp:ListBox>


            </div>
        </form>
    </body>
</html>
