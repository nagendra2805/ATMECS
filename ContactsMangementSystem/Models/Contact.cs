using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsMangementSystem.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<DateTime> DateofBirth { get; set; }
        public List<string> MobileNumbers { get; set; }
        public List<string> EmailIds { get; set; }
    }
}
