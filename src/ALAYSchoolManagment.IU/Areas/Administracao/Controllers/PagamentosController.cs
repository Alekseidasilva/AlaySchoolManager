using ALAYSchoolManagment.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ALAYSchoolManager.Presentation.IU.Areas.Administracao.Controllers
{

    [Area("Administracao")]
    public class PagamentosController : Controller
    {

        #region Variaveis
        private readonly IPagamentosApp _pagamentosApp;
        private readonly IAlunosApp _alunoApp;
        private readonly IAlunoEmolumentosApp _alunaEmolumentosApp;
        #endregion
        #region Construtores
        public PagamentosController(IPagamentosApp pagamentosApp, IAlunosApp alunoApp, IAlunoEmolumentosApp alunaEmolumentosApp)
        {
            _pagamentosApp = pagamentosApp;
            _alunoApp = alunoApp;
            _alunaEmolumentosApp = alunaEmolumentosApp;
        }

        #endregion
        #region Metodos

        public IActionResult ListarPagamentos()
        {
            var pagamento = _pagamentosApp.ObterTodos();
            return View(pagamento);
        }
        [HttpGet]

        public IActionResult EfectuarPagamento()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EfectuarPagamento1()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Imprimir()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Reimprimir()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Detalhes()
        {
            return View();
        }
        //[HttpGet]
        //public IActionResult BuscarAlunoPeloNMatricula(string nMatricula)
        //{
        //    var aluno = _alunoAppService.BuscarPeloNMatricula(nMatricula);
        //    if (aluno != null)
        //    {

        //    }


        //    return View();
        //}




        #endregion

    }
}
