<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LocationonMap.aspx.cs" Inherits="TestPage.LocationonMap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1 >Elective Service 2: Location on Map</h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="http://webstrar3.fulton.asu.edu/index.html">Home Page:  http://webstrar3.fulton.asu.edu/index.html </a>
        <h2>A. Description: This service provides Location on Map based on user input for Latitude and Longitude of location.</h2> <br />
        <h2>B. URL:http://webstrar3.fulton.asu.edu/page1/Service1.svc </h2> <br />
        <h2>C. Method Name: MapInfo </h2> <br />
            <h3> Parameter Type: (double) Latitude ,(double) Longitude. (Best Results for USA only.)</h3><br />
            <h3> Return Type:(string[2])  URL to ([0]) static and ([1]) street view image.</h3><br />
        <h2>D. User Inputs: </h2>
         <asp:Label ID="Label1" runat="server" Text="Latitude: "></asp:Label>
        <asp:TextBox ID="latitude" runat="server" ></asp:TextBox> <br /><br />
         <asp:Label ID="Label2" runat="server" Text="Longitude: "></asp:Label>
        <asp:TextBox ID="longitude" runat="server" ></asp:TextBox> <br />
        <h2>E. Invoke Buttons: </h2>
        <asp:Button ID="MapServi" runat="server" Text="Map Service" OnClick="MapServi_Click"  />
        <h2>F. Service Response: </h2>
        <asp:Label ID="Output" runat="server" Text=" Output will appear here."></asp:Label><br /><br />
        <asp:Label ID="Label3" runat="server" Text="Static URL: "></asp:Label>
        <asp:Label ID="staticurl" runat="server" Text="Value "></asp:Label><br />
        <asp:Image ID="StaticImage" runat="server" AlternateText="Map to Display: None." /><br /><br /><br /><br />
        <asp:Label ID="Label4" runat="server" Text="StreetView URL: "></asp:Label>
        <asp:Label ID="streetviewurl" runat="server" Text="Value "></asp:Label><br />
        <asp:Image ID="StreetImage" runat="server" AlternateText="Map to Display: None." />
    </div>
    </form>
</body>
</html>
