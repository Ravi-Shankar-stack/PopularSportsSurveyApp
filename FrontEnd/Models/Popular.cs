using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public class Popular
    {
        [Key]
        public string SportName { get; set; }

        public int Total { get; set; }
    }
}
