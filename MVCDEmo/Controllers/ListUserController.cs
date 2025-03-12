using Microsoft.AspNetCore.Mvc;
using FooddeliveryApp;

namespace MVCDemo.Controllers
{
    public class ListUserController : Controller
    {
       
        public IActionResult ListUser()
        {
            
            return View();
        }
    }
}
