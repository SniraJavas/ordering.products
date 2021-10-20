using ordering.products.api.DBContext;
using ordering.products.api.Interfaces;
using ordering.products.api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Producting.Products.Api.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _Context;

        public ProductRepository()
        {
            _Context = new ApplicationDbContext();
        }

        public ProductRepository(ApplicationDbContext Context)
        {
            _Context = Context;
        }

        Product IProductRepository.GetProductId(int Id)
        {

            try
            {
                return _Context.Products.Find(Id); ;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error : {0} ", ex.Message);
                return null;
            }
        }

        List<Product> IProductRepository.GetProducts()
        {
            return _Context.Products.ToList();
        }

        bool IProductRepository.ProductExist(int Id)
        {
            return _Context.Orders.Any(e => e.Id.Equals(Id));
        }
    }
}
