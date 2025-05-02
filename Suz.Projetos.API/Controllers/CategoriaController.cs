using Microsoft.AspNetCore.Mvc;
using Suz.Projetos.Domain.Entities;
using Suz.Projetos.Domain.Interfaces;

namespace Suz.Projetos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _categoriaRepository.GetAllAsync();
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Categoria Categoria)
        {
            try
            {
                await _categoriaRepository.SaveAsync(Categoria);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
