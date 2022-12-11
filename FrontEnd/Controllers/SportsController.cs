using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using FrontEnd.Models;
using FrontEnd.Services;

namespace FrontEnd.Controllers
{
    public class SportsController : Controller
    {

        private IDataSvc svcRef;

        public SportsController(IDataSvc dataSvc)
        {
            svcRef = dataSvc;
        }

        // GET: 
        public ActionResult GetSport()
        {
            var webClient = svcRef.GetSvcRef();
            HttpResponseMessage response = webClient.GetAsync(webClient.BaseAddress + "/Sports").Result;

            List<Sport> sList = new List<Sport>();

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                sList = JsonConvert.DeserializeObject<List<Sport>>(data);
            }
            return View(sList);
        }



        // GET: Sport/Create
        
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sport/Create
        [HttpPost]
        public ActionResult Create(Sport sports)
        {
            string data = JsonConvert.SerializeObject(sports);
            StringContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

            var webClient = svcRef.GetSvcRef();
            HttpResponseMessage response = webClient.PostAsync(webClient.BaseAddress + "/Sports", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("GetSport");
            }
            return View();
        }




    }
}
