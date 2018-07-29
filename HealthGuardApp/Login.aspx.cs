using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace HealthGuardApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {




        }

        protected void loginSubmit_Click(object sender, EventArgs e)
        {
            string theUser = txtUserName.Text.ToString().Trim();
            string thePass = txtPassword.Text.ToString().Trim();
            //string newPass = passHash(thePass);


            ServiceReference4.Service1Client get = new ServiceReference4.Service1Client();

     

            Int32 login = get.loginUser(theUser, thePass);
            if (login == 1)
            {
                int profid = get.getprofileID(theUser);

                Session["id"] = profid;
                Session["user"] = theUser;


                LblResult.Text = "success" + Session["id"] + Session["user"];

                Response.Redirect("MyProfile.aspx");


            }

          else  if (login == -1)
            {
                Response.Redirect("Login.aspx");
                Response.Write("<script>alert('Incorrect User Name')</script>");
                LblResult.Text = "username";

            }

            else
            {
                Response.Redirect("Login.aspx");
                Response.Write("<script>alert('Incorrect Password')</script>");
                LblResult.Text = "password";
            }
        }
    }
}