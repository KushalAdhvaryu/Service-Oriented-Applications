<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Weather.aspx.cs" Inherits="TryIt.Weather" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1 >Required Service 1: Weather Service</h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="http://webstrar3.fulton.asu.edu/index.html">Home Page:  http://webstrar3.fulton.asu.edu/index.html </a>
        <h2>A. Description: This service provides 5 day weather forecast based on user input for Zip code location.</h2> <br />
        <h2>B. URL: http://webstrar3.fulton.asu.edu/page2/Service1.svc </h2> <br />
        <h2>C. Method Name: WeatherInfo </h2> <br />
            <h3> Parameter Type:(string) ZipCode. (Search works for USA only.)</h3><br />
            <h3> Return Type: 5 days weather forecast list in form of Object containing (string) weather,(string) description,(float) temperature,(float) max_temp,(float) min_temp,(float) humidity,(string) date.</h3><br />
        <h2>D. User Inputs: </h2>
        <asp:TextBox ID="zipcode" runat="server" ></asp:TextBox> <br />
        <h2>E. Invoke Buttons: </h2>
        <asp:Button ID="WeatherServi" runat="server" Text="Weather Service" OnClick="Button1_Click" />
        <h2>F. Service Response: </h2>
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
