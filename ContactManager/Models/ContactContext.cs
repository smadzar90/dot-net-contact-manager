using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManager.Models
{
    public class ContactContext : DbContext
    {

        public ContactContext(DbContextOptions<ContactContext> options) 
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
            new Contact
            {
                ContactID = 1,
                FirstName = "John",
                LastName = "Doe",
                Phone = "(919)-312-8232",
                Email = "johndoe@example.com",
                Organisation = "exampleORG",
                DateAdded = DateTime.Now,
                CategoryID = 1
            });

            modelBuilder.Entity<Category>().HasData(
            new Category
            {
               CategoryID = 1,
               Name = "Family"
            },
            new Category
            {
                CategoryID = 2,
                Name = "Friend"
            },
            new Category
            {
                CategoryID = 3,
                Name = "Work"
            },
            new Category
            {
                CategoryID = 4,
                Name = "Other"
            });
        }
    }
}
