using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ordering.products.api.Model
{
    public class Order
    {
        public int Id { set; get; }
        public string UserId { set; get; }
        public int ProductId { set; get; }
        public double Total { set; get; }
        public bool Active { set; get; }
        public System.DateTime DateCreated { get; set; }
        public string Status { get; set; }

    }
}
