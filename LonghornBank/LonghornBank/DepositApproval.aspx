<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/EmployeeMaster.Master" CodeBehind="DepositApproval.aspx.vb" Inherits="LonghornBank.DepositApproval" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
&nbsp;<asp:Label ID="Label1" runat="server" Text="Deposits Needing Approval:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="28px" Text="View All" />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
</asp:Content>
