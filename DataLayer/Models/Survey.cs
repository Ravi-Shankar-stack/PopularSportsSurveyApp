using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataLayer.Models
{
    public partial class Survey
    {
        public int SurveyId { get; set; }
        public string SportName { get; set; }
        public int Rating { get; set; }
    }
}
