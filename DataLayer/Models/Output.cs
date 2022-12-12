using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Output
    {
        [Key]
        public string SportName { get; set; }

        public int Total { get; set; }
    }
}

