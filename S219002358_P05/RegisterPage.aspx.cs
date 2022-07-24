using S219002358_P05.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace S219002358_P05
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            reg_alert.Visible = false;
            if (!string.IsNullOrEmpty(Session["UserEmail"] as string))
            {
                Response.Redirect("LandingPage.aspx");
            }
        }
      
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Password validation
            var hasNo = new Regex(@"[0-9]+");
            var hasUpChar = new Regex(@"[A-Z]+");
            var hasMin6Chars = new Regex(@".{6,}");

            string email = reg_email.Value;
            string password = reg_password.Value;
            string passwordConfirm = reg_passwordConfirm.Value;

            if (password != passwordConfirm)
            {
                reg_alert.Visible = true;
                reg_alert.InnerHtml = "<strong>Error!</strong> Your passwords do not match.";
                return;
            }
            else if (!hasNo.IsMatch(password))
            {
                reg_alert.Visible = true;
                reg_alert.InnerHtml = "<strong>Error!</strong> Your password does not contain a number.";
                return;
            }
            else if (!hasUpChar.IsMatch(password))
            {
                reg_alert.Visible = true;
                reg_alert.InnerHtml = "<strong>Error!</strong> Your password does not contain an Uppercase.";
                return;
            }
            else if (!hasMin6Chars.IsMatch(password)) {
                reg_alert.Visible = true;
                reg_alert.InnerHtml = "<strong>Error!</strong> Your password is too short. Make sure it has more than 5 characters";
                return;
            }
            else
            {
                if (userType.Value == "Manager")
                {
                    User ud = new User();
                    ud.UserEmail = email;
                    ud.UserPassword = password;
                    string user = client.InsertUserDetails(ud);
                   
                    if (user != "Registered")
                    {
                        reg_alert.Visible = true;
                        reg_alert.InnerHtml = "<strong>Error!</strong> This Email address already exist in our system";
                    }
                    else
                    {
                        Session["UserEmail"] = email;
                        Response.Redirect("ManageProduct.aspx");
                    }
                }
                else
                {
                    User ud = new User();
                    ud.UserEmail = email;
                    ud.UserPassword = password;
                    string user = client.InsertUserDetails(ud);
                    if (user != "Registered") {
                        reg_alert.Visible = true;
                        reg_alert.InnerHtml = "<strong>Error!</strong> This Email address already exist in our system";
                    }
                    else
                    {
                        Session["UserEmail"] = email;
                        Response.Redirect("LandingPage.aspx");
                    }
                  
                }
            }

        }
    }
}