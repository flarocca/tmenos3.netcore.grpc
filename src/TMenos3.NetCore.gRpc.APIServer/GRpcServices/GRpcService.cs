using Grpc.Core;
using System.Threading.Tasks;
using TMenos3.NetCore.gRpc.APIServer.Services;

namespace TMenos3.NetCore.gRpc.APIServer.GRpcServices
{
    public class GRpcService : IGRpcService.IGRpcServiceBase
    {
        private readonly ITimeService _service;

        public GRpcService(ITimeService service) =>
            _service = service;

        public override async Task<GetTimeResponse> GetTime(GetTimeRequest request, ServerCallContext context) =>
            new GetTimeResponse
            {
                Time = await _service.GetTimeAsync()
            };
    }
}
