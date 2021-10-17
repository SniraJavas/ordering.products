using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ordering.products.api.Model
{
    public class Address
    {
        [Key]
        public string Id { set; get; }

        public string AddressType { get; set; }

        public string StreetAddress { get; set; }

        public string Suburb { get; set; }

        public string City { get; set; }

        [MaxLength(4)]
        public int PostalCode { get; set; }
    }
}
