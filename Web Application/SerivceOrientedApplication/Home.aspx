<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="hidden" >
    <div>
        <h1>Assignment 5:</h1>
        <h1><asp:Label ID="Label1" runat="server" Text=" "></asp:Label></h1>&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text=" "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="logout" runat="server" Text="LogOut" OnClick="logout_Click"  />
         <p>Public Options</p>
        <asp:Button ID="public" runat="server" Text="Public Page" OnClick="public_Click"  />&nbsp;&nbsp;&nbsp;        
        <br /><br />
        <p>Member Options</p>
        <asp:Button ID="manage_register" runat="server" Text="Member Register" OnClick="manage_register_Click" />&nbsp;&nbsp;&nbsp;
        
        <asp:Button ID="member_page" runat="server" Text="Member page" OnClick="member_page_Click" />
        <br /><br />
         <p>Staff Options</p>
      
        <asp:Button ID="staff_page" runat="server" Text="Staff page" OnClick="staff_page_Click"  />&nbsp;&nbsp;&nbsp;
        
        <asp:Button ID="Admin_page" runat="server" Text="Admin page" OnClick="Admin_page_Click"  /> &nbsp;&nbsp;&nbsp;    <asp:Button ID="hidden" runat="server" Text="Button"  visible="False" OnClick="hidden_Click"/> 
        <br /><br />
    </div>
    </form>
</body>
</html>
