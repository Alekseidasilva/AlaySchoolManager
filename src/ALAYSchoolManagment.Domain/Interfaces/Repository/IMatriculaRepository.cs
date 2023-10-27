using ALAYSchoolManager.Domain.Entidades;
using ALAYSchoolManager.Domain.Interfaces.Repository.Shared;

namespace ALAYSchoolManager.Domain.Interfaces.Repository;

public interface IMatriculaRepository : IBaseSharedRepository<Matriculas>
{
    string EfectuarMatricula(Matriculas matricula);
}