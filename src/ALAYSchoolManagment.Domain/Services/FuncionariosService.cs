using ALAYSchoolManagment.Domain.Entidades;
using ALAYSchoolManagment.Domain.Interfaces.Repository;
using ALAYSchoolManagment.Domain.Interfaces.Services;

namespace ALAYSchoolManagment.Domain.Services;

public class FuncionariosService : IFuncionariosService
{
    #region Variaveis

    private int _idadeRecomendada = 18;
    private readonly IFuncionarioRepository _repositoryFuncionario;

    #endregion
    #region Construtores
    public FuncionariosService(IFuncionarioRepository repositoryFuncionario)
    {
        _repositoryFuncionario = repositoryFuncionario;
    }
    #endregion
    #region Metodos
    #region Adicionar
    public Funcionarios Adicionar(Funcionarios funcionarios)
    {
        //funcionarios = AptoParaAdicionarFuncionarios(funcionarios);
        ////if (funcionarios.ListaErros.Any())
        //return funcionarios;


        _repositoryFuncionario.Adicionar(funcionarios);
        return funcionarios;
    }

    #region Regras de Negocio do Adicionar

    private Funcionarios AptoParaAdicionarFuncionarios(Funcionarios funcionarios)
    {
        if (!funcionarios.EstaConsistente()) return funcionarios;
        funcionarios = VerificarSeMaiorIdade(funcionarios);
        return funcionarios;
    }
    private Funcionarios VerificarSeMaiorIdade(Funcionarios funcionarios)
    {
        var dataactual = DateTime.Now.Year;
        var idade = dataactual - funcionarios.PessoaDataNascimento.Year;
        //if (idade < _idadeRecomendada) funcionarios.ListaErros.Add($"A data introduzida é inferior a {_idadeRecomendada} anos, idade  recomendada");
        return funcionarios;

    }


    #endregion
    #endregion
    #region Actualizar
    public Funcionarios Actualizar(Funcionarios funcionarios)
    {
        _repositoryFuncionario.Actualizar(funcionarios);
        return funcionarios;
    }
    #endregion
    #region Remover
    public Funcionarios Remover(Funcionarios funcionarios)
    {
        _repositoryFuncionario.Remover(funcionarios);
        return funcionarios;
    }
    #endregion
    #region Consultas
    public Funcionarios? ObterPorId(int id)
    {
        return _repositoryFuncionario.ObterPorId(id);
    }

    public IEnumerable<Funcionarios> ObterTodos()
    {
        return _repositoryFuncionario.ObterTodos();
    }
    #endregion
    #region Dispose
    public void Dispose()
    {
        _repositoryFuncionario.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion
    #endregion
}