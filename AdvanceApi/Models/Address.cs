using System;

namespace AdvanceApi.Models
{
    public class Address
    {
        public Guid ID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string CountryRegion { get; set; }
        public virtual List<Customer> Customers { get; set; }
    }
}
