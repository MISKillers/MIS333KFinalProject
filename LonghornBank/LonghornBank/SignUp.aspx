<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SignUp.aspx.vb" Inherits="LonghornBank.SignUp" %>

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

    <form id="form1" runat="server">

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
<div class="container" style="margin: 50px;" text-align:"center">
      <div class="row"><h2>Sign Up to be a Customer</h2></div>
<form role="form" text-align:"center">
  <div class="form-group">
    <label for="exampleInputEmail">Email Address/Username</label>
    <asp:TextBox ID="txtEmail" class="form-control" runat="server" Width="210px" placeholder="Email Address"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="exampleInputPassword">Password</label>
    <asp:TextBox ID="txtPassword" class="form-control" runat="server" Width="210px" placeholder ="Password"></asp:TextBox>
  </div>
   <div class="form-group">
    <label for="exampleInputFirstName">First Name</label>
    <asp:TextBox ID="txtFirstName" class="form-control" runat="server" Width="210px" placeholder="First Name"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="exampleInputInitial">Middle Initial</label>
    <asp:TextBox ID="txtInitial" class="form-control" runat="server" Width="210px" placeholder="Middle Initial"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="exampleInputLastName">Last Name</label>
    <asp:TextBox ID="txtLastName" class="form-control" runat="server" Width="210px" placeholder="Last Name"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="exampleInputBirthdayYear">Year of Birth</label>
    <asp:TextBox ID="txtBirthday" class="form-control" runat="server" Width="210px" placeholder="Year of Birth"></asp:TextBox>
  </div>
    <div class="form-group">
    <label for="exampleInputBirthdayYear">Address</label>
    <asp:TextBox ID="txtAddress" class="form-control" runat="server" Width="210px" placeholder="Address"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="exampleInputCity">City</label>
    <asp:TextBox ID="txtCity" class="form-control" runat="server" Width="210px" placeholder="City"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="exampleInputState">State</label>
    <asp:TextBox ID="txtState" class="form-control" runat="server" Width="210px" placeholder="State"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="exampleInputZipcode">Zipcode</label>
    <asp:TextBox ID="txtZip" class="form-control" runat="server" Width="210px" placeholder="Zipcode"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="exampleInputPhone">Phone number</label>
    <asp:TextBox ID="txtPhone" class="form-control" runat="server" Width="210px" placeholder="Phone"></asp:TextBox>
  </div>

  <div class="form-group">
      <asp:Button ID="btnSubmit" type="button" runat="server" PostBackUrl="~/MyAccounts.aspx" Text="Submit"  class="btn btn-primary" Height="40px" Width="210px"/>
  </div>
</form>
 </div>
       

  <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
  <script src="js/jquery.js"></script>

  <!-- Include all compiled plugins (below), or include individual files as needed -->
  <script src="js/bootstrap.min.js"></script>
 </form>
</body>

</html>
