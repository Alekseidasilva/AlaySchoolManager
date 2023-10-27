using ALAYSchoolManager.Domain.Entidades.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ALAYSchoolManager.Infra.Data.Mappings.Shared;

public class FormasPagamentoMapping : IEntityTypeConfiguration<FormasPagamentos>
{
    public void Configure(EntityTypeBuilder<FormasPagamentos> builder)
    {
        builder.ToTable("TBFormasPagamento");
        builder.HasKey(p => p.FormasPagamentoId);
        builder.Property(p => p.FormasPagamentoDesignacao)
            .HasColumnType("varchar(30)")
            .HasColumnName("FormasPagamentoDesignacao")
            .IsRequired();
    }
}