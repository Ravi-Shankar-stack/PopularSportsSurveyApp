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
    }
}
