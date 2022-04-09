using System.Collections.Generic;
using System.Threading.Tasks;
using Warehouse.API.API_Models;

namespace Warehouse.API.APIServices
{
    public class GroupService : IGroupService
    {
        private readonly Request<GroupModel> _groupService;

        public GroupService()
        {
            _groupService = new Request<GroupModel>("groups");
        }

        public async Task<List<GroupModel>> GetGroups()
        {
            return await _groupService.GetAll();
        }
    }

    public interface IGroupService
    {
        Task<List<GroupModel>> GetGroups();
    }
}
