using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Warehouse.API.API_Models;

namespace Warehouse.API.APIServices
{
    public class FakturaService : IFakturaService
    {
        private readonly HttpClient client;
        private readonly string query;
        string localUrl = "http://159.223.18.152:8000/api/";
        private readonly Request<FakturaCreateModel> _fakturaService;
        public FakturaService()
        {
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
                HttpResponseMessage response = await client.GetAsync("factura/");
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

        public bool PatchFaktura()
        {
            throw new NotImplementedException();
        }
    }

    public interface IFakturaService
    {
        Task<List<FakturaCreateResponse>> GetFakturas();
        Task<FakturaCreateResponse> CreateFaktura(FakturaCreateModel fakturaModel);
        bool PatchFaktura();
    }
}
