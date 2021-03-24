using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantDemo.Models;

namespace WebAppRestaurantDemo.Repositories
{
    public class PaymentTypeRepository
    {
        private RestaurantDBEntities objRestaurantDBEntities;
        public PaymentTypeRepository()
        {
            objRestaurantDBEntities = new RestaurantDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllPaymentTypes()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objRestaurantDBEntities.PaymentTypes
                                  select new SelectListItem()
                                  {
                                      Text = obj.PaymentTypeName,
                                      Value = obj.PaymentTypeId.ToString(),
                                      Selected = true
                                  }).ToList();
            return objSelectListItems;
        }

    }
}