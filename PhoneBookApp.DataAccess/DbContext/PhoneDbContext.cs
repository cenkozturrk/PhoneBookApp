using Microsoft.EntityFrameworkCore;
using PhoneBook.Entities;
using PhoneBookApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookApp.DataAccess
{
    public class PhoneDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=MIKRONB032; Database=PhoneBookDb;User Id=sa;Password=123");
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    }
}
