<%@ Page Title="Item" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SingleItemPage.aspx.cs" Inherits="S219002358_P05.SingleItemPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <!-- Single Product -->

	<div class="single_product">
		<div class="container">
			<div class="row">

				<!-- Selected Image -->
				<div class="col-lg-5 order-lg-2 order-1">
					<div class="image_selected" id="img" runat="server">
                    </div>
				</div>

				<!-- Description -->
				<div class="col-lg-5 order-3">
					<div class="product_description">
						<div class="product_name" id="product_name" runat="server"></div>
						<div class="product_text"><p id="des" runat="server"></p></div>
						<div class="order_info d-flex flex-row">
								<div class="clearfix" style="z-index: 1000;">

									<!-- Product Quantity -->
									<div class="product_quantity clearfix">
										<span>Quantity: </span>
										<input id="quantity_input" runat="server" type="number" title="" pattern="[0-9]*" value="1">
									</div>

								</div>

								<div class="product_price" id="price" runat="server"></div>
								<div class="button_container">
									<asp:Button ID="AddToCart"  class="button cart_button" runat="server" Text="Add to Cart" OnClick="AddToCart_Click" />
									<div class="product_fav"><i class="fas fa-heart"></i></div>
								</div>
								
						</div>
					</div>
				</div>

			</div>
		</div>
	</div>
	<script src="js/jquery-3.3.1.min.js"></script>
<script src="styles/bootstrap4/popper.js"></script>
<script src="styles/bootstrap4/bootstrap.min.js"></script>
<script src="plugins/greensock/TweenMax.min.js"></script>
<script src="plugins/greensock/TimelineMax.min.js"></script>
<script src="plugins/scrollmagic/ScrollMagic.min.js"></script>
<script src="plugins/greensock/animation.gsap.min.js"></script>
<script src="plugins/greensock/ScrollToPlugin.min.js"></script>
<script src="plugins/OwlCarousel2-2.2.1/owl.carousel.js"></script>
<script src="plugins/easing/easing.js"></script>
<script src="js/product_custom.js"></script>
    </form>
</asp:Content>
