using ALAYSchoolManager.Domain.Entidades;
using ALAYSchoolManager.Domain.Interfaces.Services.Shared;

namespace ALAYSchoolManager.Domain.Interfaces.Services;

public interface IMatriculaService : IBaseSharedService<Matriculas>
{
    string EfectuarMatricula(Matriculas matricula);
}