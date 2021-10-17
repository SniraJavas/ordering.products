using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ordering.products.api.Model
{
    public class Order
    {
        public string Id { set; get; }
        public string UserId { set; get; }
        public Address Address { set; get; }
        public System.DateTime DateCreated { get; set; }
        public Product Product { set; get; }
        public double Total { set; get; }
        public bool Active { set; get; }

    }
}
