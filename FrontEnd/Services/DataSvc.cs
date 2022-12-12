using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace FrontEnd.Services
{
    public class DataSvc : IDataSvc
    {
        string url = "http://localhost:18601/api";
        HttpClient webClient = new HttpClient();
        public DataSvc()
        {
            webClient.BaseAddress = new Uri(url);
        }

        public HttpClient GetSvcRef()
        {
            return webClient;
        }

        //public string GetSvcSport()
        //{
        //    HttpResponseMessage response = webClient.GetAsync(webClient.BaseAddress + "/Sports").Result;
        //    string data = response.Content.ReadAsStringAsync().Result;
        //    return data;

        //}

        //public string GetSvcSurvey()
        //{
        //    HttpResponseMessage response = webClient.GetAsync(webClient.BaseAddress + "/Surveys").Result;
        //    string data = response.Content.ReadAsStringAsync().Result;
        //    return data;

        //}

        public string GetSvcPopular()
        {
            HttpResponseMessage response = webClient.GetAsync(webClient.BaseAddress + "/Outputs").Result;
            string data = response.Content.ReadAsStringAsync().Result;
            return data;

        }

        //public HttpResponseMessage PostSport(StringContent str)
        //{
        //    HttpResponseMessage response = webClient.PostAsync(webClient.BaseAddress + "/Sports", str).Result;
        //    return response;

        //}

        //public HttpResponseMessage PostSurvey(StringContent str)
        //{
        //    HttpResponseMessage response = webClient.PostAsync(webClient.BaseAddress + "/Surveys", str).Result;
        //    return response;

        //}

    }
}
