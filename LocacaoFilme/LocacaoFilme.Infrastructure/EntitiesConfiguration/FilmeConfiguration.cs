using LocacaoFilme.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocacaoFilme.Infrastructure.EntitiesConfiguration
{
    public class FilmeConfiguration : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Titulo).HasMaxLength(100).IsRequired();
            builder.Property(p => p.ClassificacaoIndicativa).IsRequired();
            builder.Property(p => p.Lancamento).IsRequired();
            builder.HasIndex(i => i.Lancamento);
            builder.HasIndex(i => i.Titulo);
        }
    }
}
