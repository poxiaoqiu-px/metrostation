using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MetroStation.MultiTenancy.Dto;

namespace MetroStation.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
