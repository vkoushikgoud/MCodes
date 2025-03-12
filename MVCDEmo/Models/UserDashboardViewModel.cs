using Microsoft.AspNetCore.Mvc;
using FooddeliveryApp;
namespace MVCDemo.Models
{
    public class UserDashboardViewModel
    {
        public List<restaurantDTO> restaurants { get; set; }
        public List<ordersDTO> orders { get; set; }
    }
}
