using OvningarCleanCode.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningarCleanCode.Methods
{
    public interface IOrderProcessingService
    {
        Order PlaceOrder(OrderDetails orderDetails);
        bool CancelOrder(int orderId);
        Order GetOrderDetails(int orderId);
    }
}
