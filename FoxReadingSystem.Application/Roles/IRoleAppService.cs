using System.Threading.Tasks;
using Abp.Application.Services;
using FoxReadingSystem.Roles.Dto;

namespace FoxReadingSystem.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
