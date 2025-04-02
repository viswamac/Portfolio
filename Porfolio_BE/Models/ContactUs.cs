namespace Porfolio_BE.Models
{
    public class ContactUs
    {
        required public int Id { get; set; }
        required public string Name { get; set; }
        required public string PhoneNumber { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
    }
}
