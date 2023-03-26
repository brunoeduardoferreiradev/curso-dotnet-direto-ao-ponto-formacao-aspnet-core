using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string query)
        {
            // Buscar todos ou Filtrar
            return Ok();
        }
        
        // api/projects/599 
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Buscar o Projeto
            // return NotFound();
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            // return Badrequest
            if(createProject.Title.Length > 50)
            {
                return BadRequest();
            }
            // Cadastrar o Projeto
            return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);
        }
        
        // api/projects/2
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
        {
            if(updateProject.Description.Length > 200)
            {
                return BadRequest();
            }
            // Atualizo o objeto
            return NoContent();
        }

        // api/projects/3
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Buscar, se não existir, retorna NotFound();

            // Remover

            return NoContent();
        }
    }
}
