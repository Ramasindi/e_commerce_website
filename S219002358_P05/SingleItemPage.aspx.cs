using S219002358_P05.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace S219002358_P05
{
    public partial class SingleItemPage : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.Params["id"]);
            var prod = client.getProduct(id);
            product_name.InnerText = prod.ProductName;
            des.InnerText = prod.ProductDescription;
            price.InnerText = "R" +prod.ProductPrice;
            img.InnerHtml = "<img src='"+prod.ProductImage+"' alt=''>";
        }

        protected void AddToCart_Click(object sender, EventArgs e)
        {
            //cart
            if (string.IsNullOrEmpty(Session["UserEmail"] as string))
            {
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                int id = int.Parse(Request.Params["id"]);
                int quantity = int.Parse(quantity_input.Value);
                client.CartInsert(Session["UserEmail"] as string,id , quantity);
                Response.Redirect("Cart.aspx?id=" + Request.Params["id"] + "&quantity=" + quantity_input.Value);
            }
           
        }
    }
}