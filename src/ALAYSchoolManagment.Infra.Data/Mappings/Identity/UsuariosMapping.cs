using ALAYSchoolManager.Domain.Entidades.Oldest.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ALAYSchoolManager.Infra.Data.Mappings.Identity;

public class UsuariosMapping : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("TBUsuarios");
        builder.HasKey(x => x.Id);
    }
}