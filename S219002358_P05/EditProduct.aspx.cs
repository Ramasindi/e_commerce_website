using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace S219002358_P05
{
    public partial class EditProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            update_Alert.Visible = false;
        }

        protected void UpdateProduct_Click(object sender, EventArgs e)
        {
            var name = prodname.Value;
            var file = fileUpdate.Value;
            var price = priceUpdate.Value;
            var productDes = productDescriptionUpdate.Value;
            var quantity = quantityUpdate.Value;
        }
    }
}