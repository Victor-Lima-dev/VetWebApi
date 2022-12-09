using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VetWebApi.Context;
using VetWebApi.Models;

namespace VetWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RemediosController : ControllerBase
    {
        //conexao banco de dados
        private readonly AppDbContext _context;
        //construtor
        public RemediosController(AppDbContext context)
        {
            _context = context;
        }

        //metodo get para retornar uma lista de remedio

        [HttpGet]
        public ActionResult<IEnumerable<Remedio>> Get()
        {
            var remedios = _context.Remedios.ToList();

            return remedios;
        }

        //metodo get para retornar um remedio

        [HttpGet("{id}")]
        public ActionResult<Remedio> Get(int id)
        {
            var remedio = _context.Remedios.Find(id);

            if (remedio == null)
            {
                return NotFound();
            }

            return remedio;
        }

        //metodo post para adicionar um remedio

        [HttpPost]
        public ActionResult<Remedio> Post(Remedio remedio)
        {
            _context.Remedios.Add(remedio);
            _context.SaveChanges();

            return CreatedAtAction(nameof(Get), new { id = remedio.RemedioId }, remedio);
        }

        //metodo put para atualizar um remedio

        [HttpPut("{id}")]
        public ActionResult Put(int id, Remedio remedio)
        {
            if (id != remedio.RemedioId)
            {
                return BadRequest();
            }

            _context.Entry(remedio).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        //metodo delete para deletar um remedio

        [HttpDelete("{id}")]
        public ActionResult<Remedio> Delete(int id)
        {
            var remedio = _context.Remedios.Find(id);

            if (remedio == null)
            {
                return NotFound();
            }

            _context.Remedios.Remove(remedio);
            _context.SaveChanges();

            return remedio;
        }
    }
}
