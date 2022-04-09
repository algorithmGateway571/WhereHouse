using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Warehouse.API.API_Models;

namespace Warehouse.API.APIServices
{
    public class FakturaService : IFakturaService
    {
        private readonly Request<FakturaModel> _fakturaService;
        public FakturaService()
        {
            _fakturaService = new Request<FakturaModel>("faktura");
        }

        public async Task<FakturaModel> CreateFaktura(FakturaModel fakturaModel)
        {
            if (fakturaModel != null)
            {
                FakturaModel model = await _fakturaService.Post("", fakturaModel);
                if (model != null) return model;
                else return null;
            }
            return null;
        }

        public async Task<List<FakturaModel>> GetFakturas()
        {
            return await _fakturaService.GetAll();
        }

        public bool PatchFaktura()
        {
            throw new NotImplementedException();
        }
    }

    public interface IFakturaService
    {
        Task<List<FakturaModel>> GetFakturas();
        Task<FakturaModel> CreateFaktura(FakturaModel fakturaModel);
        bool PatchFaktura();
    }
}
