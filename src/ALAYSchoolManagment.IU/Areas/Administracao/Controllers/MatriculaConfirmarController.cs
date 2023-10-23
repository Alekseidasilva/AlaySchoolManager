using ALAYSchoolManagment.Application.Interfaces;
using ALAYSchoolManagment.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ALAYSchoolManager.Presentation.IU.Areas.Administracao.Controllers
{
    [Area("Administracao")]
    public class MatriculaConfirmarController : Controller
    {
        #region Variaveis
        private readonly IMatriculaConfirmacaoApp _matriculaConfirmacaoApp;
        #endregion
        #region Construtores
        public MatriculaConfirmarController(IMatriculaConfirmacaoApp matriculaConfirmacaoApp)
        {
            _matriculaConfirmacaoApp = matriculaConfirmacaoApp;
        }
        #endregion
        #region Metodos
        [HttpGet]
        public IActionResult ListarConfirmados()
        {
            var matric = _matriculaConfirmacaoApp.ObterTodos();
            return View(matric);
        }

        [HttpGet]
        public IActionResult Confirmar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Confirmar(MatriculaConfirmarViewModel matriculaConfirmarViewModel)
        {
            return View();
        }
        #endregion

    }
}
