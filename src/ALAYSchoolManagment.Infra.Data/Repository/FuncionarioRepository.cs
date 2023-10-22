using ALAYSchoolManagment.Domain.Entidades;
using ALAYSchoolManagment.Domain.Interfaces.Repository;
using ALAYSchoolManagment.Infra.Data.Context;

namespace ALAYSchoolManagment.Infra.Data.Repository;

public class FuncionarioRepository : BaseRepository<Funcionarios>, IFuncionarioRepository
{
    //Injectando Dependencia
    public FuncionarioRepository(AlaySchoolGetDbContext context) : base(context)
    {
    }

    public override IEnumerable<Funcionarios> ObterTodos()
    {
        //var funcionarios = (from f in _db.Funcionarios
        //                    join p in _db.Pessoas on f.Id equals p.Id
        //                    join d in _db.Departamentos on f.FuncionarioDepartamentosId equals d.Id
        //                    join g in _db.Generos on p.PessoaGeneroId equals g.GeneroId
        //                    join ec in _db.EstadoCivil on p.FuncionarioEstadoCivilId equals ec.EstadoCivilId
        //                    select new { f, p, d, g, ec });
        List<Funcionarios> funcionariosList = new List<Funcionarios>();
        //foreach (var func in funcionarios)
        //{
        //    var Funcionario = new Funcionarios
        //    {
        //        Id = func.f.Id,
        //        PessoaNomeCompleto = func.p.PessoaNomeCompleto,
        //        PessoaContribuinte = func.p.PessoaContribuinte,
        //        PessoaDataNascimento = func.p.PessoaDataNascimento,
        //        PessoaGeneroId = func.p.PessoaGeneroId,
        //        PessoaGenero = new Genero
        //        {
        //            GeneroId = func.g.GeneroId,
        //            GeneroDesignacao = func.g.GeneroDesignacao

        //        },
        //        FuncionarioEstadoCivilId = func.p.FuncionarioEstadoCivilId,
        //        FuncionarioEstadoCivil = new EstadoCivil
        //        {
        //            EstadoCivilId = func.ec.EstadoCivilId,
        //            EstadoCivilDesignacao = func.ec.EstadoCivilDesignacao
        //        },
        //        PessoaDataCadastro = func.p.PessoaDataCadastro,
        //        PessoaEstado = func.p.PessoaEstado,
        //        FuncionarioNomeDoPai = func.f.FuncionarioNomeDoPai,
        //        FuncionarioNomeDaMae = func.f.FuncionarioNomeDaMae,
        //        FuncionarioDepartamentosId = func.f.FuncionarioDepartamentosId,
        //        FuncionarioDepartamentos = new Departamentos
        //        {
        //            Id = func.d.Id,
        //            DepartamentoDesignacao = func.d.DepartamentoDesignacao
        //        },
        //        FuncionarioSalarioLiquido = func.f.FuncionarioSalarioLiquido,
        //        FuncionarioObservacoes = func.f.FuncionarioObservacoes
        //    };
        //    funcionariosList.Add(Funcionario);

        //}
        return funcionariosList;
    }

    public override Funcionarios? ObterPorId(int id)
    {
        //var func = (from f in _db.Funcionarios
        //            join p in _db.Pessoas on f.Id equals p.Id
        //            join d in _db.Departamentos on f.FuncionarioDepartamentosId equals d.Id
        //            join g in _db.Generos on p.PessoaGeneroId equals g.GeneroId
        //            join ec in _db.EstadoCivil on p.FuncionarioEstadoCivilId equals ec.EstadoCivilId
        //            where p.Id == id
        //            select new { f, p, d, g, ec }).FirstOrDefault();

        var funcionarioSelecionado = new Funcionarios
        {
            //Id = func.f.Id,
            //PessoaNomeCompleto = func.p.PessoaNomeCompleto,
            //PessoaContribuinte = func.p.PessoaContribuinte,
            //PessoaDataNascimento = func.p.PessoaDataNascimento,
            //PessoaGeneroId = func.p.PessoaGeneroId,
            //PessoaGenero = new Genero
            //{
            //    GeneroId = func.g.GeneroId,
            //    GeneroDesignacao = func.g.GeneroDesignacao

            //},
            //FuncionarioEstadoCivilId = func.p.FuncionarioEstadoCivilId,
            //FuncionarioEstadoCivil = new EstadoCivil
            //{
            //    EstadoCivilId = func.ec.EstadoCivilId,
            //    EstadoCivilDesignacao = func.ec.EstadoCivilDesignacao
            //},
            //PessoaDataCadastro = func.p.PessoaDataCadastro,
            //PessoaEstado = func.p.PessoaEstado,
            //FuncionarioNomeDoPai = func.f.FuncionarioNomeDoPai,
            //FuncionarioNomeDaMae = func.f.FuncionarioNomeDaMae,
            //FuncionarioDepartamentosId = func.f.FuncionarioDepartamentosId,
            //FuncionarioDepartamentos = new Departamentos
            //{
            //    Id = func.d.Id,
            //    DepartamentoDesignacao = func.d.DepartamentoDesignacao
            //},
            //FuncionarioSalarioLiquido = func.f.FuncionarioSalarioLiquido,
            //FuncionarioObservacoes = func.f.FuncionarioObservacoes
        };
        return funcionarioSelecionado;
    }
}