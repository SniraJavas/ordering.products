using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.Products.Api.Model
{
    public class AddressType
    {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }
    }
}
