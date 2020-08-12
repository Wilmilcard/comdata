using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMDATA_API.Class;
using COMDATA_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace COMDATA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly ApiDbContext context;

        public PersonaController(ApiDbContext context)
        {
            this.context = context;
        }

        // GET: api/Persona
        [HttpGet]
        public IEnumerable<Persona> Get()
        {
            return context.Persona.ToList();
        }

        // GET: api/Persona/5
        [HttpGet("{id}", Name = "Get")]
        public Persona Get(int id)
        {
            var persona = context.Persona.FirstOrDefault(p => p.Id == id);
            return persona;
        }

        // POST: api/Persona
        [HttpPost]
        public ActionResult Post([FromBody] Persona persona)
        {
            try
            {
                context.Persona.Add(persona);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // PUT: api/Persona/5
        [HttpPut()]
        public ActionResult Put([FromBody] Persona persona)
        {
            try
            {
                context.Entry(persona).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var persona = context.Persona.FirstOrDefault(p => p.Id == id);
            if (persona != null)
            {
                try
                {
                    context.Persona.Remove(persona);
                    context.SaveChanges();
                    return Ok();
                }
                catch (Exception ex)
                {
                    return BadRequest();
                }
            }
            else
            {
                return BadRequest("No se encontro Persona");
            }
        }
    }
}
