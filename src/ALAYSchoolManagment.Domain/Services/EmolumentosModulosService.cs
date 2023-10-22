using ALAYSchoolManagment.Domain.Entidades;
using ALAYSchoolManagment.Domain.Interfaces.Repository;
using ALAYSchoolManagment.Domain.Interfaces.Services;

namespace ALAYSchoolManagment.Domain.Services;

public class EmolumentosModulosService : IEmolumentosModulosServices
{
    #region Variaveis
    private readonly IEmolumentosModulosRepository _emolumentosModulosRepository;
    #endregion
    #region Contrutores
    public EmolumentosModulosService(IEmolumentosModulosRepository emolumentosModulosRepository)
    {
        _emolumentosModulosRepository = emolumentosModulosRepository;
    }
    #endregion
    #region Metodos
    public EmolumentosModulos Adicionar(EmolumentosModulos obj)
    {
        throw new NotImplementedException();
    }

    public EmolumentosModulos Actualizar(EmolumentosModulos obj)
    {
        throw new NotImplementedException();
    }

    public EmolumentosModulos Remover(EmolumentosModulos obj)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<EmolumentosModulos> ObterTodos()
    {
        return _emolumentosModulosRepository.ObterTodos();
    }

    public EmolumentosModulos? ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        _emolumentosModulosRepository.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion
}