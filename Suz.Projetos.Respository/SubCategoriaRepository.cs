using Microsoft.EntityFrameworkCore;
using Suz.Projetos.Domain.Entities;
using Suz.Projetos.Domain.Interfaces;

namespace Suz.Projetos.Respository
{
    public class SubCategoriaRepository : ISubCategoriaRepository
    {
        private readonly DbContext _dbContext;
        public SubCategoriaRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SaveAsync(SubCategoria _subCategoria)
        {
            _dbContext.Set<SubCategoria>().Add(_subCategoria);
            await _dbContext.SaveChangesAsync();
        }

        public Task<List<SubCategoria>> GetAllAsync()
        {
            return _dbContext.Set<SubCategoria>().ToListAsync();
        }
    }
}
