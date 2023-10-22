using ALAYSchoolManagment.Domain.Entidades.Shared;

namespace ALAYSchoolManagment.Domain.Entidades
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
