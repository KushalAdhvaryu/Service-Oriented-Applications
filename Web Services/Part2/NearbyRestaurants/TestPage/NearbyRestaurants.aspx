<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NearbyRestaurants.aspx.cs" Inherits="TestPage.NearbyRestaurants" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <h1 >Elective Service 1: Nearby Restaurants (RESTful)</h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="http://webstrar3.fulton.asu.edu/index.html">Home Page:  http://webstrar3.fulton.asu.edu/index.html </a>
        <h2>A. Description: This service provides nearby Restaurants information based on user input for Zip code location.</h2> <br />
        <h2>B. URL: http://webstrar3.fulton.asu.edu/page0/Service1.svc/restaurant?address={zipcode}  </h2> <br />
        <h2>C. Method Name: RestaurantInfo </h2> <br />
            <h3> Parameter Type:(string) ZipCode. (Search works for USA only.)</h3><br />
            <h3> Return Type: Restaurant Information Object in form of  List Object containing (string) name,(bool) isclose,(string) price,(string) phone.</h3><br />
        <h2>D. User Inputs: </h2>
        <asp:TextBox ID="zipcode" runat="server" ></asp:TextBox> <br />
        <h2>E. Invoke Buttons: </h2>
        <asp:Button ID="RestServi" runat="server" Text="Restuarant Information Service" OnClick="Button1_Click" />
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
                        <asp:Label ID="lblweather" runat="server" Text="Name: "></asp:Label>
                    </td>
                    <td runat="server">
                        <asp:Label ID="weather" runat="server" Text='<%#Eval("name") %>'></asp:Label>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server">
                        <asp:Label ID="lbldescription" runat="server" Text="IsClose: "></asp:Label>
                    </td>
                    <td runat="server">
                        <asp:Label ID="description" runat="server" Text='<%#Eval("isclose") %>'></asp:Label>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server">
                        <asp:Label ID="lbltemperature" runat="server" Text="Price: "></asp:Label>
                    </td>
                    <td runat="server">
                        <asp:Label ID="temperature" runat="server" Text='<%#Eval("price") %>'></asp:Label>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server">
                        <asp:Label ID="lblmax_temp" runat="server" Text="Phone: "></asp:Label>
                        <br /><br /><br /><br />
                    </td>
                    <td runat="server">
                        <asp:Label ID="max_temp" runat="server" Text='<%#Eval("phone") %>'></asp:Label>
                        <br /><br /><br /><br />
                    </td>
                </tr>
                
            </ItemTemplate>
        </asp:ListView>
    </div>
    </form>
</body>
</html>
