using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Warehouse.API.API_Models;

namespace Warehouse.API.APIServices
{
    public class ReceiveService : IReceiveService
    {
        private readonly HttpClient client;
        public ReceiveService()
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

        public async Task<ReceiveResponseModel> CreateReceive(ReceiveModel receive)
        {
            if (receive != null)
            {
                try
                {
                    HttpResponseMessage response = await client.PostAsJsonAsync("receive/", receive);

                    if (response.IsSuccessStatusCode)
                    {
                        ReceiveResponseModel resModel = await response.Content.ReadAsAsync<ReceiveResponseModel>();
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

        public async Task<List<ReceiveResponseModel>> GetReceives()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("receive/");
                string code = response.StatusCode.ToString();
                if (response.IsSuccessStatusCode)
                {
                    List<ReceiveResponseModel> models = await response.Content.ReadAsAsync<List<ReceiveResponseModel>>();
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

    public interface IReceiveService
    {
        Task<List<ReceiveResponseModel>> GetReceives();
        Task<ReceiveResponseModel> CreateReceive(ReceiveModel receive);
        
    }
}
