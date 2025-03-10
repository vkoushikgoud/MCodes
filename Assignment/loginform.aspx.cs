using FooddeliveryApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FooddeliveryApp;
namespace FOODAPPUI
{
	public partial class loginform : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			
            //else
            //{
            //    Response.Write("Invalid User");
            //}

        }

        protected void login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(pass.Text))
            {
                lblstatus.Text = "Email and password cannot be empty.";
                return;
            }

            BusinessLayerfd bl = new BusinessLayerfd();
            usersDTO usr = bl.AuthenticateUser(email.Text, pass.Text);
            if (usr != null)
            {
                Session["LoggedInUser"] = usr; // Use consistent session key

                if (usr.roledal == usersDTO.role.admin)
                {
                    Response.Redirect("AdminDashboard.aspx");
                }
                else if (usr.roledal == usersDTO.role.user)
                {
                    Response.Redirect("UserDashboard.aspx");
                }
                else if (usr.roledal == usersDTO.role.owner)
                {
                    Response.Redirect("OwnerDashboard.aspx");
                }
            }
            else
            {
                // Handle invalid login
                lblstatus.Text = "Invalid email or password.";
            }
        }
        
            
       


    }
}