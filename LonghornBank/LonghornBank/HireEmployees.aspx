<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/EmployeeMaster.Master" CodeBehind="HireEmployees.aspx.vb" Inherits="LonghornBank.HireEmployees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin: 50px;" text-align:"center">
      <div class="row"><h2>Hire New Employee!</h2></div>
<form role="form" text-align:"center">
  <div class="form-group">
    <label for="exampleInputEmail">First Name</label>
    <asp:TextBox ID="txtCustNumber" class="form-control" runat="server" Width="210px" ReadOnly="True"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="exampleInputEmail">Middle Initial </label>
&nbsp;<asp:TextBox ID="txtEmail" class="form-control" runat="server" Width="210px" placeholder="Email Address"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="exampleInputPassword">Last Name</label>
    <asp:TextBox ID="txtPassword" class="form-control" runat="server" Width="210px" placeholder ="Password"></asp:TextBox>
  </div>
   <div class="form-group">
    <label for="exampleInputFirstName">Password</label>
    <asp:TextBox ID="txtFirstName" class="form-control" runat="server" Width="210px" placeholder="First Name"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="exampleInputInitial">SSN</label>
    <asp:TextBox ID="txtInitial" class="form-control" runat="server" Width="210px" placeholder="Middle Initial"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="exampleInputLastName">Employee Type</label>
      <br />
      <asp:DropDownList ID="DropDownList1" runat="server">
          <asp:ListItem Value="101">Employee</asp:ListItem>
          <asp:ListItem Value="102">Manager</asp:ListItem>
      </asp:DropDownList>
  </div>
  <div class="form-group">
    <label for="exampleInputBirthdayYear">Address</label>
    <asp:TextBox ID="txtBirthday" class="form-control" runat="server" Width="210px" placeholder="Year of Birth"></asp:TextBox>
  </div>
    <div class="form-group">
    <label for="exampleInputBirthdayYear">Zip Code</label>
    <asp:TextBox ID="txtAddress" class="form-control" runat="server" Width="210px" placeholder="Address"></asp:TextBox>
  </div>
  <div class="form-group">
    <label for="exampleInputZipcode">Phone Number</label>
    <asp:TextBox ID="txtZip" class="form-control" runat="server" Width="210px" placeholder="Zipcode"></asp:TextBox>
  </div>
     <div class="form-group">
    <label for="exampleInputZipcode">EmployeeID</label>
    <asp:TextBox ID="TextBox1" class="form-control" runat="server" Width="210px" placeholder="Zipcode"></asp:TextBox>
  </div>


  <div class="form-group">
      <asp:Button ID="btnSubmit" type="button" runat="server" Text="Submit"  class="btn btn-primary" Height="40px" Width="210px"/>
  </div>
</form>
 </div>
       

  <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
  <script src="js/jquery.js"></script>

  <!-- Include all compiled plugins (below), or include individual files as needed -->
  <script src="js/bootstrap.min.js"></script>
 </form>
</asp:Content>
