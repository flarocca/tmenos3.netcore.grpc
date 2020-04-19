using System;
using System.Threading.Tasks;

namespace TMenos3.NetCore.gRpc.APIServer.Services
{
    internal class TimeService : ITimeService
    {
        public Task<string> GetTimeAsync() =>
            Task.FromResult(DateTime.Now.ToString("yyyy-MM-ddThh-mm-ss"));
    }
}
