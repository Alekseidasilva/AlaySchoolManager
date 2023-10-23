using ALAYSchoolManager.Application.Interfaces;
using ALAYSchoolManager.Application.Interfaces.Shared;
using ALAYSchoolManager.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ALAYSchoolManagment.Presentation.IU.Areas.Creche.Controllers
{
    [Area("Creche")]
    public class CriancaController : Controller
    {
        #region Variaveis
        private readonly IAlunosApp _alunoApp;
        private readonly IEstadoCivilApp _estadoCivilApp;
        private readonly IGenerosApp _generosApp;
        #endregion
        #region Construtores
        public CriancaController(IAlunosApp alunoApp, IEstadoCivilApp estadoCivilApp, IGenerosApp generosAppService)
        {
            _alunoApp = alunoApp;
            _estadoCivilApp = estadoCivilApp;
            _generosApp = generosAppService;
        }


        #endregion

        #region Metodos
        public IActionResult ListarCriancas()
        {
            //var crianca = _alunoApp.ObterTodosPorModulo(1);
            return View();
        }

        [HttpGet]
        public IActionResult AdicionarCrianca()
        {
            ViewBag.Generos = _generosApp.ObterLista();
            //ViewBag.EstadoCivil = _estadoCivilAppService.ObterLista();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AdicionarCrianca(AlunosViewModel alunoViewModel)
        {
            try
            {
                //ViewBag.Generos = _generosApp.ObterLista();
                //ViewBag.EstadoCivil = _estadoCivilAppService.ObterLista();

                ////alunoViewModel.Id = Guid.NewGuid();
                //alunoViewModel.AlunoModuloId = Convert.ToString(1);
                //alunoViewModel.AlunoDataCadastro = DateTime.Now;
                //alunoViewModel.AlunoEstado = true;
                //alunoViewModel.AlunoUsuarioCadastrador = Guid.NewGuid().ToString();
                //_alunoApp.Adicionar(alunoViewModel);
                //if (ModelState.IsValid)
                //{
                //    _alunoAppService.Adicionar(alunoViewModel);
                //}
                //else
                //{
                //    return View(alunoViewModel);
                //}
                return RedirectToAction("ListarCriancas");
            }
            catch
            {
                return View();
            }
        }
        #endregion
    }
}
