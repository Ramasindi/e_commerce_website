<%@ Page Title="Register" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="S219002358_P05.RegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />	
    <div class="container border text-dark">
  <h1>Register Your Account Below</h1>
 
  <form id="registerForm" runat="server">
    <div class="form-group input-group-lg">
      <input type="email" required class="form-control" id="reg_email" runat="server" placeholder="Enter Email">
    </div>
    <div class="form-group input-group-lg">
      <input type="password" required class="form-control" id="reg_password" runat="server" placeholder="Enter Password">
    </div>
      <div class="form-group input-group-lg">
      <input type="password" required class="form-control" id="reg_passwordConfirm" runat="server" placeholder="Re-Enter Password">
    </div>
    <div>
        <div class="alert alert-danger" id="reg_alert" runat="server">
      
        </div>
    </div>
    <div class="form-group input-group-lg">
         <asp:Button class="btn btn-primary btn-lg" ID="register" runat="server" Text="REGISTER" OnClick="Button1_Click" />
        <div class="form-group float-right">
            <select  id="userType" runat="server">
              <option>Customer</option>
              <option>Manager</option>
            </select>
         </div>
       
    </div>
  </form>
       <br />
</div>
    <br /> <hr />
</asp:Content>
