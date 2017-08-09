<%@ Page Language="C#" AutoEventWireup="true" CodeFile="task3assignment.aspx.cs" Inherits="task3assignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Celsius to Farhrenheit" Font-Size="18"></asp:Label> <br /><br /> <br /> 
        <asp:Label ID="Label2" runat="server" Text="Input C: "></asp:Label>
        <asp:TextBox ID="Celsius" runat="server" OnTextChanged="Celsius_TextChanged"></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Text="Output F: "></asp:Label>
         <asp:Label ID="OutputF" runat="server" Text="Output will appear here"></asp:Label><br />
        <asp:Button ID="Button1" runat="server" Text="Convert C2F" OnClick="Button1_Click" /><br /><br />
        <asp:Label ID="Label4" runat="server" Text="Farhrenheit to Celsius"  Font-Size="18"></asp:Label><br /><br /><br />
        <asp:Label ID="Label5" runat="server" Text="Input F: "></asp:Label>
        <asp:TextBox ID="InputF" runat="server" OnTextChanged="InputF_TextChanged"></asp:TextBox><br />
        <asp:Label ID="Label6" runat="server" Text="Output C: "></asp:Label>
         <asp:Label ID="OutputC" runat="server" Text="Output will appear here"></asp:Label><br />
        <asp:Button ID="Button2" runat="server" Text="Convert F2C" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
