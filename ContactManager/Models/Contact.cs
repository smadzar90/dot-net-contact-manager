using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManager.Models
{
    public class Contact
    {

        public Contact()
        {
            Slug = $"{FirstName}-{LastName}".ToLower().Replace(" ", "-");
        }
        public int ContactID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Organisation { get; set; }

        [Display(Name = "Date added")]
        public DateTime DateAdded { get; set; }

        public string Slug { get;  }

        public int CategoryID { get; set; }

        public Category Category { get; set; }
    }
}
