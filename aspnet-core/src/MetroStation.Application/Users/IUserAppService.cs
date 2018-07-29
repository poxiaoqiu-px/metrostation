using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MetroStation.Roles.Dto;
using MetroStation.Users.Dto;

namespace MetroStation.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
