using FooddeliveryApp;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace MVCDemo.Models
{
    
        public class AdminDashBoardViewmodel
        {
            public List<usersDTO> users { get; set; }
            public List<restaurantDTO> restaurants { get; set; }

        }
    
}
