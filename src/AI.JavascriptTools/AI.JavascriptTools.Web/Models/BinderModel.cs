using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AI.JavascriptTools.Web.Models
{
    public class BinderModel
    {
        public Name Name { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
    }

    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
    }
}