using ALAYSchoolManager.Application.ViewModels;
using ALAYSchoolManagment.Application.Interfaces;
using ALAYSchoolManagment.Application.Interfaces.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ALAYSchoolManager.Presentation.IU.Areas.Administracao.Controllers;

[Area("Administracao")]
public class MatriculaController : Controller
{
    #region Variaveis
    private readonly IMatriculasApp _matriculaApp;
    private readonly IModulosApp _moduloApp;
    private readonly IPagamentosApp _pagamentosApp;
    private readonly IAlunosApp _alunoApp;
    private readonly IEstadoCivilApp _estadoCivilApp;
    private readonly IGenerosApp _generosApp;
    private readonly IEmolumentosApp _emolumentosApp;
    private readonly IEmolumentosModulosApp _emolumentosModulosApp;
    private readonly IFormasPagamentoApp _formasPagamentoApp;
    #endregion
    #region Construtores
    public MatriculaController(IMatriculasApp matriculaApp, IModulosApp moduloApp, IPagamentosApp pagamentosApp, IAlunosApp alunoApp, IEstadoCivilApp estadoCivilApp, IGenerosApp generosApp, IEmolumentosApp emolumentosApp, IEmolumentosModulosApp emolumentosModulosApp, IFormasPagamentoApp formasPagamentoApp)
    {
        _matriculaApp = matriculaApp;
        _moduloApp = moduloApp;
        _pagamentosApp = pagamentosApp;
        _alunoApp = alunoApp;
        _estadoCivilApp = estadoCivilApp;
        _generosApp = generosApp;
        _emolumentosApp = emolumentosApp;
        _emolumentosModulosApp = emolumentosModulosApp;
        _formasPagamentoApp = formasPagamentoApp;
    }

    #endregion
    #region Metodos
    // GET
    [HttpGet]
    public IActionResult Matriculados()
    {
        var matriculados = _matriculaApp.ObterTodos();
        return View(matriculados);
    }
    //[HttpGet]
    //public IActionResult Matricular()
    //{
    //    ViewBag.EmolObrigatorios = _emolumentosModulosApp.ListarObrigatoriosActivos(2);
    //    ViewBag.EmolOpcionais = _emolumentosModulosApp.ListarOpcionaisActivos(2);

    //    ViewBag.Generos = _generosApp.ObterLista();
    //    ViewBag.estadoCivil = _estadoCivilApp.ObterLista();
    //    ViewBag.modulos = _moduloApp.ObterTodos();
    //    ViewBag.formasPagamentos = _formasPagamentoApp.ObterTodos();
    //    return View();
    //}
    [HttpGet]
    public IActionResult Matricular()
    {
        MatriculasViewModel mat = new MatriculasViewModel
        {
            MatriculaModulos = _moduloApp.ObterTodos(),
            MatriculaAluno = new AlunosViewModel
            {
                Generos = _generosApp.ObterTodos(),
                EstadoCivil = _estadoCivilApp.ObterTodos()
            }
        };
        ViewBag.modulos = _moduloApp.ObterTodos();

        return View(mat);
    }
    [HttpPost]
    public IActionResult Matricular(MatriculasViewModel matricula)
    {
        return View("Matriculados");
    }
    [HttpGet]
    [Route("/Administracao/Matricula/Detalhes/{alunoNMatricula}")]
    public IActionResult Detalhes(string alunoNMatricula)
    {
        return View();
    }
    [HttpGet]
    [Route("/Administracao/Matricula/Ver/{alunoNMatricula}")]
    public IActionResult Ver(string alunoNMatricula)
    {
        return View();
    }
    [HttpGet]
    [Route("/Administracao/Matricula/Reimprimir/{alunoNMatricula}")]
    public IActionResult Reimprimir(string alunoNMatricula)
    {
        return View();
    }
    [HttpGet]
    [Route("/Administracao/Matricula/Cancelar/{alunoNMatricula}")]
    public IActionResult Anular(string alunoNMatricula)
    {
        return View();
    }

    #region Json
    [HttpGet]
    public JsonResult ListarEmolumentosObrigatoriosPorModuloId(short moduloId)
    {
        List<EmolumentosViewModel> selectList = new List<EmolumentosViewModel>();
        foreach (var item in _emolumentosModulosApp.ListarObrigatoriosActivos(moduloId))
        {
            selectList.Add(item.Emolumentos);
        }
        return Json(new SelectList(selectList, "EmolumentoId", "EmolumentoDesignacao"));
    }
    [HttpGet]
    public JsonResult ListarEmolumentosOpcionaisPorModuloId(short moduloId)
    {
        List<EmolumentosViewModel> selectList = new List<EmolumentosViewModel>();
        foreach (var item in _emolumentosModulosApp.ListarOpcionaisActivos(moduloId))
        {
            selectList.Add(item.Emolumentos);
            //ListarPrecoEmolumento(item.Emolumentos.EmolumentoId);
        }
        return Json(new SelectList(selectList, "EmolumentoId", "EmolumentoDesignacao"));
    }
    [HttpPost]
    public JsonResult ListarPrecoEmolumento(short[] selectedIds)
    {
        decimal resSoma = 0;
        for (short i = 0; i < selectedIds.Length; i++)
        {
            resSoma += _emolumentosModulosApp.ObterPrecoEmolumento(selectedIds[i]);
        }
        //var preco = _emolumentosModulosApp.ObterPrecoEmolumento(emolumentoId).ToString("F");

        return Json(resSoma.ToString("C"));
    }

    #endregion

    #endregion
}