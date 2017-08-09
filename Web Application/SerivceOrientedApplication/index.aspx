<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid text-center">
<div class ="row">
    <p class="lead"><strong><a href="Home.aspx">Home</a></strong></p>
<h1 class="text-center">Assignment 5</h1>
<br/> <br/>


<H1 class="text-center"> Component Testing </H1> 
<TABLE class="table table-hover table-striped">

 <TR>
      <TH COLSPAN="2" ALIGN="Left">
         <BR>This page is developed at: <a href="http://webstrar3.fulton.asu.edu/index.html"> http://webstrar3.fulton.asu.edu/index.html </a>
      </TH>
   </TR>
   <TR>
      <TH COLSPAN="2" ALIGN="Left">
         <BR>Test all Components at: <a href="http://webstrar3.fulton.asu.edu/page6/Home.aspx"> http://webstrar3.fulton.asu.edu/page6/Home.aspx </a>
      </TH>
   </TR>
   <TR>
      <TH COLSPAN="2" ALIGN="Left">
         <BR>This project is developed by: Kushal Adhvaryu 
      </TH>
   </TR>
   <TR>
      <TH>Component Name</TH>
      <TH>Steps to Test.</TH>
	  
   </TR>
   <TR>
      <TD>Public Page</TD>
      
	  <TD><ul class="text-left">
	  <li>Naivgate using link given at top of table.</li>
	  <li>Click Public Page.</li>
	  </ul></TD>
	 
   </TR>
   <TR>
      <TD>Member</TD>
      
	  <TD><ul class="text-left">
	  <li>Naivgate using link given at top of table.</li>
	  <li>Self Subscribe using Member Register Option. (Image verifier service is implemented here.)</li>
	  <li>Member Page: You will be Authneticated for Member Credentials. Only Member can access this page.</li>	  
	  <li>For Testing Purpose: Credentials Username: abc Password: 123</li>
	  </ul></TD>
	 
   </TR>
   <TR>
      <TD>Staff</TD>
      
	  <TD><ul class="text-left">
	  <li>Naivgate to Home page using link given at top of table.</li>
	  
	  <li>Staff Page:You will be Authneticated and Authorized for accessing Protected staff page. </li>
	  <ul class="text-left">
		<li> Credentials to Test Username: staff, Password: staff. </li>
		<li>Staff can access Weather Service to help customer with information. </li>
	  </ul>
	  <li>Admin Page:You will be Authneticated and Authorized for accessing Protected staff page.</li>
	  <ul class="text-left">
	  <li> Credentials to Test Username: admin, Password: admin. </li>
		<li>Admin can access Crime Service to track criminal activities occuring in area. </li>
	  </ul>
	  </ul></TD>
	 
   </TR>
   <TR>
      <TD>DLL</TD>
      
	  <TD><ul class="text-left">
	  <li>Naivgate using link given at top of table.</li>
	  <li>Click Member Register. Verify Image Verifier.</li>
	  <li>When you enter inputs and Register. UserData XML file (App_Data folder) Password tag is encrypted.</li>
	  <li>Similarly authentication mechanism implemented in XML handler utilizes Decryption method to verify password. </li>
	  </ul></TD>
	 
   </TR>
   <TR>
      <TD>Services </TD>
      
	  <TD>
	  <ul class="text-left">
	  <li> Refer to Serivce Dictionary part on this page for information on particular serivce. </li>
	  <li> Implemented at Member page. </li>	
	  <ul class="text-left">
	  <li>Public Service:Zipcode to Latitude and Longitude Service.  </li>
	  <li>Self Developed Service: RESTful Nearest Restaurants  </li>
	  <li>Self Developed Service: Location display on Map  </li>  
	  </ul>
	  </ul>
	   <ul class="text-left">
	  <li> Implemented at  Protected Staff Page. </li>	
	  <ul class="text-left">
	  <li>Self Developed Service: Weather Details  </li>  
	  </ul>
	  </ul>
	  <ul class="text-left">
	  <li> Implemented at  Protected Admin Page. </li>	
	  <ul class="text-left">
	  <li>Self Developed Service: Crime Details  </li>  
	  </ul>
	  </ul>
	  </TD>
	 
   </TR>
   <TR>
      <TD>Data Management </TD>
      
	  <TD><ul class="text-left">
	  <li>UserData.xml : Permanent state for storing the user names, passwords,email and type of user. New user will be appended with type member. File under App_data folder. </li>
	  <li>Cookie: Is implemented on Member Page for Zipcode. On latitude and longitude service cookie stores Zipcode. </li>  
	  <ul class="text-left">
	  <li>Testing Step.  </li>  
	  <li>Access Member page using Credentials Username: abc Password: 123 </li>  
	  <li>Enter Zipcode : 85281 invoke Latitude and Longitude Serivce. </li>
	  <li>Using Home Button. Nabigate to Home page. </li>
	  <li>From Home page, navigate to member page.</li>
	  <li>Member Page shows 85281 as Previously entered Zipcode via Cookie.</li>
	  </ul>
	  <li>Session:Welcome Header on Member page use Session to display username. </li>  
	  </ul></TD>
	 
   </TR>
   <TR>
      <TD>Deployment</TD>
      
	  <TD class="text-left">Project Live at : <a href="http://webstrar3.fulton.asu.edu/page6/Home.aspx"> http://webstrar3.fulton.asu.edu/page6/Home.aspx </a> </TD>
	 
   </TR>
   <TR>
      <TD>BlackBoard</TD>
      
	  <TD class="text-left">Code Submission Done at BlackBoard.</TD>
	 
   </TR>
   

