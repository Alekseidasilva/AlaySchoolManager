using System.ComponentModel.DataAnnotations;
using ALAYSchoolManager.Application.ViewModels.Shared;

namespace ALAYSchoolManager.Application.ViewModels;

public class EmolumentosModulosViewModel
{
    public EmolumentosModulosViewModel()
    {
        EmolumentoModuloModuloId = new ModulosViewModel();
        Emolumentos = new EmolumentosViewModel();
        EmolumentoModuloFactorId = new EmolumentosFatoresViewModel();
    }
    public ModulosViewModel EmolumentoModuloModuloId { get; set; }



    #region Emolumentos
    public EmolumentosViewModel Emolumentos { get; set; }


    [Required(ErrorMessage = "Deve Selecionais pelo menos 1 emolumento Obrigatorio")]
    public IEnumerable<EmolumentosViewModel> EmolumentosObrigatorios { get; set; }

    public IEnumerable<EmolumentosViewModel> EmolumentosOOpcionais { get; set; }
    #endregion


    public EmolumentosFatoresViewModel EmolumentoModuloFactorId { get; set; }

    public decimal EmolumentoModuloPreco { get; set; }

    public string UsuarioCadastrador { get; set; }
    public bool EmolumentoModuloEstado { get; set; }

}

