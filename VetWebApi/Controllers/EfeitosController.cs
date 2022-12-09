using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VetWebApi.Context;
using VetWebApi.Models;
using VetWebApi.Services;

namespace VetWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EfeitosController : ControllerBase
    {
        //conexao com banco de dados
        private readonly AplicarEfeitosService _aplicarEfeitosService;
        //construtor
        public EfeitosController(AplicarEfeitosService aplicarEfeitosService)
        {
            _aplicarEfeitosService = aplicarEfeitosService;
        }

        
        [HttpPut]

        public ActionResult AplicaEfeito(int animalId, int remedioId)
        {
            var animal = _aplicarEfeitosService.AplicarEfeitos(remedioId, animalId);
            
            return Ok(animal);
        }
        
       
        
        
        

    }
}
