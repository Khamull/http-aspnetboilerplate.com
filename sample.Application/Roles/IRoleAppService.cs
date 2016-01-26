using System.Threading.Tasks;
using Abp.Application.Services;
using sample.Roles.Dto;

namespace sample.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
