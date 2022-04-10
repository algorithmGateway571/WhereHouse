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
        public FakturaItemService()
        {
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
                HttpResponseMessage response = await client.GetAsync("fakturaitem/");
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
    }
}
