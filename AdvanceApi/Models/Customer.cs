namespace AdvanceApi.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public int Phonexxxxxxxxxxxxxxxxxxxxxx { get; set; }
        public virtual List<Address> Addresses { get; set; }
    }
}
