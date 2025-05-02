using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Suz.Projetos.Domain.Entities;

namespace Suz.Projetos.Persistence.Configurations
{
    public class SubCategoriaConfiguration : IEntityTypeConfiguration<SubCategoria>
    {
        public void Configure(EntityTypeBuilder<SubCategoria> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(e => e.DataCriacao)
                .IsRequired() ;

            builder.Property(e => e.DescricaoSubCategoria)
                .IsRequired()
                .HasMaxLength(2048);
        }
    }
}
