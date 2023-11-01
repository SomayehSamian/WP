using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkProject.ActionFilter;
using WorkProject.Services.Interface;

namespace WorkProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomController : ControllerBase
    {
        private readonly ICustomService _customService;
        public CustomController(ICustomService customService)
        {
            _customService = customService;
        }
        
        [HttpGet(nameof(GetByLink))]
        public IActionResult GetByLink(string Link)
        {
            var result = _customService.GetByLink(Link);
            if (result is not null)
            {
                return Ok(result);
            }
            return NotFound("No record found");
        }

        [HttpGet(nameof(GetByCode))]
        [MyLogFilter]
        public IActionResult GetByCode(string Code)
        {
            var result = _customService.GetByCode(Code);
            if (result is not null)
            {
                return Ok(result);
            }
            return NotFound("No record found");
        }
    }
}
