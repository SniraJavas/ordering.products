using ordering.products.api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.Products.Api.Interfaces
{
    public interface IOrderRepository
    {
        List<Order> GetOrders(string UserId);
        Order GetOrderId(int Id , string UserId);
        Order PostOrder(Order Order);
        Order EditOrder(Order Order);
        Order CancelOrder(string Order);
        Order DeleteOrder(int Id);
        void save();
        bool OrderExist(int Id);
    }
}
