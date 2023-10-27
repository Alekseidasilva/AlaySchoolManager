using ALAYSchoolManager.Domain.Entidades;
using ALAYSchoolManager.Domain.Interfaces.Repository;
using ALAYSchoolManager.Domain.Interfaces.Services;

namespace ALAYSchoolManager.Domain.Services
{
    public class EmolumentosService : IEmolumentosService
    {
        #region Variaveis
        private readonly IEmolumentoRepository _emolumentoRepository;
        #endregion
        #region Construtores
        public EmolumentosService(IEmolumentoRepository emolumentoRepository)
        {
            _emolumentoRepository = emolumentoRepository;
        }
        #endregion
        #region Metodos
        public Emolumentos Adicionar(Emolumentos obj)
        {
            throw new NotImplementedException();
        }

        public Emolumentos Actualizar(Emolumentos obj)
        {
            throw new NotImplementedException();
        }

        public Emolumentos Remover(Emolumentos obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Emolumentos> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public Emolumentos? ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Emolumentos> ObterEmolumentosObrigatorios(int moduloId, int factorId)
        {
            return _emolumentoRepository.ObterEmolumentosObrigatorios(moduloId, factorId);
        }

        public IEnumerable<Emolumentos> ObterEmolumentosOpcionais(int moduloId, int factorId)
        {
            return _emolumentoRepository.ObterEmolumentosOpcionais(moduloId, factorId);
        }
        public void Dispose()
        {
            _emolumentoRepository.Dispose();
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
