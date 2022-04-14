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
    public class FakturaService : IFakturaService
    {
        private readonly HttpClient client;
        private readonly Request<FakturaCreateModel> _fakturaService;
        public FakturaService()
        {
            _fakturaService = new Request<FakturaCreateModel>("faktura");
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            client = new HttpClient(handler);
            client.BaseAddress = new Uri(StaticModels.BaseURL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {StaticModels.Token}");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<FakturaCreateResponse> CreateFaktura(FakturaCreateModel fakturaModel)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync("faktura/", fakturaModel);

                if (response.IsSuccessStatusCode)
                {
                    var resModel = await response.Content.ReadAsAsync<FakturaCreateResponse>();
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

        public async Task<List<FakturaCreateResponse>> GetFakturas()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("faktura");
                string code = response.StatusCode.ToString();
                if (response.IsSuccessStatusCode)
                {
                    List<FakturaCreateResponse> models = await response.Content.ReadAsAsync<List<FakturaCreateResponse>>();
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

        public async Task<List<FakturaCreateResponse>> GetFakturas(int status)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"faktura?status={status}");
                string code = response.StatusCode.ToString();
                if (response.IsSuccessStatusCode)
                {
                    List<FakturaCreateResponse> models = await response.Content.ReadAsAsync<List<FakturaCreateResponse>>();
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

        public async Task<FakturaCreateResponse> ConfirmFaktura(int Id, string status)
        {
            Uri url = new Uri(StaticModels.BaseURL + $"faktura/{Id}/");
            HttpContent httpContent = new StringContent("{\"status\":" + status + "}", Encoding.UTF8, "application/json");
            HttpResponseMessage message = await _fakturaService.PatchAsync(client, url, httpContent);
            FakturaCreateResponse createResponse = await message.Content.ReadAsAsync<FakturaCreateResponse>();
            return createResponse;
        }
    }

    public interface IFakturaService
    {
        Task<List<FakturaCreateResponse>> GetFakturas();
        Task<FakturaCreateResponse> CreateFaktura(FakturaCreateModel fakturaModel);
        Task<FakturaCreateResponse> ConfirmFaktura(int Id, string status);
    }
}
