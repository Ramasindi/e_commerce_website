<%@ Page Title="Admin" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditProduct.aspx.cs" Inherits="S219002358_P05.EditProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />
    <div class="container border text-dark">

                <h1>Update Product</h1>
                <br />
                <form id="produp" runat="server">
                      <div class="form-group">
                        <label for="productDescription">Enter Product Name:</label>
                        <input type="text" class="form-control" id="prodname" runat="server" placeholder="Product Name" required>
                      </div>
                      <div class="form-group">
                        <label for="imageUpdate">Choose Product Image:</label>
                        <input type="file" class="form-control" id="fileUpdate" runat="server" name="image" required>
                      </div>
                      <div class="form-group">
                        <label for="price">Enter Product Price:</label>
                        <input type="text" class="form-control" id="priceUpdate" runat="server" placeholder="Product Price" required>
                      </div>
                      <div class="form-group">
                        <label for="productDescription">Enter Product Description:</label>
                        <input type="text" class="form-control" id="productDescriptionUpdate" runat="server" placeholder="Product Description" required>
                      </div>
                      <div class="form-group">
                        <label for="quantity">Enter Product Quantity:</label>
                        <input type="number"  class="form-control" id="quantityUpdate"  min="0" runat="server" placeholder="Product Quantity" required>  
                      </div>
                         <div>
                            <div class="alert alert-success" id="update_Alert" runat="server">
                            </div>
                        </div>
                     <asp:Button class="btn btn-primary btn-lg" ID="UpdateProduct" runat="server" Text="Update Product +" OnClick="UpdateProduct_Click" />  
                    <div class="form-group float-right">
                        <a class="link" href="ManageProduct.aspx">Click here to Add Products</a>
                 </div>
                </form>
        <br /><br />
            </div>
</asp:Content>
