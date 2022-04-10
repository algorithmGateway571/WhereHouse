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
    public class FakturaItemService : IFakturaItemService
    {
        private readonly HttpClient client;
        private readonly Request<FakturaCreateModel> _fakturaRequest;
        string localUrl = "http://159.223.18.152:8000/api/";
        public FakturaItemService()
        {
            _fakturaRequest = new Request<FakturaCreateModel>("faktura");

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

        public async void ConfirmFaktura(int Id, string status)
        {
            Uri url = new Uri(localUrl + $"receive/{Id}");
            HttpContent httpContent = new StringContent("{\"status\":" + status + "}", Encoding.UTF8, "application/json-patch+json");
            await _fakturaRequest.PatchAsync(client, url, httpContent);
        }

        public async Task<FakturaItemCreateResponse> CreateFakturaItem(FakturaItemModel fakturaItem)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("fakturaitem/", fakturaItem);

                if (response.IsSuccessStatusCode)
                {
                    var resModel = await response.Content.ReadAsAsync<FakturaItemCreateResponse>();
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

        public async Task<List<FakturaItemCreateResponse>> GetFakturaItems()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("factura/");
                string code = response.StatusCode.ToString();
                if (response.IsSuccessStatusCode)
                {
                    List<FakturaItemCreateResponse> models = await response.Content.ReadAsAsync<List<FakturaItemCreateResponse>>();
                    return models;
                }
                else
                {
                    throw new Exception("Did not get data prperly");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
    public interface IFakturaItemService
    {
        Task<List<FakturaItemCreateResponse>> GetFakturaItems();
        Task<FakturaItemCreateResponse> CreateFakturaItem(FakturaItemModel fakturaItem);
        void ConfirmFaktura(int Id, string status);
    }
}
