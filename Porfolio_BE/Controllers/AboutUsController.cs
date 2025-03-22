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
                Description = "Hi, I’m Hemakanth, a passionate Full-Stack Developer with a keen eye for detail and a love for building innovative solutions. With [X] years of experience in [mention your key skills, e.g., Angular, .NET Core, gRPC, Entity Framework], I specialize in creating high-performance applications that enhance user experience and business efficiency.\r\n\r\nI thrive on solving complex problems, optimizing workflows, and staying up to date with the latest technologies. My expertise spans [list core competencies, e.g., front-end and back-end development, API design, cloud computing, authentication & authorization], allowing me to craft scalable and robust solutions.\r\n\r\nWhen I’m not coding, I enjoy [mention hobbies, e.g., exploring new tech trends, contributing to open-source projects, blogging, or mentoring]. I’m always eager to collaborate on exciting projects and bring ideas to life.",
                ImageUrl = "https://picsum.photos/id/237/200/300",
                Title = "About Me!" };
        }
       
    }
}
