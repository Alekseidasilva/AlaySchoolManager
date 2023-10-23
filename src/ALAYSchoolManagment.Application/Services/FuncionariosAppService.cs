using System.Linq.Expressions;
using ALAYSchoolManager.Application.Interfaces;
using ALAYSchoolManager.Application.ViewModels;
using ALAYSchoolManagment.Domain.Entidades;
using ALAYSchoolManagment.Domain.Interfaces.Services;
using ALAYSchoolManagment.Infra.Data.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ALAYSchoolManager.Application.Services;

public class FuncionariosAppService : IFuncionariosApp
{
    #region Variaveis

    private readonly IFuncionariosService _funcionarioService;
    private readonly IUnitOfWork _unitOfWork;
    #endregion
    #region Construtores

    public FuncionariosAppService(IFuncionariosService funcionarioService, IUnitOfWork unitOfWork)
    {
        _funcionarioService = funcionarioService;
        _unitOfWork = unitOfWork;
    }
    #endregion
    #region Metodos
    public FuncionariosViewModel Adicionar(FuncionariosViewModel obj)
    {
        var func = new Funcionarios
        {
            //Id = obj.Id,
            //PessoaNomeCompleto = obj.FuncionarioNomeCompleto,
            //ListaErros = obj.ListaErros,
            //PessoaContribuinte = obj.FuncionarioContribuinte,
            //PessoaDataNascimento = obj.FuncionarioDataNascimento,
            ////PessoaGeneroId = Convert.ToInt16(obj.PessoaGenero),
            ////FuncionarioEstadoCivilId = Convert.ToInt16(obj.FuncionarioEstadoCivil),
            //FuncionarioNomeDoPai = obj.FuncionarioNomeDoPai,
            //FuncionarioNomeDaMae = obj.FuncionarioNomeDaMae,
            ////FuncionarioDepartamentosId = short.Parse(obj.FuncionarioDepartamento),
            //FuncionarioSalarioLiquido = Convert.ToDouble(obj.FuncionarioSalarioLiquido),
            //FuncionarioObservacoes = obj.FuncionarioObservacoes,
            //PessoaEstado = obj.FuncionarioEstado,
            //PessoaDataCadastro = DateTime.Now

        };
        var funcionarioresult = _funcionarioService.Adicionar(func);
        _unitOfWork.Commit(funcionarioresult.ListaErros);
        return obj;
    }

    public FuncionariosViewModel Actualizar(FuncionariosViewModel obj)
    {

        var funcionario = new Funcionarios
        {
            //Id = obj.Id,
            //PessoaNomeCompleto = obj.FuncionarioNomeCompleto,
            //PessoaContribuinte = obj.FuncionarioContribuinte,
            //PessoaDataNascimento = obj.FuncionarioDataNascimento,
            ////PessoaGeneroId = Convert.ToInt16(obj.PessoaGenero),
            //PessoaGenero = new GenerosVo
            //{
            //    GeneroId = Convert.ToInt16(obj.PessoaGenero),

            //},
            ////FuncionarioEstadoCivilId = Convert.ToInt16(obj.FuncionarioEstadoCivil),
            //PessoaEstadoCivil = new EstadoCivilVo
            //{
            //    EstadoCivilId = Convert.ToInt16(obj.FuncionarioEstadoCivil)
            //},
            //FuncionarioNomeDoPai = obj.FuncionarioNomeDoPai,
            //FuncionarioNomeDaMae = obj.FuncionarioNomeDaMae,
            ////FuncionarioDepartamentosId = Convert.ToInt16(obj.Id),
            ////FuncionarioDepartamentos = new Departamentos
            ////{
            ////    Id = obj.Id
            ////},
            ////FuncionarioSalarioLiquido = obj.FuncionarioSalarioLiquido,
            //FuncionarioObservacoes = obj.FuncionarioObservacoes,
            //PessoaEstado = obj.FuncionarioEstado,
            //ListaErros = new List<string>()

        };
        _funcionarioService.Actualizar(funcionario);
        _unitOfWork.Commit(funcionario.ListaErros);
        return obj;

    }

    public FuncionariosViewModel Remover(FuncionariosViewModel obj)
    {
        throw new NotImplementedException();
    }

    public FuncionariosViewModel? ObterPorId(int id)
    {
        var fun = _funcionarioService.ObterPorId(id);
        var funVm = new FuncionariosViewModel
        {
            //Id = fun.Id,
            //FuncionarioNomeCompleto = fun.PessoaNomeCompleto,
            //FuncionarioContribuinte = fun.PessoaContribuinte,
            //FuncionarioDataNascimento = fun.PessoaDataNascimento,
            //PessoaGenero = fun.PessoaGenero.GeneroDesignacao,
            //FuncionarioEstadoCivil = fun.PessoaEstadoCivil.EstadoCivilDesignacao,
            //FuncionarioNomeDoPai = fun.FuncionarioNomeDoPai,
            //FuncionarioNomeDaMae = fun.FuncionarioNomeDaMae,
            ////FuncionarioDepartamento = fun.FuncionarioDepartamentos.DepartamentoDesignacao,
            //FuncionarioSalarioLiquido = fun.FuncionarioSalarioLiquido,
            //FuncionarioObservacoes = fun.FuncionarioObservacoes,
            //FuncionarioEstado = fun.PessoaEstado

        };
        return funVm;
    }

    public IEnumerable<FuncionariosViewModel> ObterTodos()
    {
        List<FuncionariosViewModel> funcionariosViewModels = new List<FuncionariosViewModel>();
        foreach (var func in _funcionarioService.ObterTodos())
        {
            var funcVM = new FuncionariosViewModel
            {
                //Id = func.Id,
                //FuncionarioNomeCompleto = func.PessoaNomeCompleto,
                //FuncionarioContribuinte = func.PessoaContribuinte,
                //FuncionarioDataNascimento = func.PessoaDataNascimento,
                //PessoaGenero = func.PessoaGenero.GeneroDesignacao,
                //FuncionarioEstadoCivil = func.PessoaEstadoCivil.EstadoCivilDesignacao,
                //FuncionarioNomeDoPai = func.FuncionarioNomeDoPai,
                //FuncionarioNomeDaMae = func.FuncionarioNomeDaMae,
                ////FuncionarioDepartamento = func.FuncionarioDepartamentos.DepartamentoDesignacao,
                //FuncionarioSalarioLiquido = func.FuncionarioSalarioLiquido,
                //FuncionarioObservacoes = func.FuncionarioObservacoes,
                //FuncionarioEstado = func.PessoaEstado,
                //FuncionarioDataCadastro = func.PessoaDataCadastro

            };
            funcionariosViewModels.Add(funcVM);
        }
        return funcionariosViewModels;
    }

    public IEnumerable<FuncionariosViewModel> Buscar(Expression<Func<FuncionariosViewModel, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public SelectList ObterLista()
    {
        var funcionario = new SelectList(ObterTodos(), "Id", "PessoaNomeCompleto");
        return funcionario;
    }

    public void Dispose()
    {

        _funcionarioService.Dispose();
        GC.SuppressFinalize(this);
    }


    #endregion

}