<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffPage.aspx.cs" Inherits="Staff_StaffPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server"  defaultbutton="WeatherServi">
        
    <div>
     <p><asp:Button ID="home" runat="server" Text="Home" OnClick="home_Click" CausesValidation="False"/></p> 
    <h1><asp:Label ID="Label1" runat="server" Text=" "></asp:Label></h1>&nbsp;&nbsp;&nbsp;
      
        <asp:Button ID="logout" runat="server" Text="LogOut" OnClick="logout_Click"  />
       
    <p>This is Staff Page.</p>
        <p>Content for Staff Page goes here.</p>
        <p>Staff Authorized access.</p>
        <p>Enter ZipCode.</p>
       <asp:TextBox ID="zipcode" runat="server" ></asp:TextBox> <br />
        <h2> Invoke Buttons: </h2>
        <asp:Button ID="WeatherServi" runat="server" Text="Weather Service" OnClick="Button1_Click" />
        <br /><br />
         <asp:Label ID="Output" runat="server" Text="Output will appear here."></asp:Label>
        <asp:ListView ID="ListView1" runat="server">
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server" id="itemPlaceholder"></tr>
                </table>
               
                
            </LayoutTemplate>
            <ItemTemplate>
                <tr runat="server">
                    <td runat="server">
                        <asp:Label ID="lblweather" runat="server" Text="Weather: "></asp:Label>
                    </td>
                    <td runat="server">
                        <asp:Label ID="weather" runat="server" Text='<%#Eval("weather") %>'></asp:Label>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server">
                        <asp:Label ID="lbldescription" runat="server" Text="Description: "></asp:Label>
                    </td>
                    <td runat="server">
                        <asp:Label ID="description" runat="server" Text='<%#Eval("description") %>'></asp:Label>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server">
                        <asp:Label ID="lbltemperature" runat="server" Text="Temperature: "></asp:Label>
                    </td>
                    <td runat="server">
                        <asp:Label ID="temperature" runat="server" Text='<%#Eval("temperature") %>'></asp:Label>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server">
                        <asp:Label ID="lblmax_temp" runat="server" Text="Maximum temeprature: "></asp:Label>
                    </td>
                    <td runat="server">
                        <asp:Label ID="max_temp" runat="server" Text='<%#Eval("max_temp") %>'></asp:Label>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server">
                        <asp:Label ID="lblmin_temp" runat="server" Text="Minimum Temperature: "></asp:Label>
                    </td>
                    <td runat="server">
                        <asp:Label ID="min_temp" runat="server" Text='<%#Eval("min_temp") %>'></asp:Label>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server">
                        <asp:Label ID="lblHumidity" runat="server" Text="Humidity: "></asp:Label>
                    </td>
                    <td runat="server">
                        <asp:Label ID="humidity" runat="server" Text='<%#Eval("humidity") %>'></asp:Label>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server">
                        <asp:Label ID="lblDate" runat="server" Text="Date: "></asp:Label>
                        <br /><br /><br /><br />
                    </td>
                    <td runat="server">
                        <asp:Label ID="date" runat="server" Text='<%#Eval("date") %>'></asp:Label>
                         <br /><br /><br /><br />
                    </td>
                   
                </tr>
               
            </ItemTemplate>
        </asp:ListView>
    </div>
    </form>
</body>
</html>
