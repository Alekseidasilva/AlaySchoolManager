﻿using ALAYSchoolManager.Domain.Entidades.Vo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ALAYSchoolManager.Infra.Data.Mappings.Shared;

public class EstadoCivilVoMapping : IEntityTypeConfiguration<EstadoCivilVo>
{
    public void Configure(EntityTypeBuilder<EstadoCivilVo> builder)
    {

        builder.ToTable("TBEstadoCivil");
        builder.HasKey(p => p.EstadoCivilId);
    }
}