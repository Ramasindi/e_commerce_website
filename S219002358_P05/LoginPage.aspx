<%@ Page Title="Login" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="S219002358_P05.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />
	<div class="container border">
  <h1>Login To Your Account Below</h1>
 
  <form id="loginForm" runat="server">
    <div class="form-group input-group-lg">
      <input type="email" required class="form-control" id="email" runat="server"  placeholder="Enter Email">
    </div>
    <div class="form-group input-group-lg">
      <input type="password" required class="form-control" id="password" runat="server" placeholder="Enter Password">
    </div>
       <div>
        <div class="alert alert-danger" id="log_alert" runat="server">
      
        </div>
    </div>
    <div class="form-group input-group-lg">
        <asp:Button class="btn btn-primary btn-lg" ID="login" runat="server" Text="LOGIN" OnClick="login_Click" />
    </div>
  </form>
       <br />
</div>
    <br /> <hr />
</asp:Content>
