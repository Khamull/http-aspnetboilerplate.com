using System.Threading.Tasks;
using Abp.Application.Services;
using sample.Users.Dto;

namespace sample.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);
    }
}