namespace ALAYSchoolManagment.Domain.Entidades
{
    public class AlunoEmolumentos
    {
        public AlunoEmolumentos()
        {
            AlunoNMatricula = new Aluno();
            EmolumentoId = new Emolumentos();
        }

        public Aluno AlunoNMatricula { get; set; }
        public Emolumentos EmolumentoId { get; set; }
    }
}
