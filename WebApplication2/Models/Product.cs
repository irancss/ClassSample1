using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Product
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public string ReaderLevel { get; set; }
        public int Discontinued { get; set; }


        #region Relations

        public List<OrderDetail> OrderDetails { get; set; }
        public List<Category> Categories { get; set; }
        

        #endregion
    }
}
