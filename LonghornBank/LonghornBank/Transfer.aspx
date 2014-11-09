<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Transfer.aspx.vb" Inherits="SendEmail.Transfer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        From:
        <asp:DropDownList ID="ddlTransferFrom" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        To:<br />
        <asp:DropDownList ID="ddlTransferTo" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        Amount:<br />
        <asp:TextBox ID="txtTransferAmount" runat="server"></asp:TextBox>
        <br />
        <br />
        Transfer Date:<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        [e.g. 10/24/14]<br />
        <br />
        <asp:Button ID="btnMakeTranfer" runat="server" Text="Transfer" OnClientClick="return confirm('Are you sure you want to submit ?')"/>
        <br />
        </div>
    </form>
            
</body>

</html>
