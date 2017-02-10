using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFeeler.Rest.Client
{
    public abstract class MovieDBBaseApi
    {
        readonly string _apikey = "";
        readonly string _secretkey = "";
        readonly string _baseUrl = "";
        private readonly RestClient _client;
        
        public MovieDBBaseApi(string apikey, string secretkey, string baseUrl)
        {
            _secretkey = secretkey;
            _apikey = apikey;
            _baseUrl = baseUrl;

            _client = new RestClient();
            _client.BaseUrl = new Uri(baseUrl);
        }

        public MovieDBBaseApi(string apikey, string baseUrl)
        {
            _apikey = apikey;
            _baseUrl = baseUrl;

            _client = new RestClient();
            _client.BaseUrl = new Uri(baseUrl);
        }

        public virtual T ExecuteRequest<T>(RestRequest restRequest) where T : new()
        {
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddParameter("api_key", _apikey);
            var response = _client.Execute(restRequest);
            return JsonConvert.DeserializeObject<T>(response.Content);
        }
    }
}
