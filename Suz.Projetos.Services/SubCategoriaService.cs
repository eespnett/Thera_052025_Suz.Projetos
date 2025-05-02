using Suz.Projetos.Domain.Entities;
using Suz.Projetos.Domain.Interfaces;

namespace Suz.Projetos.Service
{
    public class SubCategoriaService : ISubCategoriaService
    {
        private readonly ISubCategoriaRepository _subCategoriaRepository;

        public SubCategoriaService(ISubCategoriaRepository subCategoriaRepository)
        {
            _subCategoriaRepository = subCategoriaRepository;
        }

        public Task Create(SubCategoria subCategoria)
        {
            return _subCategoriaRepository.SaveAsync(subCategoria);
        }

        public Task<List<SubCategoria>> GetAllAsync()
        {
            return _subCategoriaRepository.GetAllAsync();
        }
    }
}
