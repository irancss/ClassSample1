using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequeriedDate { get; set; }
        public DateTime ShippingDate { get; set; }
        public string ShipVia { get; set; }
        public string ShipName { get; set; }

        #region relations
        public Customer Customer { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        #endregion
    }
}
