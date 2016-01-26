using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using sample.MultiTenancy.Dto;

namespace sample.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
