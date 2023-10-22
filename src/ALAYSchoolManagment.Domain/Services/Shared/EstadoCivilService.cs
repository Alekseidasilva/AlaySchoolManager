using ALAYSchoolManagment.Domain.Entidades.Vo;
using ALAYSchoolManagment.Domain.Interfaces.Repository.Shared;
using ALAYSchoolManagment.Domain.Interfaces.Services.Shared;

namespace ALAYSchoolManagment.Domain.Services.Shared;

public class EstadoCivilService : IEstadoCivilService
{
    private readonly IEstadoCivilRepository _estadoCivilRepository;

    public EstadoCivilService(IEstadoCivilRepository estadoCivilRepository)
    {
        _estadoCivilRepository = estadoCivilRepository;
    }

    public EstadoCivilVo? ObterPorId(int id)
    {
        return _estadoCivilRepository.ObterPorId(id);
    }

    public IEnumerable<EstadoCivilVo> ObterTodos()
    {
        return _estadoCivilRepository.ObterTodos();
    }

    public void Dispose()
    {
        _estadoCivilRepository.Dispose();
        GC.SuppressFinalize(this);
    }
}