namespace Porfolio_BE.Models
{
    public class Project
    {
        public int Id { get; set; }
        required public string Title { get; set; }
        required public string ShortDescription { get; set; }
        required public string Description { get; set; }
    }
}
