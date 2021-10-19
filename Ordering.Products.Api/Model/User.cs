using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ordering.products.api.Model
{
    public class User
    {
        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "User Surname is required")]
        public string Surname { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "User Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }

        public bool isActive { get; set; }

        public string AddressType { get; set; }

        public string StreetAddress { get; set; }

        public string Suburb { get; set; }

        public string CityTown { get; set; }

        public int PostalCode { get; set; }

       


    }
}
