using Api_Project.Data;
using Api_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {

        private readonly AppDbContext _appDbContext;

            public QuotesController(AppDbContext appDbContext)
            {
                _appDbContext = appDbContext;
            }


        // GET: api/<QuotesController>
        [HttpGet]
        public IEnumerable<Quote> Get()
        {
            return _appDbContext.Quotes;
        }

        // GET api/<QuotesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<QuotesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<QuotesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<QuotesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
