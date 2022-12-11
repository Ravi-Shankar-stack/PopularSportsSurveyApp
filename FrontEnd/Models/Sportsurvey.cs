using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace FrontEnd.Models
{
    
    public class Sportsurvey
    {
        
        public List<SelectListItem> Sport { get; set; }

        
        public int SurveyId { get; set; }


        [Range(1, 10)]
        public int Rating { get; set; }
    }
}
