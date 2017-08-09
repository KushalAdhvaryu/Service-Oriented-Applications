<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffSignIn.aspx.cs" Inherits="StaffSignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function setFocus(e) {

            if (e.keyCode == 13) {
                alert("Enter Key Pressed");
                document.getElementById("btn_Login").click();
            }
               

        }
    </script>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="btn_Login">
    <div>
    <h1>Login Page</h1>
        <p><asp:Button ID="home" runat="server" Text="Home" OnClick="home_Click" CausesValidation="False"   /></p> 
        <asp:Label runat="server" Text="Username "></asp:Label> 
        <asp:TextBox ID="tbusr_name" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID="rfv_uname" ErrorMessage="Enter username" ControlToValidate="tbusr_name" ></asp:RequiredFieldValidator><br /><br />
        <asp:Label runat="server" Text="Password "></asp:Label>
        <asp:TextBox ID="tbpsd" TextMode="password" runat="server" onkeypress="setClick(event)"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ID= "rfv_password" ErrorMessage="Enter Password" ControlToValidate="tbpsd" ></asp:RequiredFieldValidator><br /><br />
        
        <asp:Button ID="btn_Login" runat="server" Text=" Login " OnClick="btn_Login_Click" />
        <br /><br />
        
        <asp:Label ID="lbl_loginErr" runat="server" Text=" "></asp:Label>
    </div>
  
    </form>
</body>
</html>
