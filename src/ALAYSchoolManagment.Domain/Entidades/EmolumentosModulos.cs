using ALAYSchoolManager.Domain.Entidades.Shared;

namespace ALAYSchoolManager.Domain.Entidades;

public class EmolumentosModulos : EntidadeBase
{

    public EmolumentosModulos()
    {
        EmolumentoModuloModuloId = new Modulos();
        EmolumentoModuloEmolumentoId = new Emolumentos();
        EmolumentoModuloFactorId = new EmolumentosFatores();
    }
    public Modulos EmolumentoModuloModuloId { get; set; }

    public Emolumentos EmolumentoModuloEmolumentoId { get; set; }

    public EmolumentosFatores EmolumentoModuloFactorId { get; set; }

    public decimal EmolumentoModuloPreco { get; set; }
    public string UsuarioCadastrador { get; set; }

    public bool EmolumentoModuloEstado { get; set; }
    public override bool EstaConsistente()
    {
        throw new NotImplementedException();
    }
}