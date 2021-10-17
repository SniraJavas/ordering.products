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
        public string Username { get; set; }

        [Required(ErrorMessage = "User Surname is required")]
        public string Surname { get; set; }

        public Address Address { set; get; }

        [EmailAddress]
        [Required(ErrorMessage = "User Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }

        public bool isActive { get; set; }


    }
}
