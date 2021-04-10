using System;
using System.Net;
using System.Net.Http;

namespace HttpService
{
    public class HttpClient
    {
        static HttpResponseMessage Post(string url, HttpContent data)
        {
            System.Net.Http.HttpClient hc = new System.Net.Http.HttpClient();
            return hc.PostAsync(url,data).Result;
        }      
        static HttpResponseMessage Get(string url)
        {
            System.Net.Http.HttpClient hc = new System.Net.Http.HttpClient();
            return hc.GetAsync(url).Result;
        }
        static HttpResponseMessage Send(HttpRequestMessage req, HttpContent data)
        {
            System.Net.Http.HttpClient hc = new System.Net.Http.HttpClient();
            return hc.SendAsync(req).Result;
        }
        static string ResponseString(HttpResponseMessage msg)
        {
            using (HttpContent c = msg.Content)
            {
                return c.ReadAsStringAsync().Result;
            }
        }
        
    }

}
