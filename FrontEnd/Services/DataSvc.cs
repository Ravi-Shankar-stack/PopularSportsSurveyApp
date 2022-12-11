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
    }
}
