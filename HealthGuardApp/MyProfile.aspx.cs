

using HealthGuardObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




namespace HealthGuardApp
{
    public partial class MyProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           


    

        }
        protected void btnEdit_Click(object sender, EventArgs e)
        {



            string theUser = txtName.Text.Trim();
            string thePass = txtGender.Text.Trim();
            string theName = txtEthnicity.Text.Trim();
            string thePass2 = txtAge.Text.Trim();

            ServiceReference4.Service1Client get = new ServiceReference4.Service1Client();

            get.InsertingtheData(theUser, thePass, thePass2, theName);



            LblResult.Text = "success" + Session["id"] + Session["user"];




        }


        protected void btnGetInfo_Click(object sender, EventArgs e)
        {
            ClearAll();
            ServiceReference4.Service1Client get = new ServiceReference4.Service1Client();

            //localhost.Service1 get = new localhost.Service1();
            int login = (int)Session["id"];

            user newItem = get.getPatientInformation(login);

            txtName.Text = newItem.theLogin;
            txtGender.Text = newItem.thePassword;
            txtEthnicity.Text = newItem.theName;

        }

       protected void ClearAll()
        {
            txtAge.Text = "";
            txtEthnicity.Text = "";
            txtGender.Text = "";
            txtName.Text = "";
        }

    }
    }