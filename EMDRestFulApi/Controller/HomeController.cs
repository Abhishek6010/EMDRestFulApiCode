using EMDRestFulApi.IRepo;
using Microsoft.AspNetCore.Mvc;

namespace EMDRestFulApi.Controller
{
    [Route("API/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHomeRepo _homeRepo;

        public HomeController(IHomeRepo homeRepo)
        {
            _homeRepo = homeRepo;
        }
        [HttpGet]
        public async Task<IActionResult> CompanyInfo()
        {
            return Ok();
        }
    }
}
