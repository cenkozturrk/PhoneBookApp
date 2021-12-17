using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneBook.Entities
{
    public class Person
    {   
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        
        [Required]
        [StringLength(50)]
        [Column(TypeName ="varchar")]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string LastName { get; set; }
        
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Company { get; set; }

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
    }
}
