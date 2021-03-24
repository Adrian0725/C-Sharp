using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantDemo.Models;

namespace WebAppRestaurantDemo.Repositories
{
    public class ItemRepository
    {
        private RestaurantDBEntities objRestaurantDBEntities;
        public ItemRepository()
        {
            objRestaurantDBEntities = new RestaurantDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllItems()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objRestaurantDBEntities.Items
                                  select new SelectListItem()
                                  {
                                      Text = obj.ItemName,
                                      Value = obj.ItemId.ToString(),
                                      Selected = false
                                  }).ToList();
            return objSelectListItems;
        }
    }
}