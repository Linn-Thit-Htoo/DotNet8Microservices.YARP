using DotNet8Microservices.YARP.BlogMicroservice.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNet8Microservices.YARP.BlogMicroservice.Features
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly DA_Blog _dA_Blog;

        public BlogController(DA_Blog dA_Blog)
        {
            _dA_Blog = dA_Blog;
        }

        [HttpGet]
        public IActionResult GetBlogs()
        {
            return Ok(_dA_Blog.GetBlogs());
        }

        [HttpPost]
        public IActionResult CreateBlog([FromBody] BlogModel blog)
        {
            return Ok(blog);
        }
    }
}
