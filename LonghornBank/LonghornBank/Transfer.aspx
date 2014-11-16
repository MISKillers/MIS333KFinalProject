<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Transfer.aspx.vb" Inherits="LonghornBank.Transfer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
         <label for="Transfer" style="font-size: 22px">Transfer</label><br />
        <br />
    
        <label for="TransferFrom">Transfer From:</label><br />
        <asp:DropDownList ID="ddlTransferFrom" class="form-control" runat="server">
        </asp:DropDownList>
        <br />
        <br />

        <label for="TransferTo">Transfer To:</label><br />
        <asp:DropDownList ID="ddlTransferTo" class="form-control" runat="server">
        </asp:DropDownList>
        <br />
        <br />

        <label for="Transfer Date">Transfer Date:</label>
        <asp:Calendar ID="Calendar1" class="form-control" runat="server"></asp:Calendar>
       
        <br />

        <br />

        <label for="Amount">Amount:</label>
    <asp:TextBox ID="txtTransferAmount" class="form-control" runat="server" Width="210px" placeholder="Transfer Amount"></asp:TextBox>

        <br />

        <asp:Button ID="btnMakeTransfer" type="button" runat="server" Text="Make Transfer" OnClientClick="return confirm('Are you sure you want to submit ?')" class="btn btn-primary" Height="40px" Width="210px"/>

        <br />
        </div>
    </form>
            
</body>

</html>
