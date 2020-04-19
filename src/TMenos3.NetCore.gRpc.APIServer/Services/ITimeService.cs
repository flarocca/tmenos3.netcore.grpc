using System.Threading.Tasks;

namespace TMenos3.NetCore.gRpc.APIServer.Services
{
    public interface ITimeService
    {
        Task<string> GetTimeAsync();
    }
}
