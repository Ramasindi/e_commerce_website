using S219002358_P05.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace S219002358_P05
{
    public partial class LandingPage : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            HtmlGenericControl login = Master.FindControl("loginNav") as HtmlGenericControl;
            if (string.IsNullOrEmpty(Session["UserEmail"] as string))
            {
                             
            }
            var prod = client.getProducts();
            string featured = "";
            foreach (Product p in prod) {
                featured += "<div class='featured_slider_item' ><div class='border_active'></div><div class='product_item discount d-flex flex-column align-items-center justify-content-center text-center'>" +
                            "<div class='product_image d-flex flex-column align-items-center justify-content-center'><img src='"+p.ProductImage+"' alt=''></div>" +
                            "<div class='product_content'><div class='product_price discount'>$225<span>$"+p.ProductPrice+"</span></div>" +
                            "<div class='product_name'><div><a href='SingleItemPage.aspx?id="+p.ProductId+"'> "+p.ProductName+"</a></div></div>" +
                            "<div class='product_extras'><div class='product_color'><input type='radio' checked name='product_color' style='background:#b19c83'>" +
                            "<input type='radio' name='product_color' style='background:#000000'><input type='radio' name='product_color' style='background:#999999'>" +
                            "</div><button class='product_cart_button' onclick='addToCart("+p.ProductId+")'>Add to Cart</button></div></div><div class='product_fav'><i class='fas fa-heart'></i></div>" +
                            "<ul class='product_marks'><li class='product_mark product_discount'>-25%</li><li class='product_mark product_new'>new</li></ul></div></div>";
            }
            featuredFromDB.InnerHtml = featured;

        }
    }
}