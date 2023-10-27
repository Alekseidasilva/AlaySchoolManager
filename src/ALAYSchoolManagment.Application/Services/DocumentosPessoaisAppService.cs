using System.Linq.Expressions;
using ALAYSchoolManager.Application.Interfaces;
using ALAYSchoolManager.Application.ViewModels;
using ALAYSchoolManager.Domain.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ALAYSchoolManager.Application.Services;

public class DocumentosPessoaisAppService : IDocumentosPessoaisApp
{
    #region Variaveis
    private readonly IDocumentosPessoaisRepository _documentosPessoaisRepository;
    #endregion
    #region Construtores
    public DocumentosPessoaisAppService(IDocumentosPessoaisRepository documentosPessoaisRepository)
    {
        _documentosPessoaisRepository = documentosPessoaisRepository;
    }
    #endregion
    #region Metodos
    public DocumentosPessoaisViewModel Adicionar(DocumentosPessoaisViewModel obj)
    {
        throw new NotImplementedException();
    }

    public DocumentosPessoaisViewModel Actualizar(DocumentosPessoaisViewModel obj)
    {
        throw new NotImplementedException();
    }

    public DocumentosPessoaisViewModel Remover(DocumentosPessoaisViewModel obj)
    {
        throw new NotImplementedException();
    }

    public DocumentosPessoaisViewModel? ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<DocumentosPessoaisViewModel> ObterTodos()
    {
        throw new NotImplementedException();
    }


    public IEnumerable<DocumentosPessoaisViewModel> Buscar(Expression<Func<DocumentosPessoaisViewModel, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public SelectList ObterLista()
    {
        var doc = ObterTodos();
        var selectDoc = new SelectList(doc, "Id", "DocumentoDesignacao");
        return selectDoc;
    }

    public void Dispose()
    {
        _documentosPessoaisRepository.Dispose();
        GC.SuppressFinalize(this);
    }


    #endregion
}