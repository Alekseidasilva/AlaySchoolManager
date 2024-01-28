using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlaySchoolManager.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatriculasController : ControllerBase
    {

        /// <summary>
        /// Obter Todos Alunos Matriculados
        /// </summary>
        /// <returns>Coleção de Alunos Matriculados</returns>
        /// <responde code="200">Sucesso</responde>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<string> Matriculados()
        {
            return new string[] { "ALeksei da SIlva", "Telma Silva" };
        }

        /// <summary>
        /// Obter Aluno Matriculado
        /// </summary>
        /// <param name="id">Identificador da Matricula</param>
        /// <returns>Dados da Matricula</returns>
        /// <response code="200">Sucesso</response>
        /// <response code="404">Não Encontrado</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public string Get(string id)
        {
            return id;
        }

        /// <summary>
        /// Matricular Aluno
        /// </summary>
        /// <remarks>
        /// {Objecto Json }
        /// </remarks>
        /// <param name="value">Dados do Aluno</param>
        /// <returns>Objecto recem Criado</returns>
        /// <response code="201">Sucesso</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
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
