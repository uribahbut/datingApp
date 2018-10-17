using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dating.api.Data;
using Dating.api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Datingapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public DataContext _DbContext { get; }

        public ValuesController(DataContext dbContext)
        {
            _DbContext = dbContext;
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var myValues = await _DbContext.Values.ToListAsync();
            return Ok(myValues);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async  Task<IActionResult> GetValue(int id)
        {
            var val = await _DbContext.Values.FirstOrDefaultAsync(_ => _.Id == id);
            return  Ok(val);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
