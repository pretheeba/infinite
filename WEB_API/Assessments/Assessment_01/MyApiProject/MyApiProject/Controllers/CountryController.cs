using System.Collections.Generic;
using System.Web.Http;
using MyApiProject.Models;

namespace MyApiProject.Controllers
{
    [RoutePrefix("api/countries")]
    public class CountryController : ApiController
    {
        private static List<Country> countries = new List<Country>
        {
            new Country { ID = 1, CountryName = "India", Capital = "New Delhi" },
            new Country { ID = 2, CountryName = "France", Capital = "Paris" }
        };

        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(countries);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IHttpActionResult Get(int id)
        {
            Country country = null;
            foreach (var c in countries)
            {
                if (c.ID == id)
                {
                    country = c;
                    break;
                }
            }

            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Post([FromBody] Country country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            int newId = 1;
            foreach (var c in countries)
            {
                if (c.ID >= newId)
                {
                    newId = c.ID + 1;
                }
            }

            country.ID = newId;
            countries.Add(country);

            return Created($"api/countries/{country.ID}", country);
        }

        [HttpPut]
        [Route("{id:int}")]
        public IHttpActionResult Put(int id, [FromBody] Country country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            foreach (var c in countries)
            {
                if (c.ID == id)
                {
                    c.CountryName = country.CountryName;
                    c.Capital = country.Capital;
                    return StatusCode(System.Net.HttpStatusCode.NoContent);
                }
            }

            return NotFound();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            Country countryToRemove = null;
            foreach (var c in countries)
            {
                if (c.ID == id)
                {
                    countryToRemove = c;
                    break;
                }
            }

            if (countryToRemove == null)
            {
                return NotFound();
            }

            countries.Remove(countryToRemove);
            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }
    }
}
