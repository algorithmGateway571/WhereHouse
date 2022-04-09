using System.Collections.Generic;
using System.Threading.Tasks;
using Warehouse.API.API_Models;

namespace Warehouse.API.APIServices
{
    public class FilialService : IFilialService
    {
        private readonly Request<FilialModel> _filialService;

        public FilialService()
        {
            _filialService = new Request<FilialModel>("filial");
        }
        public async Task<List<FilialModel>> GetFilials()
        {
            return await _filialService.GetAll();
        }
    }

    public interface IFilialService
    {
        Task<List<FilialModel>> GetFilials();
    }
}
