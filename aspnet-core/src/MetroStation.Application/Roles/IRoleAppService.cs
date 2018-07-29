using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MetroStation.Roles.Dto;

namespace MetroStation.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
