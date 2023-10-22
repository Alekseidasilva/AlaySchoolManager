using ALAYSchoolManagment.Application.Interfaces;
using ALAYSchoolManagment.Application.ViewModels;
using ALAYSchoolManagment.Domain.Interfaces.Services;
using AutoMapper;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ALAYSchoolManagment.Application.Services;

public class MatriculaConfirmarAppService : IMatriculaConfirmacaoApp
{
    #region Variaveis
    private readonly IMatriculaConfirmarService _matriculaConfirmarService;
    private readonly IMapper _mapper;
    #endregion
    #region Construtores
    public MatriculaConfirmarAppService(IMapper mapper, IMatriculaConfirmarService matriculaConfirmarService)
    {
        _mapper = mapper;
        _matriculaConfirmarService = matriculaConfirmarService;
    }
    #endregion
    #region Metodos
    public MatriculaConfirmarViewModel Adicionar(MatriculaConfirmarViewModel obj)
    {
        throw new NotImplementedException();
    }

    public MatriculaConfirmarViewModel Actualizar(MatriculaConfirmarViewModel obj)
    {
        throw new NotImplementedException();
    }

    public MatriculaConfirmarViewModel Remover(MatriculaConfirmarViewModel obj)
    {
        throw new NotImplementedException();
    }

    public MatriculaConfirmarViewModel? ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<MatriculaConfirmarViewModel> ObterTodos()
    {
        return _mapper.Map<IEnumerable<MatriculaConfirmarViewModel>>(_matriculaConfirmarService.ObterTodos());
    }

    public IEnumerable<MatriculaConfirmarViewModel> Buscar(Expression<Func<MatriculaConfirmarViewModel, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public SelectList ObterLista()
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        _matriculaConfirmarService.Dispose();
        GC.SuppressFinalize(this);
    }


    #endregion

}