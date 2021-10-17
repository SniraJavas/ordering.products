using ordering.products.api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.Products.Api.Interfaces
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        Order GetOrderId(string Id);
        Order PostOrder(Order Order);
        Order EditOrder(Order Order);
        Order CancelOrder(string Order);
        Order DeleteOrder(string Order);
        void save();
        bool OrderExist(string Id);
    }
}
