using ALAYSchoolManager.Domain.Entidades.Shared;

namespace ALAYSchoolManager.Domain.Entidades
{
    public class Emolumentos : EntidadeBase
    {
        public string EmolumentoDesignacao { get; set; }

        public override bool EstaConsistente()
        {
            throw new NotImplementedException();
        }
    }
}
