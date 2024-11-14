using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningarCleanCode.entities
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; } = new();
    }
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlacedDate { get; set; }
        public OrderDetails OrderDetail { get; set; } = new();

    }
}