</TABLE>


<H1 class="text-center"> Service Dictionary </H1>

<H2 class="text-center"> Self Developed </H2>
<TABLE class="table table-hover table-striped">

  
 <TR>
      <TH COLSPAN="5" ALIGN="Left">
         <BR>This page is developed at: <a href="http://webstrar3.fulton.asu.edu/index.html"> http://webstrar3.fulton.asu.edu/index.html </a>
      </TH>
   </TR>
   <TR>
      <TH COLSPAN="5" ALIGN="Left">
         <BR>This project is developed by: Kushal Adhvaryu 
      </TH>
   </TR>
   <TR>
      <TH class="col-md-2">Provider Name</TH>
      <TH class="col-md-5">Service Name with Input and Output Types.</TH>
	  <TH class="col-md-2" >Try IT</TH>
	  <TH class="col-md-2">Service Description</TH>
	  <TH class="col-md-2">Planned Resource need to implement Service</TH>
   </TR>
   <TR>
      <TD>Kushal Adhvaryu</TD>
      <TD>(Required) Weather Service
			Input: string zipcode
			Output: list of weather information object.
	  </TD>
	  <TD><a href="http://webstrar3.fulton.asu.edu/page5/Weather.aspx"> http://webstrar3.fulton.asu.edu/page5/Weather.aspx</a></TD>
      <TD>For given zipcode provide 5 day weather information. </TD>
	  <TD>Use api from openweather map at: https://openweathermap.org/forecast5 </TD>
   </TR>
   <TR>
	  <TD>Kushal Adhvaryu</</TD>
      <TD>(Required & RESTful) Crime Data service
            Input : string longitutde,string latitude
			Output: List of object containing crime type, date and address.
	  </TD>
      <TD><a href="http://webstrar3.fulton.asu.edu/page5/CrimeService.aspx"> http://webstrar3.fulton.asu.edu/page5/CrimeService.aspx</a></TD>
	  <TD>This service provides Crime data based on user input for given Longitude and Latitude.</TD>
      <TD>Use service from Spot Crime at : http://api.spotcrime.com/crimes.json
</TD>
   </TR>
   <TR>
      <TD>Kushal Adhvaryu</</TD>
      <TD>(Elected & RESTful) Nearest Restaurants
			Input: string Zipcode
			Output: List of nearby restaurant objects.
	  </TD>
      <TD><a href="http://webstrar3.fulton.asu.edu/page4/NearbyRestaurants.aspx"> http://webstrar3.fulton.asu.edu/page4/NearbyRestaurants.aspx</a></TD>
	  <TD>Provide list of restaurants for given input locality.</TD>
      <TD>Use api from yelp at: https://www.yelp.com/developers/documentation/v2/search_api</TD>
   </TR>
   <TR>
      <TD>Kushal Adhvaryu</</TD>
      <TD>(Elected) Location display on Map
			Input: double longitutde, double latitude
			Output: string[] URL of map static, street view url.
	  </TD>
      <TD><a href="http://webstrar3.fulton.asu.edu/page4/LocationonMap.aspx"> http://webstrar3.fulton.asu.edu/page4/LocationonMap.aspx</a></TD>
	  <TD>Display given latitude and longitude on google maps as static image and street view image.</TD>
      <TD>Use api from Google developer at: https://developers.google.com/maps/
</TD>
   </TR>
</TABLE>
<br/> <br/>
<H2 class="text-center"> Public Service </H2>
<TABLE class="table table-hover table-striped">
 <TR>
      <TH COLSPAN="6" ALIGN="Left">
         <BR>This page is developed at: <a href="http://webstrar3.fulton.asu.edu/index.html"> http://webstrar3.fulton.asu.edu/index.html </a>
      </TH>
   </TR>
   <TR>
      <TH COLSPAN="6" ALIGN="Left">
         <BR>This project is developed by: Kushal Adhvaryu 
      </TH>
   </TR>
   <TR>
      <TH>Provider Name</TH>
      <TH>Service Name with Input and Output Types.</TH>
	  <TH>Try IT</TH>
	  <TH>Service Description</TH>
	  <TH>Instructions for Testing</TH>
	  <TH>Planned Resource need to implement Service</TH>
   </TR>
   <TR>
      <TD>Google</TD>
      <TD>(Public Service) Zipcode to Latitude and Longitude Service
			Input: string zipcode
			Output: list of location information object.
	  </TD>
	  <TD><a href="http://webstrar3.fulton.asu.edu/page6/Home.aspx"> http://webstrar3.fulton.asu.edu/page6/Home.aspx</a></TD>
      <TD>For given zipcode provide Latitude and Longitude. </TD>
	  <TD><ul>
	  <li>Naivgate using Try It link.</li>
	  <li>Access Member Page Credentials Username: abc Password: 123</li>
	  <li>Enter Input under Zipcode TextBox.</li>
	  <li>Invoke Service Via Lat Long Service Button.</li>
	  </ul></TD>
	  <TD>Use api from Google developer at: https://developers.google.com/maps/ </TD>
   </TR>

</table>

</div>
</div>
        </form>
 
</body>
</html>
