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
    public partial class LoginPage : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            log_alert.Visible = false;
            if (!string.IsNullOrEmpty(Session["UserEmail"] as string))
            {
                Response.Redirect("LandingPage.aspx");
            }
        }

        protected void login_Click(object sender, EventArgs e)
        {
            var emai = email.Value;
            var pass = password.Value;
            var user = client.GetUser(emai,pass);
            if(user == "success")
            {
                Session["UserEmail"] = emai;
                Response.Redirect("LandingPage.aspx");
            }
            if (user == "error") {
                log_alert.Visible = true;
                log_alert.InnerHtml = "<strong>Error!</strong> Wrong Username or password.";
            }
            if(user == "register")
            {
                Response.Redirect("RegisterPage.aspx");
            }
           // UserDetails ud = new UserDetails();
           //ud.Email = emai;
           //ud.Password = pass;
           //List<User> user = client.GetUsers().ToList();

        }
    }
}