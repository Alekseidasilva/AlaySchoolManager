using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlaySchoolManager.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatriculasController : ControllerBase
    {
        // GET: api/<MatriculasController>
        [HttpGet]
        public IEnumerable<string> Matriculados()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MatriculasController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MatriculasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MatriculasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MatriculasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
