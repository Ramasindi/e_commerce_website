<%@ Page Title="Admin" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ManageProduct.aspx.cs" Inherits="S219002358_P05.ManageProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <br /><br />
              
        	<div class="container border text-dark">
                <h1>Add Product</h1>
                <br />
                <form id="productForm" runat="server">
                    <div class="form-group">
                        <label for="name">Enter Product Name:</label>
                        <input type="text" class="form-control" id="name" runat="server" placeholder="Product Name" required>
                      </div>
                      <div class="form-group">
                        <label for="image">Choose Product Image:</label>
                        <input type="file" class="form-control" id="image" runat="server" name="image" required>
                      </div>
                      <div class="form-group">
                        <label for="price">Enter Product Price:</label>
                        <input type="text" class="form-control" id="price" runat="server" placeholder="Product Price" required>
                      </div>
                      <div class="form-group">
                        <label for="productDescription">Enter Product Description:</label>
                        <input type="text" class="form-control" id="productDescription" runat="server" placeholder="Product Description" required>
                      </div>
                      <div class="form-group">
                        <label for="quantity">Enter Product Quantity:</label>
                        <input type="number"  class="form-control" id="quantity"  min="0" runat="server" placeholder="Product Quantity" required>  
                      </div>
                         <div>
                            <div class="alert alert-success" id="add_alert" runat="server">
      
                            </div>
                        </div>
                     
                      <asp:Button ID="addProduct" runat="server" class="btn btn-primary btn-lg"  Text="Add Product +" OnClick="addProduct_Click" />
                    <div class="form-group float-right">
                        <a class="link" href="EditProduct.aspx">Click here to Update Products</a>
                 </div>
                </form>
                <br />
                
            </div>
             

</asp:Content>
