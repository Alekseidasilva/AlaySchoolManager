using ALAYSchoolManager.Domain.Entidades.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ALAYSchoolManager.Infra.Data.Mappings.Shared;

public class ModulosMapping : IEntityTypeConfiguration<Modulos>
{
    public void Configure(EntityTypeBuilder<Modulos> builder)
    {
        builder.ToTable("TBModulos");
        builder.HasKey(p => p.ModuloId);
    }
}