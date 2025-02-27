﻿namespace AdventureWorks.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string CountryRegion {get; set; }
        public virtual List<Customer> Customers { get; set; }
    }
}
