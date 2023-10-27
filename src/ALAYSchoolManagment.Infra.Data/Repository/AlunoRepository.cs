using ALAYSchoolManager.Domain.Entidades;
using ALAYSchoolManager.Domain.Interfaces.Repository;
using ALAYSchoolManager.Infra.Data.Context;

namespace ALAYSchoolManager.Infra.Data.Repository;

public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
{
    public AlunoRepository(AlaySchoolGetDbContext context) : base(context)
    {

    }
    public IEnumerable<Aluno> ObterTodosPorModulo(int moduloId)
    {
        //var alunos = (from a in _db.Aluno

        //              join matri in _db.Matriculas on a.AlunoNMatricula equals matri.AlunoNMatricula
        //              where matri.MatriculaModuloId == moduloId
        //              join p in _db.Pessoas on a.Id equals p.Id
        //              join g in _db.Generos on p.PessoaGeneroId equals g.GeneroId
        //              join mod in _db.Modulos on matri.MatriculaModuloId equals mod.ModuloId
        //              select new { matri, a, p, g });

        List<Aluno> alunoList = new List<Aluno>();
        //foreach (var aluno in alunos)
        //{
        //    var alunoN = new Aluno
        //    {
        //        Id = aluno.a.Id,
        //        PessoaNomeCompleto = aluno.p.PessoaNomeCompleto,
        //        PessoaContribuinte = aluno.p.PessoaContribuinte,
        //        PessoaDataNascimento = aluno.p.PessoaDataNascimento,
        //        PessoaGeneroId = aluno.p.PessoaGeneroId,
        //        PessoaGenero = new Genero
        //        {
        //            GeneroId = aluno.g.GeneroId,
        //            GeneroDesignacao = aluno.g.GeneroDesignacao

        //        },
        //        PessoaDataCadastro = aluno.p.PessoaDataCadastro,
        //        AlunoNumeroMatricula = aluno.a.AlunoNumeroMatricula,
        //        PessoaEstado = aluno.p.PessoaEstado

        //    };
        //    alunoList.Add(alunoN);

        //}
        return alunoList;
    }

    public long UltimoNumeroMatricula()
    {

        //if (_db.Aluno.ToList().Count <= 0)
        //    return 0;
        //else
        //    return _db.Aluno.Max(aluno => aluno.AlunoNMatricula);
        return UltimoNumeroMatricula();

    }

    public Aluno? BuscarPeloNMatricula(string? nMatricula)
    {

        //var alun = (from aluno in _db.Aluno
        //                //where aluno.AlunoNumeroMatricula == nMatricula
        //            join pessoa in _db.Pessoas on aluno.Id equals pessoa.Id
        //            join genero in _db.Generos on pessoa.PessoaGeneroId equals genero.GeneroId
        //            join estadoCivil in _db.EstadoCivil on pessoa.FuncionarioEstadoCivilId equals estadoCivil.EstadoCivilId
        //            select new { aluno, pessoa, genero, estadoCivil }).FirstOrDefault(a => a.aluno.AlunoNumeroMatricula.Equals(nMatricula));

        var alunoC = new Aluno
        {
            //Id = alun.aluno.Id,
            //AlunoNMatricula = alun.aluno.AlunoNMatricula,
            //AlunoNumeroMatricula = alun.aluno.AlunoNumeroMatricula,
            //Pessoa = new Pessoa
            //{
            //    PessoaNomeCompleto = alun.pessoa.PessoaNomeCompleto,
            //    PessoaDataNascimento = alun.pessoa.PessoaDataNascimento,
            //    PessoaContribuinte = alun.pessoa.PessoaContribuinte,
            //    PessoaEstado = alun.pessoa.PessoaEstado,
            //    PessoaDataCadastro = alun.pessoa.PessoaDataCadastro,
            //},
            //PessoaGenero = new Genero
            //{
            //    GeneroId = alun.genero.GeneroId,
            //    GeneroDesignacao = alun.genero.GeneroDesignacao,
            //},
            //FuncionarioEstadoCivil = new EstadoCivil
            //{
            //    EstadoCivilId = alun.estadoCivil.EstadoCivilId,
            //    EstadoCivilDesignacao = alun.estadoCivil.EstadoCivilDesignacao
            //}
        };
        return alunoC;
    }
}