using ALAYSchoolManagment.Domain.Entidades;
using ALAYSchoolManagment.Domain.Interfaces.Repository;
using ALAYSchoolManagment.Infra.Data.Context;

namespace ALAYSchoolManagment.Infra.Data.Repository;

public class PagamentosRepository : BaseRepository<Pagamentos>, IPagamentosRepository
{
    public PagamentosRepository(AlaySchoolGetDbContext context) : base(context)
    {
    }
    public override IEnumerable<Pagamentos> ObterTodos()
    {
        //var pagamentos = (from pag in _db.Pagamentos
        //                  join aluno in _db.Aluno on pag.PagamentoAlunoId equals aluno.Id
        //                  join pessoa in _db.Pessoas on aluno.Id equals pessoa.Id
        //                  join emol in _db.Emolumentos on pag.PagamentoEmolumentoId equals emol.Id

        //                  //join user in _db.Users on pag.PagamentoUsuarioId equals  user.
        //                  select new { pag, aluno, pessoa, emol });


        List<Pagamentos> pagList = new List<Pagamentos>();
        //foreach (var pag in pagamentos)
        //{
        //    var pagN = new Pagamentos
        //    {
        //        Id = pag.pag.Id,
        //        PagamentoAlunoId = pag.aluno.Id,
        //        PagamentoAluno = new Aluno
        //        {
        //            Id = pag.aluno.Id,
        //            AlunoNMatricula = pag.aluno.AlunoNMatricula,
        //            AlunoNumeroMatricula = pag.aluno.AlunoNumeroMatricula,
        //            Pessoa = new Pessoa
        //            {
        //                PessoaNomeCompleto = pag.pessoa.PessoaNomeCompleto
        //            }
        //        },

        //        PagamentoEmolumentoId = pag.emol.Id,
        //        PagamentoEmolumento = new Emolumentos
        //        {
        //            Id = pag.emol.Id,
        //            EmolumentoDesignacao = pag.emol.EmolumentoDesignacao,
        //        },
        //        PagamentoData = pag.pag.PagamentoData,
        //        PagamentoValorTotal = pag.pag.PagamentoValorTotal,
        //        PagamentoUsuarioId = pag.pag.PagamentoUsuarioId
        //    };
        //    pagList.Add(pagN);
        //}
        return pagList;

    }
    public void EfectuarPagamento(Pagamentos pagamentos)
    {
        throw new NotImplementedException();
    }
}