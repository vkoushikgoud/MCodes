using FooddeliveryApp;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class UserDashboardController : Controller
    {
        public IActionResult Uindex()
        {
            BusinessLayerfd bl = new BusinessLayerfd();
            UserDashboardViewModel model = new UserDashboardViewModel();

            // Fetch the list of restaurants
            List<restaurantDTO> restaurants = bl.Listrestaurant();
            model.restaurants = restaurants;

            // Fetch the list of orders (assuming a method exists in BusinessLayerfd)
            List<ordersDTO> orders = bl.ListOrders();
            model.orders = orders;

            return View(model);
        }

        public IActionResult DeleteRestaurant(long id)
        {
            BusinessLayerfd bl = new BusinessLayerfd();
            bool b = bl.deleterestaurant(id);
            return RedirectToAction("Uindex");
        }

        public IActionResult AddRestaurant()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRestaurant(restaurantDTO res)
        {
            BusinessLayerfd bl = new BusinessLayerfd();
            bl.Addrestaurant(res);
            return RedirectToAction("Uindex");
        }
    }
}
