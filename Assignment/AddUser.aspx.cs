using System;
using System.Web.UI;
using FooddeliveryApp;

namespace FOODAPPUI
{
    public partial class AddUser : System.Web.UI.Page
    {
        BusinessLayerfd blf = new BusinessLayerfd();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            usersDTO newUser = new usersDTO
            {
                uname = txtUserName.Text,
                email = txtEmail.Text,
                password = txtPassword.Text,
                roledal = (usersDTO.role)Enum.Parse(typeof(usersDTO.role), ddlRole.SelectedValue),
                ulocation = txtLocation.Text
            };

            bool result = blf.AddUser(newUser);

            if (result)
            {
                lblMessage.Text = "User added successfully.";
            }
            else
            {
                lblMessage.Text = "Failed to add user.";
            }
        }
    }
}
