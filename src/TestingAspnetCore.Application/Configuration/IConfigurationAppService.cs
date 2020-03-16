using System.Threading.Tasks;
using TestingAspnetCore.Configuration.Dto;

namespace TestingAspnetCore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
