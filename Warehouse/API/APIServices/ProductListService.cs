using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Warehouse.API.API_Models;

namespace Warehouse.API.APIServices
{
    public class ProductListService : IProductListService
    {
        private readonly Request<ProductStorageModel> _productStorageService;
        private readonly HttpClient client;
        private readonly string query;
        string localUrl = "http://159.223.18.152:8000/api/";
        public ProductListService()
        {
            _productStorageService = new Request<ProductStorageModel>("productstorage");

            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            client = new HttpClient(handler);
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            client.BaseAddress = new Uri(localUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer 9d9f9a0852dde9e4bff731986ea2daa48569ba45");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<ProductCreateResponse> CreateProduct(ProductCreateModel createModel)
        {
            if(createModel != null)
            {
                try
                {
                    HttpResponseMessage response = await client.PostAsJsonAsync("productstorage/", createModel);

                    if (response.IsSuccessStatusCode)
                    {
                        ProductCreateResponse resModel = await response.Content.ReadAsAsync<ProductCreateResponse>();
                        return resModel;
                    }
                    else
                    {
                        throw new Exception("Did not get data properly");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            throw new Exception("Model to'liq kiritilmagan!");
        }

        public async Task<List<ProductStorageModel>> GetProducts()
        {
            return await _productStorageService.GetAll();
        }
    }
    public interface IProductListService
    {
        Task<List<ProductStorageModel>> GetProducts();
        Task<ProductCreateResponse> CreateProduct(ProductCreateModel createModel);
    }
}
