using ALAYSchoolManager.Application.ViewModels;
using ALAYSchoolManagment.Application.Interfaces;
using ALAYSchoolManagment.Application.Interfaces.Shared;
using Microsoft.AspNetCore.Mvc;

namespace ALAYSchoolManagment.Presentation.IU.Areas.Colegio.Controllers
{
    [Area("Colegio")]
    public class AlunoColegioController : Controller
    {
        private readonly IAlunosApp _alunoApp;
        private readonly IEstadoCivilApp _estadoCivilApp;
        private readonly IGenerosApp _generosApp;

        public AlunoColegioController(IAlunosApp alunoApp,
            IEstadoCivilApp estadoCivilApp,
            IGenerosApp generosApp)
        {
            _alunoApp = alunoApp;
            _estadoCivilApp = estadoCivilApp;
            _generosApp = generosApp;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            //var alunoColegio = _alunoApp.ObterTodosPorModulo(2);
            return View();
        }

        [HttpGet]
        public IActionResult Adicionar()
        {

            ViewBag.Generos = _generosApp.ObterLista();
            ViewBag.EstadoCivil = _estadoCivilApp.ObterLista();
            //var aluno = new AlunoViewModel
            //{
            //    GeneroSelectList = _generosAppService.ObterLista()
            //};


            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Adicionar(AlunosViewModel alunoViewModel)
        {
            ViewBag.Generos = _generosApp.ObterLista();
            ViewBag.EstadoCivil = _estadoCivilApp.ObterLista();
            if (alunoViewModel != null)
            {
                ////alunoViewModel.Id = Guid.NewGuid();
                //alunoViewModel.AlunoModuloId = Convert.ToString(2);
                //alunoViewModel.AlunoDataCadastro = DateTime.Now;
                //alunoViewModel.AlunoEstado = true;
                //alunoViewModel.AlunoUsuarioCadastrador = Guid.NewGuid().ToString();
                //_alunoApp.Adicionar(alunoViewModel);
                return RedirectToAction("Listar");
            }
            return View();
        }
    }
}
