using Microsoft.AspNetCore.Mvc;

namespace EMDRestFulApi.Controller
{
    [Route("API/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> CompanyInfo()
        {
            return Ok();
        }
    }
}
