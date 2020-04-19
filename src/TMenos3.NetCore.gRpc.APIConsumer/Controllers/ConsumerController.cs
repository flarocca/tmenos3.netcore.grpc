using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using TMenos3.NetCore.gRpc.APIConsumer.GRpcServices;

namespace TMenos3.NetCore.gRcp.APIConsumer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConsumerController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            using var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://localhost:5000/server");
            var httpResult = await response.Content.ReadAsStringAsync();

            var channel = GrpcChannel.ForAddress("https://localhost:5000");
            var client = new IGRpcService.IGRpcServiceClient(channel);
            var getTimeRequest = new GetTimeRequest();
            var grpcResult = await client.GetTimeAsync(getTimeRequest);

            return Ok(new {
                httpResult,
                grpcResult
            });
        }
    }
}
