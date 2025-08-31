using DotNetCoreApiDemo.ResourceMarker;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace DotNetCoreApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IStringLocalizer<SharedResource> _localizer;

        public HomeController(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            var message = _localizer["Greeting"];
            return Content(message);
        }

    }
}
