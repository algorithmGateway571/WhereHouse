using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Warehouse.API
{
    public class Request<T>
    {

        private readonly HttpClient client;
        private readonly string query;
        string localUrl = "http://159.223.18.152:8000/api/";

        public Request(string modelName)
        {
            query = modelName + "/";
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

        public async Task<T> Get(string url)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(query + url);

                if (response.IsSuccessStatusCode)
                {
                    var model = await response.Content.ReadAsAsync<T>();
                    return model;
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

        public async Task<List<T>> GetAll()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(query);
                string code = response.StatusCode.ToString();
                if (response.IsSuccessStatusCode)
                {
                    T[] models = await response.Content.ReadAsAsync<T[]>();
                    return models.ToList();
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

        public async Task<T> Put(int id, T model)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync(query + $"{id}", model);
                if (response.IsSuccessStatusCode)
                {
                    var resModel = await response.Content.ReadAsAsync<T>();
                    return resModel;
                }
                else
                {
                    throw new Exception("Not Found!!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<T> Delete(int id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync(query + $"{id}");
                if (response.IsSuccessStatusCode)
                {
                    var resModel = await response.Content.ReadAsAsync<T>();
                    return resModel;
                }
                else
                {
                    throw new Exception("Not Found!!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<T> Post(string url, T model)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(query + url, model);

                if (response.IsSuccessStatusCode)
                {
                    var resModel = await response.Content.ReadAsAsync<T>();
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

        public async Task<List<T>> PostAll(string url, List<T> data)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(query + url, data);
                if (response.IsSuccessStatusCode)
                {
                    var models = await response.Content.ReadAsAsync<T[]>();
                    return models.ToList();
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


        public async Task<HttpResponseMessage> PatchAsync(HttpClient client, Uri requestUri, HttpContent iContent)
        {
            var method = new HttpMethod("PATCH");

            var request = new HttpRequestMessage(method, requestUri)
            {
                Content = iContent
            };

            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                response = await client.SendAsync(request);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return response;
        }
    }
}
