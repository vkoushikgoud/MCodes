
using FooddeliveryApp;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace MVCDemo.Models
{

    public class AddRestaurantModel
    {
       
        public List<restaurantDTO> restaurants { get; set; }

    }

}