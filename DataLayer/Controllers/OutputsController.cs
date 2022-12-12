using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataLayer.Models;

namespace DataLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OutputsController : ControllerBase
    {
        private readonly SurveyDBContext _context;

        public OutputsController(SurveyDBContext context)
        {
            _context = context;
        }

        // GET: api/Outputs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Output>>> GetOutput()
        {
            string StoredProc = "exec popularSport ";
            return await _context.Output_1.FromSqlRaw(StoredProc).ToListAsync();

            // GET: api/Outputs/5
        }
    }
}
