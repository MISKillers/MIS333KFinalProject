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
        <nav class="navbar navbar-default" role="navigation">
  <div class="container-fluid">
    <!-- Brand and toggle get grouped for better mobile display -->
    <div class="navbar-header">
      <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
        <span class="sr-only">Toggle navigation</span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
      </button>
        <asp:LinkButton ID="lnkSignUp" runat="server" PostBackUrl="~/SignUp.aspx">Sign Up</asp:LinkButton>
    </div>

    <!-- Collect the nav links, forms, and other content for toggling -->
    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
      <ul class="nav navbar-nav navbar-right">
        <li><a href="#">Link</a></li>
        <li class="dropdown">
          <a href="#" class="dropdown-toggle" data-toggle="dropdown">Dropdown <span class="caret"></span></a>
          <ul class="dropdown-menu" role="menu">
            <li><a href="#">Action</a></li>
            <li><a href="#">Another action</a></li>
            <li><a href="#">Something else here</a></li>
            <li class="divider"></li>
            <li><a href="#">Separated link</a></li>
          </ul>
        </li>
      </ul>
    </div><!-- /.navbar-collapse -->
  </div><!-- /.container-fluid -->
</nav>

        <div class="container">
   <div class="jumbotron">
      <h1>Welcome to Longhorn Bank!</h1>
        Username:
        <asp:TextBox ID="txtUsernameLogin" runat="server"></asp:TextBox>
&nbsp; Password:
        <asp:TextBox ID="txtPasswordLogin" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btnLogin" runat="server" Text="Login" />
&nbsp;&nbsp;
        <asp:Button ID="btnSignUp" runat="server" PostBackUrl="~/MyAccounts.aspx" Text="Sign Up" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="lblError" runat="server" Text=" error " Visible="False"></asp:Label>

  
        <br />

       <asp:LinkButton ID="lnkForgot" runat="server">Forgot Username/ Password?</asp:LinkButton>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          </div>
       </div>
  
        <div class ="container">
        <div  id="row">

                <div class="col-md-3"> <a href="" class="bigthumbs">
                                                    <img src="http://agentstoday.org/wp-content/themes/colorway/images/1.jpg"/>
                                            </a>
                                            <h2><a href="#">Checking Account</a></h2>
                                                                <p>Lorem ipsum turpis molestie magna tristique convallis leo torquent, mollis diam cras tempus id habitant dictu,. eleifend aenan nisl convalis icaulis urna sapien.</p>
                                    </div>
                <div class="col-md-3"> <a href="" class="bigthumbs">
                                                    <img src="http://agentstoday.org/wp-content/themes/colorway/images/2.jpg"/>
                                            </a>
                                            <h2><a href="#">Savings Account</a></h2>
                                                                <p>Save money here and we oferakhdflajsdlfjasldjfoa;dv;kan;awheohr;</p>
                                    </div>
                <div class="col-md-3"> <a href="" class="bigthumbs">
                                                    <img src="http://agentstoday.org/wp-content/themes/colorway/images/3.jpg"/>
                                            </a>
                                            <h2><a href="">Stock Portfolio</a></h2>
                                                                <p>We guarantee return on your investment like nowhere else! Invest here now</p>
                                    </div>
                <div class="col-md-3"> <a href="" class="bigthumbs">
                                                    <img src="http://agentstoday.org/wp-content/themes/colorway/images/4.jpg"/>
                                            </a>
                                            <h2><a href=""> Individual Retirement Account</a></h2>
                                                                <p>We ensure you live comfotably through your old age and blakdikals</p>
                                    </div>
            </div>            
       </div>        

        

          <script src="scripts/jquery-1.9.1.js"></script>
           <script src="scripts/bootstrap.js"> </script>
    </form>
</body>
</html>