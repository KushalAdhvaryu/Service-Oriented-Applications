<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminPage.aspx.cs" Inherits="Staff_AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="home">
    <div>
        <p><asp:Button ID="home" runat="server" Text="Home" OnClick="home_Click" CausesValidation="False"   /></p> 
    <h1><asp:Label ID="Label1" runat="server" Text=" "></asp:Label></h1>&nbsp;&nbsp;&nbsp;
       
        <asp:Button ID="logout" runat="server" Text="LogOut" OnClick="logout_Click"  />
       
    <p>This is Admin Page.</p>
        <p>Content for Admin Page goes here.</p>
       <p>Admin Authorized access.</p>
        <asp:Label ID="Label2" runat="server" Text="Latitude: "></asp:Label>
        <asp:TextBox ID="latitude" runat="server" ></asp:TextBox> <br /><br />
         <asp:Label ID="Label3" runat="server" Text="Longitude: "></asp:Label>
        <asp:TextBox ID="longitude" runat="server" ></asp:TextBox> <br />
       <br /><br />
        <asp:Button ID="CrimeServi" runat="server" Text="Crime Service" OnClick="CrimeServi_Click"  />
       <br /><br />
        <asp:Label ID="Output" runat="server" Text=" Output will appear here."></asp:Label><br />
        <asp:ListView ID="ListView1" runat="server">
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server" id="itemPlaceholder"></tr>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr runat="server">
                    <td runat="server">
                        <asp:Label ID="lblweather" runat="server" Text="Type: "></asp:Label>
                    </td>
                    <td runat="server">
                        <asp:Label ID="weather" runat="server" Text='<%#Eval("type") %>'></asp:Label>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server">
                        <asp:Label ID="lbldescription" runat="server" Text="Date: "></asp:Label>
                    </td>
                    <td runat="server">
                        <asp:Label ID="description" runat="server" Text='<%#Eval("date") %>'></asp:Label>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server">
                        <asp:Label ID="lbltemperature" runat="server" Text="Address: "></asp:Label>
                        <br /><br /><br /><br />
                    </td>
                    <td runat="server">
                        <asp:Label ID="temperature" runat="server" Text='<%#Eval("address") %>'></asp:Label>
                        <br /><br /><br /><br />
                    </td>
                </tr>       
            </ItemTemplate>
        </asp:ListView>
        </div>
    </form>
</body>
</html>
