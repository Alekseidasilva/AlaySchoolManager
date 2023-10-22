using ALAYSchoolManagment.Domain.Entidades.Shared;
using ALAYSchoolManagment.Domain.Interfaces.Repository.Shared;
using ALAYSchoolManagment.Domain.Interfaces.Services.Shared;

namespace ALAYSchoolManagment.Domain.Services.Shared;

public class ModuloService : IModulosService
{
    #region Variaveis
    private readonly IModuloRepository _moduloRepository;
    #endregion
    #region Construtores
    public ModuloService(IModuloRepository moduloRepository)
    {
        _moduloRepository = moduloRepository;
    }
    #endregion
    #region Metodos
    public Modulos? ObterPorId(int id)
    {
        return _moduloRepository.ObterPorId(id);
    }

    public IEnumerable<Modulos> ObterTodos()
    {
        return _moduloRepository.ObterTodos();
    }

    public void Dispose()
    {
        _moduloRepository.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion


}