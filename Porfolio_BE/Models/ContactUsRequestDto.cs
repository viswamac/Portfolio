namespace Porfolio_BE.Models
{
    public class ContactUsRequestDto
    {
        required public string Name { get; set; }
        required public string PhoneNumber { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
    }
}
