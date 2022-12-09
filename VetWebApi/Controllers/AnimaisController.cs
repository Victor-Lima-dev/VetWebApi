using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VetWebApi.Context;
using VetWebApi.Models;

namespace VetWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnimaisController : ControllerBase
    {
        //acessar banco de dados
        private readonly AppDbContext _context;
        //construtor
        public AnimaisController(AppDbContext context)
        {
            _context = context;
        }

        //metodo get para retornar uma lista de animal
        [HttpGet]
        public ActionResult<IEnumerable<Animal>> Get()
        {
            var animais = _context.Animais.ToList();

            return animais;
        }

        //metodo get para retornar um animal
        
        [HttpGet("{id}")]
        public ActionResult<Animal> Get(int id)
        {
            var animal = _context.Animais.Find(id);

            if (animal == null)
            {
                return NotFound();
            }

            return animal;
        }



    }
}
