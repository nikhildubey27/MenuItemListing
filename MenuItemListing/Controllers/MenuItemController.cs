using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MenuItemListing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : ControllerBase
    {
        [HttpGet]
        public List<MenuItem> GetItem()
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {   new MenuItem() {Id=1, Name="Burger", Active=true, DateOfLaunch=new DateTime(2017,01,01), FreeDelivery=false,Price=50},
                new MenuItem() {Id=2, Name="Pizza", Active=false, DateOfLaunch=new DateTime(2018,10,03), FreeDelivery=false,Price=209},
                new MenuItem() {Id=3, Name="Sandwich", Active=true, DateOfLaunch=new DateTime(2017,09,04), FreeDelivery=false,Price=80},
                new MenuItem() {Id=4, Name="Juice", Active=false, DateOfLaunch=new DateTime(2018,12,01), FreeDelivery=false,Price=20}

            };
            return MenuList;
        }

        [HttpGet("{id}")]
        public MenuItem GetItemById(int id)
        {
            List<MenuItem> MenuList = new List<MenuItem>()
            {   new MenuItem() {Id=1, Name="Burger", Active=true, DateOfLaunch=new DateTime(2017,01,01), FreeDelivery=false,Price=50},
                new MenuItem() {Id=2, Name="Pizza", Active=false, DateOfLaunch=new DateTime(2018,10,03), FreeDelivery=false,Price=209},
                new MenuItem() {Id=3, Name="Sandwich", Active=true, DateOfLaunch=new DateTime(2017,09,04), FreeDelivery=false,Price=80},
                new MenuItem() {Id=4, Name="Juice", Active=false, DateOfLaunch=new DateTime(2018,12,01), FreeDelivery=false,Price=20}

            };
            MenuItem obj = MenuList.SingleOrDefault(item => item.Id == id);
            return obj;

        }

    }
}
