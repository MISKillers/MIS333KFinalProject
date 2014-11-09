<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RegisterAccount.aspx.vb" Inherits="LonghornBank.RegisterAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
     <title>Longhorn Bank</title>
            <meta name="viewport" content="width=device-width, initial-scale=1.0" />
            <!-- Bootstrap -->
            <link href="Content/bootstrap.css" rel="stylesheet" />

            <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
            <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
            <!--[if lt IE 9]>
              <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
              <script src="https://oss.maxcdn.com/libs/respond.js/1.3.0/respond.min.js"></script>
            <![endif]-->
    </head>
<body>
    <form id="form2" runat="server">

        <nav class="navbar navbar-fixed-top navbar-default" role="navigation" id="nav-wrapper-top">
  <div class="container">
    <div class="navbar-header">
      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-ex1-collapse">
        <span class="sr-only">Toggle navigation</span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
      </button>
        <br />
<a class="brand" href="http://classweb2.mccombs.utexas.edu/mis333k/msbcs549/LonghornBank/Welcome.aspx">
	      <img alt="Logo black"src="longhornbanklogo2lowpixel.png" width="225" height="50" /></a>

        <br />

    </div>

    <div class="collapse navbar-collapse navbar-ex1-collapse navbar-right">
      <ul class="nav navbar-nav">
        <li><a href="http://classweb2.mccombs.utexas.edu/mis333k/msbcs549/LonghornBank/EmployeeLogin.aspx">Employee Login</a></li>
<%--        <li><a href="#features">Features</a></li>
        <li><a href="#pricing">Pricing</a></li>--%>
      </ul>
    </div><!-- /.navbar-collapse -->
  </div><!-- /.container -->
</nav> 
<div class="container" style="margin: 50px; height: 578px;" text-align:"center">
      <div class="row"><h2>Register an account for one of our products </h2>
      </div>
    
    
    <div class="checkbox">
    <asp:CheckBox ID="chkCheckingAcc" type="checkbox" runat="server" value="" Text="Checking Account" Font-Size="Medium"/>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Initial Deposit Amount :&nbsp;
        <asp:TextBox ID="txtDepositChecking" runat="server"></asp:TextBox>
        &nbsp;
        <asp:Label ID="lblErrorChecking" runat="server" Text="*"></asp:Label>
        <br />
        <br />
   <div class="checkbox">
    <asp:CheckBox ID="chkSavingAcc" type="checkbox" runat="server" value="" Text="Savings Account" Font-Size="Medium"/>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Initial Deposit Amount :&nbsp;
        <asp:TextBox ID="txtDepositSavings" runat="server"></asp:TextBox>
        &nbsp;
       <asp:Label ID="lblErrorSavings" runat="server" Text="*"></asp:Label>
       <br />
        <br />
    </div>
    <div class="checkbox">
    <asp:CheckBox ID="chkIRA" type="checkbox" runat="server" value="" Text="Individual Retirement Account" Font-Size="Medium"/>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Initial Deposit Amount :&nbsp;
        <asp:TextBox ID="txtDepositIRA" runat="server"></asp:TextBox>
         &nbsp;
       <asp:Label ID="lblErrorIRA" runat="server" Text="*"></asp:Label>
        <br />
        <br />
    </div>
    <div class="checkbox">
    <asp:CheckBox ID="chkStock" type="checkbox" runat="server" value="" Text="Stock Portfolio" Font-Size="Medium"/>
    </div>

  <div class="form-group">
      &nbsp;<div class="form-group">
          <asp:Label ID="lblMessage" runat="server" class="bg-success" Font-Names="Segoe UI" ForeColor="#666666" Height="23px" Text=" message " text-align="center" Visible="False" Width="422px"></asp:Label>
      </div>
      <br />
      <asp:Button ID="btnSubmit" type="button" runat="server" PostBackUrl="~/MyAccounts.aspx" Text="Submit"  class="btn btn-primary" Height="40px" Width="106px"/>
      <br />
      <br />
  </div>
  
</div>

    </form>
</body>
</html>
