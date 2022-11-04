using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlueYonder.Flights.Models;

namespace BlueYonder.Flights.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly FlightsContext _context;

        public FlightsController(FlightsContext context)
        {
           _context = context;
        }

        // GET api/flights
        [HttpGet]
        public IEnumerable<Flight> Get()
        {
           return _context.Flights.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Flight flight)
        {
            _context.Flights.Add(flight);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), flight.Id);
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
