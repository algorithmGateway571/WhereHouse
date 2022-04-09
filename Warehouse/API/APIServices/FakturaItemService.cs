using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Warehouse.API.API_Models;

namespace Warehouse.API.APIServices
{
    public class FakturaItemService : IFakturaItemService
    {
        public Task<FakturaItemModel> CreateFakturaItem(FakturaItemModel fakturaItem)
        {
            throw new NotImplementedException();
        }

        public Task<List<FakturaItemModel>> GetFakturaItems()
        {
            throw new NotImplementedException();
        }
    }
    public interface IFakturaItemService
    {
        Task<List<FakturaItemModel>> GetFakturaItems();
        Task<FakturaItemModel> CreateFakturaItem(FakturaItemModel fakturaItem);
    }
}
