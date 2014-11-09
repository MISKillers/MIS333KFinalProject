<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Welcome.aspx.vb" Inherits="LonghornBank.Welcome" %>

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
	      <img alt="Logo black"src="longhornbanklogo2lowpixel.png" /></a>

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

<div class="jumbotron" style="font-family: Cambria; color: #FF6600; font-weight: bold; top: 75px; left: 0px; height: 459px;">
                 &nbsp;<h1 style="color: #DF5400; font-family: 'Segoe UI'; font-weight: bold">Welcome to Longhorn Bank!</h1>
       
        
            <div class="form-group">
        <asp:TextBox ID="txtUsernameLogin" class="form-control" runat="server" Width="210px" placeholder="Email Address/Username"></asp:TextBox>
                <br />
        <asp:TextBox ID="txtPasswordLogin" class="form-control" runat="server" Width="210px" placeholder="Password"></asp:TextBox>
            <br />
 
&nbsp;&nbsp;
        <asp:Button ID="btnLogin" type="button" runat="server" Text="Login"  class="btn btn-default" Height="40px"/>
&nbsp;&nbsp;
        <asp:Button ID="btnSignUp" type="button" runat="server" PostBackUrl="~/SignUp.aspx" Text="Sign Up"  class="btn btn-default" Height="40px" Width="101px"/>
        &nbsp;&nbsp;&nbsp;<br />
                <br />
                &nbsp;
                <div text-align:"center">
                <asp:Label ID="lblError" runat="server" text-align="center" Text=" error " Visible="False" class="bg-danger" Font-Names="Segoe UI" ForeColor="#666666" Height="23px" Width="202px"></asp:Label></div>
                <br />
        <asp:Button ID="btnForgot" type="button" runat="server" PostBackUrl="~/ForgotPassword.aspx" Text="Forgot Username/Password?"  class="btn btn-primary" Height="40px" Width="210px"/>

                <br />
        <br />
        </div>
                 <br />
      

  
        <br />

        <br />
</div>
     
        <div top:"450px">
        <div class ="container" >
        <div  id="row"> 

                <div class="col-md-3"> <a href="" class="bigthumbs">
                                                    <img src="checking.jpg"  class ="img-responsive img-center"/>
                                            </a>
                                            <h2><a href="#">Checking Account</a></h2>
                                                                <p>Lorem ipsum turpis molestie magna tristique convallis leo torquent, mollis diam cras tempus id habitant dictu,. eleifend aenan nisl convalis icaulis urna sapien.</p>
                                    </div>
                <div class="col-md-3"> <a href="" class="bigthumbs">
                                                    <img src="savings.jpg"  class ="img-responsive img-center"/>
                                            </a>
                                            <h2><a href="#">Savings Account</a></h2>
                                                                <p>Save money here and we oferakhdflajsdlfjasldjfoa;dv;kan;awheohr;</p>
                                    </div>
                <div class="col-md-3"> <a href="" class="bigthumbs">
                                                    <img src="stocks.jpg" class ="img-responsive img-center"/>
                                            </a>
                                            <h2><a href="">Stock Portfolio</a></h2>
                                                                <p>We guarantee return on your investment like nowhere else! Invest here now</p>
                                    </div>
                <div class="col-md-3"> <a href="" class="bigthumbs">
                                                    <img src="retirement.jpg"  class ="img-responsive img-center"/>
                                            </a>
                                            <h2>Individual Retirement Accoun</h2>
                                                                <p>We ensure you live comfotably through your old age and blakdikals</p>
                                    </div>
            </div>            
       </div>        
    </div>
        

          <script src="scripts/jquery-1.9.1.js"></script>
           <script src="scripts/bootstrap.js"> </script>
            
    </form>
</body>
</html>
        