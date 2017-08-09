<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MemberPage.aspx.cs" Inherits="Member_MemberPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="Button1">
    <div>
    <h1><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h1>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
         
        <asp:Button ID="logout" runat="server" Text="LogOut" OnClick="logout_Click"  />
        <p><asp:Button ID="home" runat="server" Text="Home"  CausesValidation="False" OnClick="home_Click"   /></p> 
        <h2>Objective:</h2>
        <p> <br />This application aims to provide you basic information of an locality based on Zip Code.<br /> Using the services provided you can 
            search information such as Weather of the Location, Resturants in given area, Crime rate in given area, Location on Map of the area.<br />
            Using this services will serve as one stop search soultion for user to get details of area.
        </p>
        <p>Zipcode: </p>
        <asp:TextBox ID="zipcode" runat="server" ></asp:TextBox> <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br />

        <p><h3>Public RESTful API by Google for Zipcode to Coordinates</h3> </p>
        <asp:Button ID="Button1" runat="server" Text="Lat Long Service" OnClick="Button1_Click"  />
        <p>Latitude</p>
        <asp:TextBox ID="latitude" runat="server" ></asp:TextBox> <br />
        <p>Longitude</p>
        <asp:TextBox ID="longitude" runat="server" ></asp:TextBox> <br /><br /><br />
        <asp:Label ID="Label4" runat="server" Text="Output will appear in text boxes above."></asp:Label>


        <h3>Self Published Webstrar Service </h3> 
        <h4>Based on ZipCode </h4>      
        <asp:Button ID="restSer" runat="server" Text="Restaurant Service" OnClick="restSer_Click"   />
        <h4>Based on Latitude and Longitude </h4>  
        <asp:Button ID="LocationMap" runat="server" Text="Location on Map Service" OnClick="LocationMap_Click1"   /><br /><br />
        <asp:Label ID="Output" runat="server" Text="Output will appear below."></asp:Label><br /><br />

        <asp:MultiView Id="mv1" runat="server">
            <asp:View ID="View1" runat="server">
                
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
            </asp:View>

            <asp:View ID="View2" runat="server">
                <asp:Label ID="Label5" runat="server" Text="Static URL: "></asp:Label>
        <asp:Label ID="staticurl" runat="server" Text="Value "></asp:Label><br />
        <asp:Image ID="StaticImage" runat="server" AlternateText="Map to Display: None." /><br /><br /><br /><br />
        <asp:Label ID="Label6" runat="server" Text="StreetView URL: "></asp:Label>
        <asp:Label ID="streetviewurl" runat="server" Text="Value "></asp:Label><br />
        <asp:Image ID="StreetImage" runat="server" AlternateText="Map to Display: None." />
            </asp:View>
           
        </asp:MultiView>
        


    </div>
    </form>
</body>
</html>
