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
        
        Product IProductRepository.DeleteProduct(string Id)
        {
            throw new NotImplementedException();
        }

        Product IProductRepository.EditProduct(Product Product)
        {
            throw new NotImplementedException();
        }

        Product IProductRepository.GetProductId(string Id)
        {
            throw new NotImplementedException();
        }

        List<Product> IProductRepository.GetProducts()
        {
            throw new NotImplementedException();
        }

        bool IProductRepository.ProductExist(string Id)
        {
            throw new NotImplementedException();
        }

        Product IProductRepository.PostProduct(Product Product)
        {
            throw new NotImplementedException();
        }

        void IProductRepository.save()
        {
            throw new NotImplementedException();
        }
    }
}
