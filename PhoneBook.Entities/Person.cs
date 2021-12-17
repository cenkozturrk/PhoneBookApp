using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneBook.Entities
{
    public class Person
    {   
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string Company { get; set; }

        [StringLength(10)]
        public int PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        
        public string Address { get; set; }
    }
}
