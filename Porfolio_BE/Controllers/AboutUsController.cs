using Microsoft.AspNetCore.Mvc;
using Porfolio_BE.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Porfolio_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        // GET: api/<AboutUsController>
        [HttpGet]
        public AboutUs Get()
        {
            return new AboutUs() { 
                Description = "Hi, I’m Hemakanth, a passionate Full-Stack Developer with a keen eye for detail and a love for building innovative solutions. With [X] years of experience in [mention your key skills, e.g., Angular, .NET Core, gRPC, Entity Framework].",
                ImageUrl = "https://picsum.photos/id/237/400/400",
                Title = "About Me!" };
        }
       
    }
}
