using System;
using System.Net;
using System.Net.Http;

namespace Serialization
{
    internal class HttpClientWrapper
    {
        public Uri BaseAddress { set; get; }

        public bool Ping()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = BaseAddress;
                var response = client.GetAsync("Ping").Result;
                return response.StatusCode == HttpStatusCode.OK;
            }
        }

        public T GetInputData<T>()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = BaseAddress;
                var response = client.GetAsync("GetInputData");
                var content = response.Result.Content;
                var json = content.ReadAsStringAsync().Result;
                var serializator = new JsonSerializer<T>();
                return serializator.Deserialize(json);
            }
        }

        public void WriteAnswer<T>(T obj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = this.BaseAddress;
                var serializator = new JsonSerializer<T>();
                var json = serializator.Serialize(obj);

                var response = client.PostAsync("WriteAnswer", new StringContent(json)).Result;
                Console.WriteLine("Finish");
            }
        }
    }
}
