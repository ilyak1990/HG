using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HealthGuardApp
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btn_Register_Submit(object sender, EventArgs e)
        {



            string theUser = txtRegisterEmail.Text.Trim();
            string thePass = txtRegisterPassword.Text.Trim();
            string theName = txtRegisterName.Text.Trim();
            string thePass2 = txtRegisterPassword2.Text.Trim();
            string theEmail = txtRegisterEmailAddress.Text.Trim();

            ServiceReference4.Service1Client client = new
     ServiceReference4.Service1Client();

            localhost.Service1 get = new localhost.Service1();


            if (validationcheck(theUser, thePass, thePass2, theName) == true)
            {
                //string newPass = passHash(thePass);
                get.userRegister(theUser, thePass, thePass2, theName, theEmail);
                int profid = client.getprofileID(theUser);
                Session["user"] = theUser;
                Session["id"] = profid;



                //MailMessage mail = new MailMessage();
                //mail.To.Add(theEmail);

                //mail.From = new MailAddress("ebayilya@yahoo.com");
                //mail.Subject = "Welcome!" + theUser;
                //mail.Body = "Hello!";
                //mail.IsBodyHtml = true;

                //SmtpClient smtp = new SmtpClient();
                //smtp.Host = "smtp.mail.yahoo.com";



                //smtp.Credentials = new System.Net.NetworkCredential
                //   ("ebayilya@yahoo.com", "ukraine1990");

                //smtp.Port = 587;



                //smtp.EnableSsl = true;

                //smtp.Send(mail);


                Response.Redirect("~/MyProfile.aspx");
            }



        }




        protected void jawn_click(object sender, EventArgs e)
        {


            ServiceReference4.Service1Client client = new
      ServiceReference4.Service1Client();
            string returnString;

            returnString = client.GetData(Convert.ToInt32(textBox1.Text));
            label1.Text = returnString;

        }


        public bool validationcheck(string chkuser, string chkpass1, string chkpass2, string chkname)
        {
            bool validationChecker = true;

            if (chkuser == "")
            {
                Response.Write("<script>alert('A User Name Was Not Entered')</script>");
            }
            if (chkpass1 == "")
            {
                Response.Write("<script>alert('No Passwords Were Entered')</script>");
            }
            if (InputValidation.validatePassowrd(chkpass1, chkpass2) == false)
            {
                Response.Write("<script>alert('Passwords Did Not Match')</script>");
                validationChecker = false;
            }
            //if (InputValidation.validateEmail(chkemail) == false)
            //{
            //    Response.Write("<script>alert('Email was incorrect')</script>");
            //    validationChecker = false;
            //}
            //if (InputValidation.validatePhoneNumber(chktelephone) == false)
            //{
            //    Response.Write("<script>alert('Invalid Phone Number')</script>");
            //    validationChecker = false;
            //}
            return validationChecker;
        }



    }
}