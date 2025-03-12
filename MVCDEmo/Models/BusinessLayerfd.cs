using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooddeliveryApp
{
    public class BusinessLayerfd
    {
        DataAcessLayer dal = new DataAcessLayer();
        usersDTO Loggineduser = new usersDTO();
        public BusinessLayerfd()
        {
            dal.OpenConnection();
        }
        public void Closeapp()
        {
            dal.CloseConnection();
        }


        public usersDTO AuthenticateUser(string email, string password)
        {
            usersDTO Loggineduser = dal.LoginUser(email, password); ;
            return Loggineduser;
        }
        public bool AddUser(usersDTO inp)
        {
            
                return dal.Adduser(inp);
           
            
        }
        public bool Addrestaurant(restaurantDTO res)
        {
           
                return dal.Addrestaurant(res);
           
        }
        public bool Addorders(ordersDTO ord)
        {
            if (Loggineduser != null && Loggineduser.roledal == usersDTO.role.user)
            {
                return dal.Addorders(ord);
            }
            else
            {
                return false;
            }
        }
        public bool Addorderitems(orderitemDTO ordit)
        {
            if (Loggineduser != null && Loggineduser.roledal == usersDTO.role.owner)
            {
                return dal.Addorderitems(ordit);
            }
            else
            {
                return false;
            }
        }
        public bool Addmenu(menusDTO menu)
        {
            if (Loggineduser != null && Loggineduser.roledal == usersDTO.role.owner)
            {
                return dal.Addmenu(menu);
            }
            else
            {
                return false;
            }
        }
        public List<usersDTO> ListUsers()
        {

            return dal.Listusers();
        }
        public List<ordersDTO> ListOrders()
        {

            return dal.Listorders();
        }

        public List<restaurantDTO> Listrestaurant()
        {
            return dal.Listrestaurant();
        }
        public bool deleterestaurant(long id)
        {
            return dal.deleterestaurant(id);
        }
        public bool deleteuser(long id)
        {
            return dal.deleteuser(id);
        }
        public List<usersDTO> GetRestaurantowners()
        {
            return dal.GetRestaurantowners();
        }
    }
}
