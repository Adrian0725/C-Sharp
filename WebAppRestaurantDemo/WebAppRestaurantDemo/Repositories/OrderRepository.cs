using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppRestaurantDemo.Models;
using WebAppRestaurantDemo.ViewModel;

namespace WebAppRestaurantDemo.Repositories
{
    public class OrderRepository
    {
        private RestaurantDBEntities objRestaurantDBEntities;

        public OrderRepository()
        {
            objRestaurantDBEntities = new RestaurantDBEntities();
        }

        public bool AddOrder(OrderViewModel objOrderViewModel)
        {
            Order objOrder = new Order();
            objOrder.CustomerId = objOrderViewModel.CustomerId;
            objOrder.FinalTotal = objOrderViewModel.FinalTotal;
            objOrder.OrderDate = DateTime.Now;
            objOrder.OrderNumber = String.Format("{0:ddmmmyyyyhhmmss}", DateTime.Now);
            objOrder.PaymentTypeId = objOrderViewModel.PaymentTypeId;
            objRestaurantDBEntities.Orders.Add(objOrder);
            objRestaurantDBEntities.SaveChanges();
            int OrderId = objOrder.OrderId;

            foreach (var item in objOrderViewModel.ListOfOrderDetailViewModel)
            {
                OrderDetail objOrderDetail = new OrderDetail();
                objOrderDetail.OrderId = OrderId;              
                objOrderDetail.ItemId = item.ItemId;
                objOrderDetail.UnitPrice = item.UnitPrice;
                objOrderDetail.Quantity = item.Quantity;
                objOrderDetail.Discount = item.Discount;
                objOrderDetail.Total = item.Total;
                objRestaurantDBEntities.OrderDetails.Add(objOrderDetail);
                objRestaurantDBEntities.SaveChanges();

                Transaction objTransaction = new Transaction();
                objTransaction.ItemId = item.ItemId;
                objTransaction.Quantity = (-1)*item.Quantity;
                objTransaction.TransactionDate = DateTime.Now;
                objTransaction.TypeId = 2;
                objRestaurantDBEntities.Transactions.Add(objTransaction);
                objRestaurantDBEntities.SaveChanges();
            }

            return true;
        }

    }
}