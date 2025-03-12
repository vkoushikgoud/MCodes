using Microsoft.AspNetCore.Mvc;
using FooddeliveryApp;

namespace MVCDemo.Controllers
{
    public class AccountController : Controller
    {

        public ActionResult LoginForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginForm(string uemail, string upwd)
        {
            BusinessLayerfd bl = new BusinessLayerfd();
            usersDTO usr = bl.AuthenticateUser(uemail,upwd);
            if (usr.roledal == usersDTO.role.admin)
            {
                return RedirectToAction("Index", "AdminDashBoard");
            }
            else if (usr.roledal == usersDTO.role.user)
            {
                return RedirectToAction("Uindex", "UserDashboard");
            }
            else if (usr.roledal == usersDTO.role.owner)
            {
                return View("LoginForm");

            }
            else
            {
                ViewBag.ErrMsg = "Error in Login";
                return View("LoginForm");
            }
        }

    }
}
