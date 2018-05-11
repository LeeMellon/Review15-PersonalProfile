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
            var request = new RestRequest("users/LeeMellon/repos", Method.GET);
            request.AddHeader("User-Agent", EV.Key);
            var response = new RestResponse();

            Task.Run(async () =>
            {
                response = await GetRestResponceContentAsync(client, request) as RestResponse;
            }).Wait();

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(response.Content);
            var results = JsonConvert.DeserializeObject<List<Repo>>(jsonResponse.ToString());
            //Console.WriteLine(results[0].Name);
            //Console.WriteLine(results[1].Name);
            //Console.WriteLine(results[2].Name);
            //Console.WriteLine(results[3].Name);
            //Console.ReadLine();

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
