using ALAYSchoolManager.Domain.Entidades.Oldest.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ALAYSchoolManager.Presentation.IU.Areas.Administracao.Controllers
{
    [Area("Administracao")]
    public class PerfisController : Controller
    {
        private readonly RoleManager<PerfilAcesso> _roleManager;

        //public PerfisController(RoleManager<Perfil> roleManager)
        //{
        //    _roleManager = roleManager;
        //}

        public IActionResult listar()
        {
            //var roles = _roleManager.Roles;
            return View();
        }

        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Adicionar(PerfilAcesso role)
        {
            //    if (!_roleManager.RoleExistsAsync(role.Name).GetAwaiter().GetResult())
            //        _roleManager.CreateAsync(new PerfilAcesso { Name = role.Name, }).GetAwaiter().GetResult();
            return RedirectToAction("listar");
        }
        [HttpGet]
        public async Task<IActionResult> Actualizar(string roleid)
        {
            var role = await _roleManager.FindByIdAsync(roleid);
            return View(role);
        }
        [HttpPost]
        public async Task<IActionResult> Actualizar(PerfilAcesso role)
        {
            //if (!_roleManager.RoleExistsAsync(role.Name).GetAwaiter().GetResult())
            //    await _roleManager.UpdateNormalizedRoleNameAsync(role);
            return RedirectToAction("listar");
        }
    }
}
