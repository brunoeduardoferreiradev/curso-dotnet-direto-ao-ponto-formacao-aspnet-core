﻿using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string query)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
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

            return CreatedAtAction(nameof(GetById), new {id = createProject.Id},createProject)
        }
    }
}
