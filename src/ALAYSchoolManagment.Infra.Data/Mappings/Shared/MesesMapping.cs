using ALAYSchoolManagment.Domain.Entidades.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ALAYSchoolManagment.Infra.Data.Mappings.Shared;

public class MesesMapping : IEntityTypeConfiguration<Meses>
{
    public void Configure(EntityTypeBuilder<Meses> builder)
    {
        builder.ToTable("TBMeses");
        builder.HasKey(p => p.MesId);
    }
}