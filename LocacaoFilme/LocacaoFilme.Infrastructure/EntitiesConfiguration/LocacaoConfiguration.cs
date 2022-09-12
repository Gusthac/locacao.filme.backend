using LocacaoFilme.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocacaoFilme.Infrastructure.EntitiesConfiguration
{
    public class LocacaoConfiguration : IEntityTypeConfiguration<Locacao>
    {
        public void Configure(EntityTypeBuilder<Locacao> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.DataLocacao).IsRequired();

            builder.Property(p => p.Id_Cliente).HasColumnName("Id_Cliente").IsRequired();
            builder.HasOne(p => p.Cliente).WithMany().HasForeignKey(p => p.Id_Cliente);

            builder.Property(p => p.Id_Filme).HasColumnName("Id_Filme").IsRequired();
            builder.HasOne(p => p.Filme).WithMany().HasForeignKey(p => p.Id_Filme);
        }
    }

}
