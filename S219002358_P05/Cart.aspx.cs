using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace S219002358_P05
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //parameters get id edit cart items increase the URL
            HtmlGenericControl items = Master.FindControl("items") as HtmlGenericControl;
            items.InnerText = "5";
            if (string.IsNullOrEmpty(Session["UserEmail"] as string))
            {
                Response.Redirect("LoginPage.aspx");
            }
        }
    }
}