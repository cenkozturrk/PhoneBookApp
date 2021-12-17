using PhoneBook.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PhoneBookApp.Model
{
    public class Contact
    {
        [Required]
        [StringLength(10)]
        public int? PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Address { get; set; }

        [StringLength(15)]
        public string City { get; set; }

        [StringLength(15)]
        public string District { get; set; }
        public Person Person { get; set; }
    }
}
