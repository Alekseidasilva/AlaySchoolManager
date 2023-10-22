using ALAYSchoolManagment.Domain.Entidades;
using ALAYSchoolManagment.Domain.Interfaces.Repository;
using ALAYSchoolManagment.Domain.Interfaces.Services;

namespace ALAYSchoolManagment.Domain.Services;

public class MatriculaService : IMatriculaService
{
    #region Variaveis

    private readonly IMatriculaRepository _matriculaRepository;
    #endregion
    #region Constructores
    public MatriculaService(IMatriculaRepository matriculaRepository)
    {
        _matriculaRepository = matriculaRepository;
    }
    #endregion
    #region Metodos
    public string EfectuarMatricula(Matriculas matricula)
    {
        return _matriculaRepository.EfectuarMatricula(matricula);
    }

    public Matriculas ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Matriculas> ObterTodos()
    {
        return this._matriculaRepository.ObterTodos();
    }





    public void Dispose()
    {
        _matriculaRepository.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion

}