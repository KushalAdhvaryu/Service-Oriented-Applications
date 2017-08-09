<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MemberRegister.aspx.cs" Inherits="MemberRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function setFocus(e) {

            if (e.keyCode == 13)
                document.getElementById("btn_Submit").click();

        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        
    <div>
    <h1>Member Registration</h1>
        <p><a href="Home.aspx">Home</a></p>
        <asp:Label runat="server" Text="Username     "></asp:Label> 
                <asp:TextBox ID="tbusr_name" runat="server" Height="16px"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ErrorMessage="Enter username" ControlToValidate="tbusr_name"></asp:RequiredFieldValidator><br /><br />
        <asp:Label runat="server" Text="Email      "></asp:Label>
                <asp:TextBox ID="tbemail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ErrorMessage="Enter Email" ControlToValidate="tbemail"></asp:RequiredFieldValidator><br /><br />
        <asp:Label runat="server" Text="Password     "></asp:Label> 
                <asp:TextBox ID="tbpsd"  TextMode="password" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ErrorMessage="Enter Password" ControlToValidate="tbpsd"></asp:RequiredFieldValidator><br /><br />
        <asp:Label runat="server" Text=" Confirm Password"></asp:Label>
                <asp:TextBox ID="tbcpsd"  TextMode="password" runat="server" onkeypress="setClick(event)"></asp:TextBox><br /><br />

        <br /><br />
        <asp:Button ID="btn_Submit" runat="server" Text="Register " OnClick="btn_Submit_Click" /><br /><br />
        <asp:Label ID="errMsg" runat="server" Text=" "></asp:Label>
    </div>
    </form>
</body>
</html>
