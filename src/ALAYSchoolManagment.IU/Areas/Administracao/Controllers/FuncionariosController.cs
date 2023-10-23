using ALAYSchoolManager.Application.Interfaces;
using ALAYSchoolManager.Application.Interfaces.Shared;
using ALAYSchoolManager.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ALAYSchoolManager.Presentation.IU.Areas.Administracao.Controllers
{
    [Area("Administracao")]
    public class FuncionariosController : Controller
    {
        #region Variaveis
        private readonly IFuncionariosApp _funcionariosApp;
        private readonly IDocumentosPessoaisApp _documentosPessoaisApp;
        private readonly IDepartamentosApp _departamentoApp;
        private readonly IEstadoCivilApp _estadoCivilApp;
        private readonly IGenerosApp _generosApp;
        //private readonly 
        #endregion
        #region Construtores
        public FuncionariosController(IFuncionariosApp funcionariosApp,
            IDocumentosPessoaisApp documentosPessoaisApp,
            IDepartamentosApp departamentoApp,
            IEstadoCivilApp estadoCivilApp,
            IGenerosApp generosApp)
        {
            _funcionariosApp = funcionariosApp;
            _documentosPessoaisApp = documentosPessoaisApp;
            _departamentoApp = departamentoApp;
            _estadoCivilApp = estadoCivilApp;
            _generosApp = generosApp;
        }
        #endregion
        #region Metodos
        // GET: FuncionariosController
        public ActionResult Listar()
        {
            var model = _funcionariosApp.ObterTodos();
            return View(model);
        }
        // GET: FuncionariosController/Adicionar
        public ActionResult Adicionar()
        {
            ViewBag.Generos = _generosApp.ObterLista();
            ViewBag.EstadoCivil = _estadoCivilApp.ObterLista();
            ViewBag.Departamentos = _departamentoApp.ObterLista();
            ViewBag.documentos = _documentosPessoaisApp.ObterLista();
            return View();
        }

        // POST: FuncionariosController/Adicionar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adicionar(FuncionariosViewModel funcionariosViewModel)
        {
            try
            {
                ViewBag.Generos = _generosApp.ObterLista();
                ViewBag.EstadoCivil = _estadoCivilApp.ObterLista();
                ViewBag.Departamentos = _departamentoApp.ObterLista();
                ViewBag.documentos = _documentosPessoaisApp.ObterTodos();
                if (ModelState.IsValid)
                {
                    _funcionariosApp.Adicionar(funcionariosViewModel);
                }
                else
                {
                    return View(funcionariosViewModel);
                }
                return RedirectToAction("Listar");
            }
            catch
            {
                return View();
            }
        }

        // GET: FuncionariosController/Edit/5
        public ActionResult Actualizar(int id)
        {
            ViewBag.Generos = _generosApp.ObterLista();
            ViewBag.EstadoCivil = _estadoCivilApp.ObterLista();
            ViewBag.Departamentos = _departamentoApp.ObterLista();
            ViewBag.documentos = _documentosPessoaisApp.ObterLista();
            var func = _funcionariosApp.ObterPorId(id);
            return View(func);
        }

        // POST: FuncionariosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Actualizar(FuncionariosViewModel funcionariosViewModelv)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _funcionariosApp.Actualizar(funcionariosViewModelv);
                }
                else
                {
                    return View(funcionariosViewModelv);
                }
                return RedirectToAction("Listar");
            }
            catch
            {
                return View();
            }
        }

        // GET: FuncionariosController/Delete/5
        public ActionResult Remover(int id)
        {
            return View();
        }

        // POST: FuncionariosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Remover(Guid id, FuncionariosViewModel funcionariosViewModel)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FuncionariosController/Details/5
        public ActionResult Detalhes(Guid id)
        {
            return View();
        }
        #endregion
    }
}
