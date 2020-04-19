using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TMenos3.NetCore.gRpc.APIServer.Services;

namespace TMenos3.NetCore.gRcpApi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServerController : ControllerBase
    {
        private readonly ITimeService _service;

        public ServerController(ITimeService service) =>
            _service = service;

        [HttpGet]
        public async Task<IActionResult> Get() =>
            Ok(await _service.GetTimeAsync());
    }
}
