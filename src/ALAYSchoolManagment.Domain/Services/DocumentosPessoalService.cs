using ALAYSchoolManager.Domain.Entidades;
using ALAYSchoolManager.Domain.Interfaces.Repository;
using ALAYSchoolManager.Domain.Interfaces.Services;

namespace ALAYSchoolManager.Domain.Services;

public class DocumentosPessoalService : IDocumentoPessoaService
{
    #region Variaveis

    private readonly IDocumentosPessoaisRepository _documentoPessoaRepository;
    #endregion
    #region Construtores
    public DocumentosPessoalService(IDocumentosPessoaisRepository documentoPessoaRepository)
    {
        _documentoPessoaRepository = documentoPessoaRepository;
    }
    #endregion
    #region Metodos
    public DocumentosPessoais Adicionar(DocumentosPessoais obj)
    {
        _documentoPessoaRepository.Adicionar(obj);
        return obj;
    }

    public DocumentosPessoais Actualizar(DocumentosPessoais obj)
    {
        throw new NotImplementedException();
    }

    public DocumentosPessoais Remover(DocumentosPessoais obj)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<DocumentosPessoais> ObterTodos()
    {
        return _documentoPessoaRepository.ObterTodos();
    }

    public DocumentosPessoais? ObterPorId(int id)
    {
        throw new NotImplementedException();
    }
    public void Dispose()
    {
        _documentoPessoaRepository.Dispose();
        GC.SuppressFinalize(this);
    }
    #endregion




}