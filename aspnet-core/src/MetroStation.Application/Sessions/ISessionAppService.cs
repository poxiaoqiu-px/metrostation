using System.Threading.Tasks;
using Abp.Application.Services;
using MetroStation.Sessions.Dto;

namespace MetroStation.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
