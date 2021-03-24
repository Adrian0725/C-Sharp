using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppRestaurantDemo.ViewModel
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int PaymentTypeId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrederDate { get; set; }
        public decimal FinalTotal { get; set; }

        public IEnumerable<OrderDetailViewModel> ListOfOrderDetailViewModel { get; set; }
    }
}