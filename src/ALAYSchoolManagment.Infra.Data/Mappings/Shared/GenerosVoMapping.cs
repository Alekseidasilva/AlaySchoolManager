using ALAYSchoolManager.Domain.Entidades.Vo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ALAYSchoolManager.Infra.Data.Mappings.Shared;

public class GenerosVoMapping : IEntityTypeConfiguration<GenerosVo>
{
    public void Configure(EntityTypeBuilder<GenerosVo> builder)
    {
        builder.ToTable("TBGeneros");
        builder.HasKey(p => p.GeneroId);

        //builder.Property(p => p.GeneroDesignacao)
        //    .HasColumnName("GeneroDesignacao")
        //    .HasColumnType("varchar(20)");

    }
}