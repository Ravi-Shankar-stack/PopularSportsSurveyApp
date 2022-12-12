using FrontEnd.Data;
using FrontEnd.Models;
using FrontEnd.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Controllers
{
    public class PopularSportController : Controller
    {
        IDataSvc _ds;
        public PopularSportController(IDataSvc ds)
        {
            _ds = ds;

        }

        public ActionResult Popular()
        {



            List<Popular> popularSport = new List<Popular>();

            popularSport = JsonConvert.DeserializeObject<List<Popular>>(_ds.GetSvcPopular());


            return View(popularSport);
        }
    }
}
