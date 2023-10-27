using System.Data;
using ALAYSchoolManager.Domain.Entidades;
using ALAYSchoolManager.Domain.Interfaces.Repository;
using ALAYSchoolManager.Infra.Data.Context;

namespace ALAYSchoolManager.Infra.Data.Repository;

public class MatriculaConfirmarRepository : BaseRepository<MatriculaConfirmar>, IMatriculaConfirmarRepository
{
    public MatriculaConfirmarRepository(AlaySchoolGetDbContext context) : base(context)
    {
    }

    public override IEnumerable<MatriculaConfirmar> ObterTodos()
    {
        _ado.LimparParametro();
        DataTable tbMatriculados = _ado.ExecutarConsulta(CommandType.StoredProcedure, "uspMatriculaConfirmadosListar");
        List<MatriculaConfirmar> matriculaCOnfirmados = new List<MatriculaConfirmar>();
        foreach (DataRow linha in tbMatriculados.Rows)
        {
            var mat = new MatriculaConfirmar
            {
                AlunoNMatricula = new Aluno
                {
                    AlunoNMatricula = Convert.ToString(linha["AlunoNMatricula"]),
                    PessoaNomeCompleto = Convert.ToString(linha["PessoaNomeCompleto"])
                },
                AnoAcademicoId = new AnoAcademico
                {
                    AnoAcademicoDesignacao = Convert.ToString(linha["AnoAcademicoDesignacao"])
                },
                DataHora = Convert.ToDateTime(linha["DataHora"]),
                UsuarioCadastrador = Convert.ToString(linha["UsuarioCadastrador"])

            };
            matriculaCOnfirmados.Add(mat);
        }
        return matriculaCOnfirmados;
    }
}