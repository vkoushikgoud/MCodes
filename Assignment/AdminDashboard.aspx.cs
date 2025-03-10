using System;
using System.Web.UI;
using FooddeliveryApp;

namespace FOODAPPUI
{
    public partial class AdminDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                usersDTO loggedInUser = Session["LoggedInUser"] as usersDTO;
                if (loggedInUser == null || loggedInUser.roledal != usersDTO.role.admin)
                {
                    Response.Redirect("LoginForm.aspx");
                }
            }
        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddUser.aspx");
        }
    }
}
