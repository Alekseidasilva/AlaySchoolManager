using ALAYSchoolManager.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ALAYSchoolManager.Infra.Data.Mappings;

public class MatriculaConfirmarMapping : IEntityTypeConfiguration<MatriculaConfirmar>
{
    public void Configure(EntityTypeBuilder<MatriculaConfirmar> builder)
    {
        //builder.ToTable("TBMatriculaConfirmacao");
        //builder.HasKey(x => new { x.AlunoNMatricula, x.AnoAcademicoId });

        //builder.HasOne(x => x.AlunoNMatricula.AlunoNMatricula)
        //    .WithOne();

        //builder.HasOne<Aluno>(x => x.AlunoNMatricula.AlunoNMatricula)
        //    .WithOne<MatriculaConfirmar>
        throw new NotImplementedException();



    }
}