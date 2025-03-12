using FooddeliveryApp;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class AdminDashBoardController : Controller
    {
        public IActionResult Index()
        {
            BusinessLayerfd bl = new BusinessLayerfd();
            List<usersDTO> users = bl.ListUsers();
            AdminDashBoardViewmodel model = new AdminDashBoardViewmodel();
            model.users = users;

            List<restaurantDTO> res = bl.Listrestaurant();
            model.restaurants = res;

            return View(model);
        }

        public IActionResult DeleteRestaurant(long id)
        {
            BusinessLayerfd bl = new BusinessLayerfd();
            bool b = bl.deleterestaurant(id);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteUser(long id)
        {
            BusinessLayerfd bl = new BusinessLayerfd();
            bl.deleteuser(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddRestaurant()
        {
            call();
            return View();
        }

        [HttpPost]
        public IActionResult AddRestaurant(restaurantDTO restaurants)
        {
            BusinessLayerfd bl = new BusinessLayerfd();
            bl.Addrestaurant(restaurants);
            return RedirectToAction("Index");
        }
        public void call()
        {
            BusinessLayerfd bl = new BusinessLayerfd();
            List<usersDTO> ownerlist = bl.GetRestaurantowners();
            ViewBag.ownerslist = ownerlist;
        }
        public IActionResult Adduser()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Adduser(usersDTO users)
        {
            BusinessLayerfd bl = new BusinessLayerfd();
            bl.AddUser(users);
            return RedirectToAction("Index");
        }
    }
}
