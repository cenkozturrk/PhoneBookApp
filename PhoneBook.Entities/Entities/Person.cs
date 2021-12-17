using PhoneBookApp.Model;
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
        
        public Contact Contact { get; set; }

    }
}
