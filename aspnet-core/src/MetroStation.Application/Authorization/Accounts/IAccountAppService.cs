using System.Threading.Tasks;
using Abp.Application.Services;
using MetroStation.Authorization.Accounts.Dto;

namespace MetroStation.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
