using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEnd.Models;
using FrontEnd.Services;
using Newtonsoft.Json;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace FrontEnd.Controllers
{
    public class SurveyController : Controller
    {
        // GET: Survey
        private IDataSvc svcRef;

        public SurveyController(IDataSvc dataSvc)

        {

            svcRef = dataSvc;

        }



        public ActionResult RatingSport()
        {
            Sportsurvey ss = new Sportsurvey();
            ss.Sport = PopulateSport();
            return View(ss);
        }

        // POST: Survey/Create
        [HttpPost]
        public ActionResult RatingSport(Sportsurvey surveyData)
        {
            Survey sd = new Survey();
            surveyData.Sport = PopulateSport();
            var selectedItem = surveyData.Sport.Find(p => p.Value == surveyData.SurveyId.ToString());
            if (selectedItem != null)
            {
                selectedItem.Selected = true;
                sd.SportName = selectedItem.Text;
                sd.Rating = surveyData.Rating;
                //sd.SurveyId = (int)surveyData.SurveyId;

            }

            string data = JsonConvert.SerializeObject(sd);
            StringContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var webClient = svcRef.GetSvcRef();
            HttpResponseMessage response = webClient.PostAsync(webClient.BaseAddress + "/Surveys", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("RatingSport");
            }
            return View();
        }
        private List<SelectListItem> PopulateSport()
        {
            var webClient = svcRef.GetSvcRef();
            HttpResponseMessage response = webClient.GetAsync(webClient.BaseAddress + "/Sports").Result;

            List<Sport> sList = new List<Sport>();

            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                sList = JsonConvert.DeserializeObject<List<Sport>>(data);
            }

            List<SelectListItem> ls = new List<SelectListItem>();
            foreach (var item in sList)
            {
                ls.Add(new SelectListItem { Text = item.SportName, Value = item.SportId.ToString() });
            }
            return ls;
        }

        // GET: Survey/Edit/5
        public ActionResult GerSurvey(int id)
        {
            return View();
        }

    }
}
