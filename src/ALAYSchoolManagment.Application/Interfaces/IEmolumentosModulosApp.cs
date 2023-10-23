using ALAYSchoolManager.Application.ViewModels;

namespace ALAYSchoolManager.Application.Interfaces;

public interface IEmolumentosModulosApp : IBaseApp<EmolumentosModulosViewModel>
{
    List<EmolumentosModulosViewModel> ListarObrigatoriosActivos(short moduloId);
    List<EmolumentosModulosViewModel> ListarOpcionaisActivos(short moduloId);
    List<EmolumentosModulosViewModel> ListarActivos();
    decimal ObterPrecoEmolumento(short emolumentoId);
}