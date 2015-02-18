using System;
using System.Net;
using RestSharp;
using WebApp.Contracts;

namespace WebApp
{
    internal static class HttpRequestClient
    {
        private const string ClientId = "78f1acfec3254937907822e9d1607916";

        private const string InstagramRootUrl = "https://api.instagram.com";

        private const string GetTagnameInfoEndpoint = "/v1/tags/{0}";

        internal static int GetHashtagCount(string tagname)
        {
            var client = CreateClient(InstagramRootUrl);

            var uri = string.Format(GetTagnameInfoEndpoint, tagname);
            var request = CreateRequest(Method.GET, uri);

            request.AddParameter("client_id", ClientId);

            var response = client.Execute<HashTagSearchResponse>(request);

            if(response.StatusCode != HttpStatusCode.OK) throw new Exception("Api error");

            return response.Data.data.media_count;
        }

        private static RestClient CreateClient(string baseUrl)
        {
            return new RestClient(baseUrl);
        }

        private static RestRequest CreateRequest(Method method, string endpoint)
        {
            return new RestRequest(endpoint, method);
        }


    }
}