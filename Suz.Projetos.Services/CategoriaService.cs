using Suz.Projetos.Domain.Entities;
using Suz.Projetos.Domain.Interfaces;

namespace Suz.Projetos.Service
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public Task Create(Categoria categoria)
        {
            return _categoriaRepository.SaveAsync(categoria);
        }

        public Task<List<Categoria>> GetAllAsync()
        {
            return _categoriaRepository.GetAllAsync();
        }
    }
}
