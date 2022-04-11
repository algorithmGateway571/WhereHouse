using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Warehouse.API.API_Models;

namespace Warehouse.API.APIServices
{
    class ReceiveItemService : IReceiveItemService
    {
        private readonly Request<ReceiveItemModel> _receiveItemService;
        private readonly HttpClient client;
        public ReceiveItemService()
        {
            _receiveItemService = new Request<ReceiveItemModel>("receiveitem");
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            client = new HttpClient(handler);
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            client.BaseAddress = new Uri(StaticModels.BaseURL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {StaticModels.Token}");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async void ConfirmReceive(int Id, string status)
        {
            HttpClient patchClient = new HttpClient();
            Uri url = new Uri(StaticModels.BaseURL + $"receive/{Id}/");
            patchClient.DefaultRequestHeaders.Accept.Clear();
            patchClient.DefaultRequestHeaders.Add("Authorization", "Bearer 9d9f9a0852dde9e4bff731986ea2daa48569ba45");
            HttpContent httpContent = new StringContent("{\"status\":" + status + "}", Encoding.UTF8, "application/json");
            HttpResponseMessage message = await _receiveItemService.PatchAsync(patchClient, url, httpContent);
            ReceiveResponseModel receiveModel = await message.Content.ReadAsAsync<ReceiveResponseModel>();
            
        }

        public async Task<ReceiveItemModel> CreateReceiveItem(ReceiveItemCreateModel receiveItem)
        {
            if (receiveItem != null)
            {
                try
                {
                    HttpResponseMessage response = await client.PostAsJsonAsync("receiveitem/", receiveItem);

                    if (response.IsSuccessStatusCode)
                    {
                        ReceiveItemModel resModel = await response.Content.ReadAsAsync<ReceiveItemModel>();
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
            return null;
        }

        public async Task<List<ReceiveItemModel>> GetReceiveItems()
        {
            return await _receiveItemService.GetAll();
        }
    }

    public interface IReceiveItemService
    {
        Task<List<ReceiveItemModel>> GetReceiveItems();
        Task<ReceiveItemModel> CreateReceiveItem(ReceiveItemCreateModel receiveItem);
        void ConfirmReceive(int Id, string status);

    }
}
