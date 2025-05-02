using Suz.Projetos.Domain.Entities;

namespace Suz.Projetos.Domain.Interfaces
{
    public interface ISubCategoriaRepository
    {
        Task SaveAsync(SubCategoria subCategoria);
        Task<List<SubCategoria>> GetAllAsync();
    }
}
