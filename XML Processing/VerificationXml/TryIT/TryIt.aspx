<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryIt.aspx.cs" Inherits="TryIT.TryIt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Assignment 4</h1><br />
        <h2>Web Service Try It page</h2><br />
        <h3>2.1 Verification</h3><br/>
        <asp:Label ID="Label1" runat="server" Text="XML URL : "></asp:Label><asp:TextBox ID="xmlurl" runat="server" Width="600"></asp:TextBox><br /><br />
        <asp:Label ID="Label2" runat="server" Text="XSD  URL : "></asp:Label><asp:TextBox ID="xsdurl" runat="server" Width="600"></asp:TextBox><br /><br /><br />
        <asp:Button ID="Button1" runat="server" Text="Verification Service" OnClick="Button1_Click" /><br /><br /><br />
        <asp:Label ID="output_verify" runat="server" Text="Output will appear here."></asp:Label>
    </div>
        <div>
        <h3>2.3 XPath Search</h3><br/>
        <asp:Label ID="Label3" runat="server" Text="XML URL : "></asp:Label><asp:TextBox ID="xmlurl_xpath" runat="server" Width="600"></asp:TextBox><br /><br />
        <asp:Label ID="Label4" runat="server" Text="Path Expression : "></asp:Label><asp:TextBox ID="xpath_expr" runat="server" Width="600"></asp:TextBox><br /><br /><br />
        <asp:Button ID="Button2" runat="server" Text="XPath Search Service" OnClick="Button2_Click"  /><br /><br /><br />
        <asp:Label ID="output_xpath" runat="server" Text="Output will appear here."></asp:Label>
        </div>
    </form>
</body>
</html>
