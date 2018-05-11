using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Review15PersonalProfolio.Models;

namespace Review15PersonalProfolio.Models
{
    public class ApiCall
    {


        public List<Repo> GetRepos()
        {
            var client = new RestClient("https://api.github.com");
            var request = new RestRequest("users/LeeMellon/repos?page=100", Method.GET);
            request.AddHeader("User-Agent", EV.Key);
            var response = new RestResponse();

            Task.Run(async () =>
            {
                response = await GetRestResponceContentAsync(client, request) as RestResponse;
            }).Wait();

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(response.Content);
            var results = JsonConvert.DeserializeObject<List<Repo>>(jsonResponse.ToString());

            return results;
        }


        public List<Repo> GetStarred()
        {
            var client = new RestClient("https://api.github.com");
            var request = new RestRequest("users/LeeMellon/starred?page=1&per_page=3", Method.GET);
            request.AddHeader("User-Agent", EV.Key);
            var response = new RestResponse();

            Task.Run(async () =>
            {
                response = await GetRestResponceContentAsync(client, request) as RestResponse;
            }).Wait();

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(response.Content);
            var results = JsonConvert.DeserializeObject<List<Repo>>(jsonResponse.ToString());


            return results;
        }



        public static Task<IRestResponse> GetRestResponceContentAsync(RestClient theClient, RestRequest theRequest)
        {
            var tcs = new TaskCompletionSource<IRestResponse>();
            theClient.ExecuteAsync(theRequest, responce =>
            {
                tcs.SetResult(responce);
            });
            return tcs.Task;
        }
    }
}
