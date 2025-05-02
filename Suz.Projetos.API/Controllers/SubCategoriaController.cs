using Microsoft.AspNetCore.Mvc;
using Suz.Projetos.Domain.Entities;
using Suz.Projetos.Domain.Interfaces;

namespace Suz.Projetos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubCategoriaController : ControllerBase
    {
        private readonly ISubCategoriaRepository _subCategoriaRepository;

        public SubCategoriaController(ISubCategoriaRepository subCategoriaRepository)
        {
            _subCategoriaRepository = subCategoriaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _subCategoriaRepository.GetAllAsync();
                return Ok(result);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SubCategoria subCategoria)
        {
            try
            {
                await _subCategoriaRepository.SaveAsync(subCategoria);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
