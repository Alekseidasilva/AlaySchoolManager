using ALAYSchoolManagment.Domain.Entidades;
using ALAYSchoolManagment.Domain.Interfaces.Repository.Shared;

namespace ALAYSchoolManagment.Domain.Interfaces.Repository;

public interface IMatriculaRepository : IBaseSharedRepository<Matriculas>
{
    string EfectuarMatricula(Matriculas matricula);
}