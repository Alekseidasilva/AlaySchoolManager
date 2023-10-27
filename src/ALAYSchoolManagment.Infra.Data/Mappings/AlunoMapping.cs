using ALAYSchoolManager.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ALAYSchoolManager.Infra.Data.Mappings;

public class AlunoMapping : IEntityTypeConfiguration<Aluno>
{
    public void Configure(EntityTypeBuilder<Aluno> builder)
    {
        builder.ToTable("TBAlunos");

        //builder.HasKey(a => a.AlunoNMatricula);


        //builder.HasOne(p => p.Usuario)
        //    .WithMany()
        //    .HasForeignKey(p => p.AlunoUsuarioCadastrador);


    }
}