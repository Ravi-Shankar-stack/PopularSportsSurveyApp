using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using FrontEnd.Models;

namespace FrontEnd.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FrontEnd.Models.Sport> Sport { get; set; }
        public DbSet<FrontEnd.Models.Survey> Survey { get; set; }

        public DbSet<FrontEnd.Models.Sportsurvey> Sportsurvey { get; set; }
    }
}
