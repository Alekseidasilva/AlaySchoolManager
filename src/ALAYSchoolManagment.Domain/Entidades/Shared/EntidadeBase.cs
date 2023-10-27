namespace ALAYSchoolManager.Domain.Entidades.Shared
{
    public abstract class EntidadeBase
    {

        public int Id { get; set; }

        public virtual List<string> ListaErros { get; set; }
        public abstract bool EstaConsistente();

    }
}
