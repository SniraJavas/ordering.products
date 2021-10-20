using ordering.products.api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ordering.products.api.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product GetProductId(int Id);
        bool ProductExist(int Id);
    }
}
