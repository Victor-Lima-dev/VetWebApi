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
        //aplica o efeito e retonar o animal
        public ActionResult<Animal> AplicarEfeitos(int remedioId, int animalId)
        {
            try
            {
                Animal animal = _aplicarEfeitosService.AplicarEfeitos(remedioId, animalId);
                return animal;
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao aplicar efeitos");
            }

        }
    }
}
