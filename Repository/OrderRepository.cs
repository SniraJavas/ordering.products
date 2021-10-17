using Microsoft.EntityFrameworkCore;
using ordering.products.api.DBContext;
using ordering.products.api.Model;
using ordering.products.api.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ordering.Products.Api.Interfaces;

namespace Ordering.products.api.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _Context;

        public OrderRepository()
        {
            _Context = new ApplicationDbContext();
        }

        public OrderRepository(ApplicationDbContext Context)
        {
            _Context = Context;
        }

        public Order DeleteOrder(string Id)
        {
            try
            {
                var Order = _Context.Orders.Find(Id);
                if (Order != null)
                {
                    if (Order.Active == true)
                    {
                        Order.Active = false;
                        _Context.Orders.Remove(Order);
                        _Context.Entry(Order).State = EntityState.Modified;
                        save();
                        return Order;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error : {0} ", ex.Message);
                return null;
            }
        }

        Order IOrderRepository.CancelOrder(string id)
        {
            try {
                var Order = _Context.Orders.Find(id);
                if (Order != null)
                {
                    if (Order.Active == true)
                    {
                        Order.Active = false;
                        //_dbContext.Managers.Remove(manager);
                        _Context.Entry(Order).State = EntityState.Modified;
                        save();
                        return Order;
                    }
                }

                return null;
            }
            catch (Exception Ex) {
                Console.WriteLine("error : {0} ", Ex.Message);
                return null;
            }
        }

        Order IOrderRepository.EditOrder(Order Order)
        {
            try
            {
                _Context.Entry(Order).State = EntityState.Modified;
                save();
                if (Order != null)
                {
                    if (Order.Active == true)
                    {
                        return Order;
                    }
                }
                return null;
            }
            catch (Exception Ex)
            {
                Console.WriteLine("error : {0} ", Ex.Message);
                return null;
            }
        }

        Order IOrderRepository.GetOrderId(string Id)
        {
            try {
                var Order = _Context.Orders.Find(Id);
                if (Order != null)
                {
                    if (Order.Active == true)
                    {
                        return Order;
                    }
                }
                return null;
            }
            catch (Exception ex) {
                Console.WriteLine("error : {0} ", ex.Message);
                return null;
            }
        }

        List<Order> IOrderRepository.GetOrders()
        {
            return _Context.Orders.Where(x => x.Active == true).ToList();
        }

        bool IOrderRepository.OrderExist(string Id)
        {
            return _Context.Orders.Any(e => e.Id.Equals(Id));
        }

        Order IOrderRepository.PostOrder(Order Order)
        {
            try
            {
                _Context.Orders.Add(Order);

                this.save();
                return Order;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error : {0} ", ex.Message);
                return null;
            }
        }

        private void save()
        {
            _Context.SaveChanges();
        }

        void IOrderRepository.save()
        {
            _Context.SaveChanges();
        }
    }
}
