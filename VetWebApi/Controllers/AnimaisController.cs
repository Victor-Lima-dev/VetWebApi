using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        //metodo post para adicionar um animal
        [HttpPost]
        public ActionResult<Animal> Post(Animal animal)
        {
            _context.Animais.Add(animal);
            _context.SaveChanges();

            return CreatedAtAction(nameof(Get), new { id = animal.AnimalId }, animal);
        }

        //metodo put para atualizar um animal
        [HttpPut("{id}")]
        public ActionResult Put(int id, Animal animal)
        {
            if (id != animal.AnimalId)
            {
                return BadRequest();
            }

            _context.Entry(animal).State = EntityState.Modified;
            
            _context.SaveChanges();

            return Ok();
        }

        //metodo delete para deletar um animal
        [HttpDelete("{id}")]
        public ActionResult<Animal> Delete(int id)
        {
            var animal = _context.Animais.Find(id);

            if (animal == null)
            {
                return NotFound();
            }

            _context.Animais.Remove(animal);
            _context.SaveChanges();

            return animal;
        }

    }
}
