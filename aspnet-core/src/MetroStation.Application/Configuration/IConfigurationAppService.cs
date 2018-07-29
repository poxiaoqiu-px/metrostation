using System.Threading.Tasks;
using MetroStation.Configuration.Dto;

namespace MetroStation.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
