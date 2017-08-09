<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Image_verify.aspx.cs" Inherits="Image_verify" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script type="text/javascript">
        function setFocus(e) {

            if (e.keyCode == 13)
                document.getElementById("verify").click();

        }
    </script>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="verify">
    <div>
    <h1>Image verifier</h1>
         <p><a href="Home.aspx">Home</a></p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image1" runat="server" /> <br /><br />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:TextBox ID="input" runat="server" onkeypress="setClick(event)"></asp:TextBox><br /><br />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="verify" runat="server" Text="Verify Image" OnClick="verify_Click" /><br /><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="output" runat="server" Text=" "></asp:Label>

    </div>
    </form>
</body>
</html>
