using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Suz.Projetos.Domain.Entities;

namespace Suz.Projetos.Persistence.Configurations
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(e => e.DataCriacao)
                .IsRequired();

            builder.Property(e => e.DescricaoCategoria)
                .IsRequired()
                .HasMaxLength(2048);

            builder.Property(e => e.SubCategoria)
              .IsRequired() ;
        }
    }
}
