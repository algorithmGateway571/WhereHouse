using System.Collections.Generic;
using System.Threading.Tasks;
using Warehouse.API.API_Models;

namespace Warehouse.API.APIServices
{
    public class ProductListService : IProductListService
    {
        private readonly Request<ProductStorageModel> _productStorageService;

        public ProductListService()
        {
            _productStorageService = new Request<ProductStorageModel>("productstorage");
        }

        public async Task<List<ProductStorageModel>> GetProducts()
        {
            return await _productStorageService.GetAll();
        }
    }
    public interface IProductListService
    {
        Task<List<ProductStorageModel>> GetProducts();
    }
}
