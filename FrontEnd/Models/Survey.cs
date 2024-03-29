﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public class Survey
    {
        public int SurveyId { get; set; }
        public string SportName { get; set; }

        [Range(1,10)]
        public int Rating { get; set; }
    }
}
