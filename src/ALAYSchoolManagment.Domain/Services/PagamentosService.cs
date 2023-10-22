using ALAYSchoolManagment.Domain.Entidades;
using ALAYSchoolManagment.Domain.Interfaces.Repository;
using ALAYSchoolManagment.Domain.Interfaces.Services;

namespace ALAYSchoolManagment.Domain.Services
{
    public class PagamentosService : IPagamentosService
    {
        #region Variaveis

        private readonly IPagamentosRepository _pagamentosRepository;

        public PagamentosService(IPagamentosRepository pagamentosRepository)
        {
            _pagamentosRepository = pagamentosRepository;
        }

        #endregion

        #region Construtores



        #endregion

        #region Métodos

        public Pagamentos Adicionar(Pagamentos obj)
        {
            throw new NotImplementedException();
        }

        public Pagamentos Actualizar(Pagamentos obj)
        {
            throw new NotImplementedException();
        }

        public Pagamentos Remover(Pagamentos obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pagamentos> ObterTodos()
        {
            return _pagamentosRepository.ObterTodos();
        }

        public Pagamentos? ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void EfectuarPagamento(Pagamentos pagamentos)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            _pagamentosRepository.Dispose();
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
