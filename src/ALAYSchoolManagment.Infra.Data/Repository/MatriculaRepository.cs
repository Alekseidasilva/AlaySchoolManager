using System.Data;
using ALAYSchoolManager.Domain.Entidades;
using ALAYSchoolManager.Domain.Entidades.Shared;
using ALAYSchoolManager.Domain.Interfaces.Repository;
using ALAYSchoolManager.Infra.Data.Context;
using ALAYSchoolManager.Infra.Data.Repository.Shared;

namespace ALAYSchoolManager.Infra.Data.Repository;

public class MatriculaRepository : BaseSharedRepository<Matriculas>, IMatriculaRepository
{
    public MatriculaRepository(AlaySchoolGetDbContext context) : base(context)
    {
    }
    public override IEnumerable<Matriculas> ObterTodos()
    {
        _ado.LimparParametro();
        DataTable tbMatriculados = _ado.ExecutarConsulta(CommandType.StoredProcedure, "uspMastriculadosListar");
        List<Matriculas> matriculados = new List<Matriculas>();
        foreach (DataRow linha in tbMatriculados.Rows)
        {
            var mat = new Matriculas
            {
                Id = Convert.ToInt32(linha["MatriculaId"]),

                MatriculaAlunoId = new Aluno
                {
                    AlunoNMatricula = Convert.ToString(linha["AlunoNMatricula"]),
                    PessoaNomeCompleto = Convert.ToString(linha["PessoaNomeCompleto"]),
                    PessoaContribuinte = Convert.ToString(linha["PessoaContribuinte"]),
                    PessoaDataNascimento = Convert.ToDateTime(linha["PessoaDataNascimento"])
                },
                MatriculaAnoAcademicoId = new AnoAcademico
                {
                    AnoAcademicoDesignacao = Convert.ToString(linha["AnoAcademicoDesignacao"])
                },
                MatriculaModuloId = new Modulos
                {
                    ModuloId = Convert.ToInt16(linha["ModuloId"]),
                    ModuloDesignacao = Convert.ToString(linha["ModuloDesignacao"])
                },
                MatriculaDataHora = Convert.ToDateTime(linha["MatriculaDataHora"]),
                MatriculaUsuarioId = Convert.ToString(linha["MatriculaUsuarioId"])

            };
            matriculados.Add(mat);
        }
        return matriculados;
    }

    public string EfectuarMatricula(Matriculas matricula)
    {


        _ado.LimparParametro();
        //db.AdicionarParametros("", matricula.MatriculaAluno.AlunoNMatricula);

        _ado.ExecutarManipulacao(CommandType.StoredProcedure, "");


        return string.Empty;
    }
}