using ALAYSchoolManager.Domain.Entidades;
using ALAYSchoolManager.Domain.Interfaces.Repository.Shared;
using ALAYSchoolManager.Infra.Data.Context;

namespace ALAYSchoolManager.Infra.Data.Repository.Shared
{
    public class AlunoEmolumentosRepository : BaseSharedRepository<AlunoEmolumentos>, IAlunoEmolumentosRepository
    {
        public AlunoEmolumentosRepository(AlaySchoolGetDbContext context) : base(context)
        {
        }

        public void Adicionar(AlunoEmolumentos alunoEmolumentos)
        {
            _db.AlunoEmomentos.Add(alunoEmolumentos);
        }

        public void Remover(AlunoEmolumentos alunoEmolumentos)
        {
            _db.AlunoEmomentos.Remove(alunoEmolumentos);
        }

        public List<AlunoEmolumentos> ListarAlunoEmolmentos(long alunoNMatricula)
        {
            //var emolumentos = _db.AlunoEmomentos.AsNoTracking().Where(p => p.NMatricula.Equals(alunoNMatricula));
            List<AlunoEmolumentos> emolumentosList = new List<AlunoEmolumentos>();
            //foreach (AlunoEmolumentos emolumento in emolumentos)
            //{
            //    var emol = new AlunoEmolumentos
            //    {

            //    };
            //}
            return emolumentosList;
        }

        public override IEnumerable<AlunoEmolumentos> ObterTodos()
        {
            return base.ObterTodos();
        }
    }
}
