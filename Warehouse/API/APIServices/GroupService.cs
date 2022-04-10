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

        public async Task<GroupModel> CreateGroup(GroupModel group)
        {
            if (group != null)
            {
                GroupModel model = await _groupService.Post("", group);
                return model;
            }
            else return null;
        }

        public async Task<List<GroupModel>> GetGroups()
        {
            return await _groupService.GetAll();
        }
    }

    public interface IGroupService
    {
        Task<List<GroupModel>> GetGroups();
        Task<GroupModel> CreateGroup(GroupModel group);
    }
}
