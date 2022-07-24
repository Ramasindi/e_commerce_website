using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace S219002358_P05
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Session["UserEmail"] as string))
            {

                logoutNav.Visible = false;

            }
            else
            {
                logoutNav.Visible = true;
                loginNav.Visible = false;
            }
        }
    }
}