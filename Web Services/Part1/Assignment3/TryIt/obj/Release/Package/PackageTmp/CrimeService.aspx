<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrimeService.aspx.cs" Inherits="TryIt.CrimeService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

     <h1 >Required Service 2: Crime Data (RESTful)</h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="http://webstrar3.fulton.asu.edu/index.html">Home Page:  http://webstrar3.fulton.asu.edu/index.html </a>
        <h2>A. Description: This service provides Crime data based on user input for given Longitude and Latitude.</h2> <br />
        <h2>B. URL: http://webstrar3.fulton.asu.edu/page3/Service1.svc/crimedata?latitude={latitude}&longitude={longitude} </h2> <br />
        <h2>C. Method Name: CrimeInfo </h2> <br />
            <h3> Parameter Type: (string) Latitude, (string) Longitude (Search works for USA only.)</h3><br />
            <h3> Return Type: Crime data Object in form of List of object containing crime (string) type,(string) date and (string) address.</h3><br />
        <h2>D. User Inputs: </h2>
        <asp:Label ID="Label1" runat="server" Text="Latitude: "></asp:Label>
        <asp:TextBox ID="latitude" runat="server" ></asp:TextBox> <br /><br />
         <asp:Label ID="Label2" runat="server" Text="Longitude: "></asp:Label>
        <asp:TextBox ID="longitude" runat="server" ></asp:TextBox> <br />
        <h2>E. Invoke Buttons: </h2>
        <asp:Button ID="CrimeServi" runat="server" Text="Crime Service" OnClick="CrimeServi_Click"  />
        <h2>F. Service Response: </h2>
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


        <!--<asp:Label ID="lblViolentCrime" runat="server" Text="Violent Crime : "></asp:Label>
        <asp:Label ID="ViolentCrime" runat="server" Text=" "></asp:Label><br />
        <asp:Label ID="lblMurder" runat="server" Text="MurderAndManslaughter : "></asp:Label>
         <asp:Label ID="Murder" runat="server" Text=" "></asp:Label><br /> 
        <asp:Label ID="lblRape" runat="server" Text="ForcibleRape : "></asp:Label>
         <asp:Label ID="Rape" runat="server" Text=" "></asp:Label><br />
        <asp:Label ID="lblRobbery" runat="server" Text="Robbery : "></asp:Label>
         <asp:Label ID="Robbery" runat="server" Text=" "></asp:Label><br />
        <asp:Label ID="lblAssualt" runat="server" Text="AggravatedAssault: "></asp:Label>
         <asp:Label ID="Assualt" runat="server" Text=" "></asp:Label><br />
        <asp:Label ID="lblProperty" runat="server" Text="PropertyCrime : "></asp:Label>
         <asp:Label ID="Property" runat="server" Text=" "></asp:Label><br />
        <asp:Label ID="lblBurgalry" runat="server" Text="Burglary : "></asp:Label>
         <asp:Label ID="Burgalry" runat="server" Text=" "></asp:Label><br />
        <asp:Label ID="lblLarceny" runat="server" Text="LarcenyTheft : "></asp:Label>
         <asp:Label ID="Larceny" runat="server" Text=" "></asp:Label><br />
        <asp:Label ID="lblMotorVehicle" runat="server" Text="MotorVehicleTheft: "></asp:Label>
         <asp:Label ID="MotorVehicle" runat="server" Text=" "></asp:Label><br />
        <asp:Label ID="lblArson" runat="server" Text="Arson : "></asp:Label>
         <asp:Label ID="Arson" runat="server" Text=" "></asp:Label><br /> -->
    </div>
    </form>
</body>
</html>
