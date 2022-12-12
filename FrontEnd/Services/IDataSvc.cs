using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FrontEnd.Services
{
    public interface IDataSvc
    {
        HttpClient GetSvcRef();

        //public string GetSvcSport();

        //public string GetSvcSurvey();

        public string GetSvcPopular();

        //public HttpResponseMessage PostSport(StringContent str);

        //public HttpResponseMessage PostSurvey(StringContent str);
    }
}
