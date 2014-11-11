<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/EmployeeMaster.Master" CodeBehind="Disputes.aspx.vb" Inherits="LonghornBank.Disputes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Current Disputes:"></asp:Label>
&nbsp;&nbsp;&nbsp;
   <div class="form-group">
         <asp:Button ID="btnSubmit" type="button" runat="server" Text="View All"  class="btn btn-primary" Height="40px" Width="210px"/>
  </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/DisputeResolution.aspx">Specific Dispute</asp:LinkButton>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    
</asp:Content>
