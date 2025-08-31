using DotNetCoreApiDemo.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddSingletonScopeTransientController : ControllerBase
    {
        private readonly IScopedService _scopeService;
        private readonly ISingletonService _singletonService;
        private readonly ITransientService _transientService;

        private readonly IGUID _guidService;
        public AddSingletonScopeTransientController(IScopedService scopedService, ISingletonService singletonService, ITransientService transientService, IGUID gUID)
        {
            _scopeService = scopedService;
            _singletonService = singletonService;
            _transientService = transientService;
            _guidService = gUID;
        }

        [HttpGet]
        public IActionResult Get() {
            return Ok(new
            {
                Transient = _transientService.GetOperationId(),
                Transient_2 = _transientService.GetOperationId(),
                Transient_3 = _transientService.GetOperationId(),

                Scope = _scopeService.GetOperationId(),
                Scope_2 = _scopeService.GetOperationId(),
                Scope_3 = _scopeService.GetOperationId(),

                Singleton = _singletonService.GetOperationId(),
                Singleton_2 = _singletonService.GetOperationId(),
                Singleton_3 = _singletonService.GetOperationId()
            });
        }

        [HttpGet]
        [Route("GetLifetime_v2")]
        public IActionResult Lifetime()
        {
            return Ok(new
            {
                Transient = _transientService.GetOperationId(),
                Scope = _scopeService.GetOperationId(),
                Singleton = _singletonService.GetOperationId(),
              
            });
        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            var guid1 = _guidService.GetGuid();
            var guid2 = _guidService.GetGuid();
            return Content($"GUID1: {guid1}, GUID2: {guid2}");
        }


    }
}
