using ALAYSchoolManagment.Domain.Entidades.Shared;

namespace ALAYSchoolManagment.Domain.Entidades;

public class Aluno : Pessoa
{
    #region Propriedades

    public string? AlunoNMatricula { get; set; }

    //public string AlunoUsuarioCadastrador { get; set; }
    ////public Usuario Usuario { get; set; }


    #endregion
    #region Validações
    #region Nome Completo
    protected void NomeDeveSerPreenchido()
    {
        if (string.IsNullOrEmpty(PessoaNomeCompleto)) ListaErros.Add("O nome completo do aluno deve ser Preenchido!");
    }
    protected void NomeDeveTerTamanhoMinimo(int tamanho)
    {
        if (PessoaNomeCompleto.Trim().Length < tamanho) ListaErros.Add($"O campo nome completo deve ter no minimo {tamanho} caracteres!");

    }
    protected void NomeCompletoDeveTerTamanhoMaximo(int tamanho)
    {
        if (PessoaNomeCompleto.Trim().Length < tamanho) ListaErros.Add($"O campo nome completo deve ter no máximo {tamanho} caracteres!");
    }
    #endregion
    #region Contribuinte
    protected void ContribuinteDeveSerPreenchido()
    {
        if (string.IsNullOrEmpty(PessoaContribuinte)) ListaErros.Add("O nome completo do aluno deve ser Preenchido!");
    }
    protected void ContribuinteDeveTerTamanhoMinimo(int tamanho)
    {
        if (PessoaContribuinte.Trim().Length < tamanho) ListaErros.Add($"O campo nome completo deve ter no minimo {tamanho} caracteres!");

    }
    protected void ContribuinteDeveTerTamanhoMaximo(int tamanho)
    {
        if (PessoaContribuinte.Trim().Length < tamanho) ListaErros.Add($"O campo nome completo deve ter no máximo {tamanho} caracteres!");
    }
    #endregion
    #region Data de Nascimento  

    #endregion
    protected void GeneroDeveSerPreenchido()
    {
        if (string.IsNullOrEmpty(PessoaGenero.GeneroDesignacao)) ListaErros.Add("O genero  do aluno deve ser Preenchido!");
    }
    protected void EstadoCivilDeveSerPreenchido()
    {
        if (string.IsNullOrEmpty(PessoaEstadoCivil.EstadoCivilDesignacao)) ListaErros.Add("O genero  do aluno deve ser Preenchido!");
    }
    #region Data de Cadastro  

    #endregion
    #region Numero de Matricula
    protected void NumeroMatriculaDeveSerPreenchido()
    {
        if (string.IsNullOrEmpty(AlunoNMatricula)) ListaErros.Add("O numero de Matricula do aluno deve ser Atribuido!");
    }
    protected void NumeroMatriculaDeveTerTamanhoMinimo(int tamanho)
    {
        if (PessoaNomeCompleto.Trim().Length < tamanho) ListaErros.Add($"O campo numero de Matricula deve ter no minimo {tamanho} caracteres!");

    }
    protected void NumeroMatriculaDeveTerTamanhoMaximo(int tamanho)
    {
        if (PessoaNomeCompleto.Trim().Length < tamanho) ListaErros.Add($"O campo numero de Matricula deve ter no máximo {tamanho} caracteres!");
    }
    #endregion



    #endregion
}