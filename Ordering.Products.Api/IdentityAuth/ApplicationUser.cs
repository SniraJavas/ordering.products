using Microsoft.AspNetCore.Identity;
using ordering.products.api.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ordering.products.api.IdentityAuth
{
    public class ApplicationUser : IdentityUser
    {

        [Required(ErrorMessage = "User Surname is required")]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public string AddressType { get; set; }

        public string StreetAddress { get; set; }

        public string Suburb { get; set; }

        public string City { get; set; }

        public int PostalCode { get; set; }

        public bool isActive { get; set; }

    }
}
