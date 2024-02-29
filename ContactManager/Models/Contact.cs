using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManager.Models
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Organisation { get; set; }
        public DateTime DateAdded { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
