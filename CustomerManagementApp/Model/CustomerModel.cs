using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerManagementApp.Model
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}