<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CheckingAccountDetails.aspx.vb" Inherits="LonghornBank.CheckingAccountDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
         <label for="CheckingAccountDetails" style="font-size: 22px">Checking Account Details</label><br />
        <br />
        
        <label for="Search">Search By:</label><br />
        <br />

        <label for="Description">Description:</label>
        <asp:TextBox ID="txtDescription" class="form-control" runat="server" Width="210px" placeholder="Description:"></asp:TextBox>
        <br />
        <label for="TransType">Transaction Type:</label>
        <asp:DropDownList ID="ddlTransferType" class="form-control" runat="server">
        </asp:DropDownList>
        <br />
        <label for="Amount">Amount:</label>
         <asp:TextBox ID="txtTransferAmount" class="form-control" runat="server" Width="210px" placeholder="Transfer Amount"></asp:TextBox>
        <br />
        <label for="TransNumber">Transaction Number:</label>
         <asp:TextBox ID="txtTransNumber" class="form-control" runat="server" Width="210px" placeholder="Transfer Number"></asp:TextBox>
        <br />
        <label for="Date">Date:</label>
         
&nbsp;<br />
         <asp:Calendar ID="Calendar1" class="form-control" runat="server"></asp:Calendar>
         <br />
         <asp:Button ID="btnSearch" runat="server" class="btn btn-primary" Height="40px" Text="Search" type="button" Width="210px" />
         <br />
        <br />
        <asp:GridView ID="GridView1" class="form-control" runat="server">
        </asp:GridView>


    </div>
    </form>
</body>
</html>
