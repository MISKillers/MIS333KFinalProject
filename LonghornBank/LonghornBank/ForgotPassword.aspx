<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ForgotPassword.aspx.vb" Inherits="LonghornBank.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Forgot your password?
    
        <br />
        <br />
    
    </div>

    <div>


        Email Address:
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        &nbsp;<br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Birthday:
        <asp:TextBox ID="txtBirthday" runat="server"></asp:TextBox>


    &nbsp;<br />
        </div>
        <div>


            <asp:Label ID="lblError" runat="server" Text="[error]"></asp:Label>
            <br />


        </div>
    <div>


        <asp:Button ID="btnSend" runat="server" Text="Send Password to Email" />


    </div>
    </form>
</body>
</html>
