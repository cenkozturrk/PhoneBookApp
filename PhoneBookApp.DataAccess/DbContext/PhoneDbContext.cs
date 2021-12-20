using Microsoft.EntityFrameworkCore;
using PhoneBook.Entities;
using PhoneBookApp.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace PhoneBookApp.DataAccess
{
    public class PhoneDbContext :DbContext    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    }
}
