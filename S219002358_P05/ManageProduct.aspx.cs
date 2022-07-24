using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace S219002358_P05
{
    public partial class ManageProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            add_alert.Visible = false;
        }

        protected void addProduct_Click(object sender, EventArgs e)
        {
            var productName = name.Value;
            var productImage = image.Value;
            var productPrice = price.Value;
            var productDes = productDescription.Value;
            var productQuantity = quantity.Value;

        }
    }
}