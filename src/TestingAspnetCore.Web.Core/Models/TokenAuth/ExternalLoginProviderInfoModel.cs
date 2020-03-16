using Abp.AutoMapper;
using TestingAspnetCore.Authentication.External;

namespace TestingAspnetCore.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
