<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Deposits.aspx.vb" Inherits="LonghornBank.Deposits" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

         <label for="Deposit" style="font-size: 22px">Deposit</label><br />
         <br />

         <label for="Account">Account:</label><br />
        <asp:DropDownList ID="ddlDepositAccount" class="form-control" runat="server">
        </asp:DropDownList>
        <br />
    
        <label for="Amount">Amount:</label>
    <asp:TextBox ID="txtDepositAmount" class="form-control" runat="server" Width="210px" placeholder="Deposit Amount"></asp:TextBox>

         <br />

         <asp:Button ID="btnMakeDeposit" type="button" runat="server" Text="Make Deposit" class="btn btn-primary" Height="40px" Width="210px"/>

    </div>
    </form>
</body>
</html>
