using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurantDemo.Models;
using WebAppRestaurantDemo.Repositories;
using WebAppRestaurantDemo.ViewModel;

namespace WebAppRestaurantDemo.Controllers
{
    public class HomeController : Controller
    {
        private RestaurantDBEntities objRestaurantDBEntities;
        public HomeController()
        {
            objRestaurantDBEntities = new RestaurantDBEntities();
        }
        // GET: Home
        public ActionResult Index()
        {
            CustomerRepository objCustomerRepository = new CustomerRepository();
            ItemRepository objItemRepository = new ItemRepository();
            PaymentTypeRepository objPaymentTypeRepository = new PaymentTypeRepository();

            var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
                (objCustomerRepository.GetAllCustomers(), 
                objItemRepository.GetAllItems(), 
                objPaymentTypeRepository.GetAllPaymentTypes());

            return View(objMultipleModels);
        }

        [HttpGet]
        public JsonResult getItemUnitPrice(int itemId)
        {
            decimal UnitPrice = objRestaurantDBEntities.Items.Single(model => model.ItemId == itemId).ItemPrice;
            return Json(UnitPrice, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Index(OrderViewModel objOrderViewModel) 
        {
            OrderRepository objOrderRepository = new OrderRepository();
            objOrderRepository.AddOrder(objOrderViewModel);
            return Json("Your Order has been Successfully Placed", JsonRequestBehavior.AllowGet);
        }

    }
}