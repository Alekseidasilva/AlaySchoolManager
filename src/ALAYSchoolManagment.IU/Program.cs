using ALAYSchoolManagment.Application.AutoMapper;
using ALAYSchoolManagment.Application.Interfaces;
using ALAYSchoolManagment.Application.Interfaces.Shared;
using ALAYSchoolManagment.Application.Services;
using ALAYSchoolManagment.Application.Services.Shared;
using ALAYSchoolManagment.Domain.Entidades;
using ALAYSchoolManagment.Domain.Interfaces.Repository;
using ALAYSchoolManagment.Domain.Interfaces.Repository.Shared;
using ALAYSchoolManagment.Domain.Interfaces.Services;
using ALAYSchoolManagment.Domain.Interfaces.Services.Shared;
using ALAYSchoolManagment.Domain.Services;
using ALAYSchoolManagment.Domain.Services.Shared;
using ALAYSchoolManagment.Infra.Data.Context;
using ALAYSchoolManagment.Infra.Data.Interfaces;
using ALAYSchoolManagment.Infra.Data.Repository;
using ALAYSchoolManagment.Infra.Data.Repository.Shared;
using ALAYSchoolManagment.Infra.Data.uOw;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AlaySchoolGetDbContext>(
    options =>
        {
            //var connectionsString = builder.Configuration.GetConnectionString("MySQLConnectionStrings");
            //options.UseMySql(connectionsString, ServerVersion.AutoDetect(connectionsString));
            options.UseSqlServer(builder.Configuration.GetConnectionString("SQLServerConnectionStrings"));
        });
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<AlaySchoolGetDbContext>()
    .AddDefaultUI()
    .AddDefaultTokenProviders();
#region IoC and DI

builder.Services.AddAutoMapper(a =>
{
    a.AddProfile<DomainToViewModels>();
    a.AddProfile<ViewModelsToDomain>();
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();



builder.Services.AddScoped<IMatriculasApp, MatriculaAppService>();
builder.Services.AddScoped<IMatriculaService, MatriculaService>();
builder.Services.AddScoped<IMatriculaRepository, MatriculaRepository>();


builder.Services.AddScoped<IMatriculaConfirmacaoApp, MatriculaConfirmarAppService>();
builder.Services.AddScoped<IMatriculaConfirmarService, MatriculaConfirmarService>();
builder.Services.AddScoped<IMatriculaConfirmarRepository, MatriculaConfirmarRepository>();

builder.Services.AddScoped<IEmolumentosModulosApp, EmolumentosModulosAppService>();
builder.Services.AddScoped<IEmolumentosModulosServices, EmolumentosModulosService>();
builder.Services.AddScoped<IEmolumentosModulosRepository, EmolumentosModulosRepository>();

builder.Services.AddScoped<IFormasPagamentoApp, FormasPagamentoAppService>();
builder.Services.AddScoped<IFormasPagamentoService, FormasPagamentoService>();
builder.Services.AddScoped<IFormasPagamentoRepository, FormasPagamentoRepository>();







builder.Services.AddScoped<IFuncionariosApp, FuncionariosAppService>();
builder.Services.AddScoped<IFuncionariosService, FuncionariosService>();
builder.Services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();

builder.Services.AddScoped<IDocumentosPessoaisApp, DocumentosPessoaisAppService>();
builder.Services.AddScoped<IDocumentoPessoaService, DocumentosPessoalService>();
builder.Services.AddScoped<IDocumentosPessoaisRepository, DocumentoPessoaRepository>();

builder.Services.AddScoped<IDepartamentosApp, DepartamentosAppService>();
builder.Services.AddScoped<IDepartamentoService, DepartamentoService>();
builder.Services.AddScoped<IDepartamentosRepository, DepartamentosRepository>();

builder.Services.AddScoped<IEstadoCivilApp, EstadoCivilAppService>();
builder.Services.AddScoped<IEstadoCivilService, EstadoCivilService>();
builder.Services.AddScoped<IEstadoCivilRepository, EstadoCivilRepository>();

builder.Services.AddScoped<IGenerosApp, GenerosAppService>();
builder.Services.AddScoped<IGeneroService, GeneroService>();
builder.Services.AddScoped<IGeneroRepository, GeneroRepository>();



builder.Services.AddScoped<IAlunosApp, AlunosAppService>();
builder.Services.AddScoped<IAlunoService, AlunoService>();
builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();


builder.Services.AddScoped<IPagamentosApp, PagamentosAppService>();
builder.Services.AddScoped<IPagamentosService, PagamentosService>();
builder.Services.AddScoped<IPagamentosRepository, PagamentosRepository>();

builder.Services.AddScoped<IAlunoEmolumentosApp, AlunoEmolumentosAppService>();
builder.Services.AddScoped<IAlunoEmolumentosService, AlunoEmolumentosService>();
builder.Services.AddScoped<IAlunoEmolumentosRepository, AlunoEmolumentosRepository>();




builder.Services.AddScoped<IModulosApp, ModulosAppService>();
builder.Services.AddScoped<IModulosService, ModuloService>();
builder.Services.AddScoped<IModuloRepository, ModuloRepository>();

builder.Services.AddScoped<IEmolumentosApp, EmolumentosAppService>();
builder.Services.AddScoped<IEmolumentosService, EmolumentosService>();
builder.Services.AddScoped<IEmolumentoRepository, EmolumentosRepository>();

#region Identity
//builder.Services.AddScoped<SignInManager<User>>();
//builder.Services.AddScoped<UserManager<User>>();
//builder.Services.AddScoped<IUserStore<User>, UserStore<User>>();
//builder.Services.AddScoped<IUserEmailStore<User>>();
//builder.Services.AddScoped<IEmailSender>();
//builder.Services.AddScoped<RoleManager<Role>>();


#endregion
#endregion



// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseBrowserLink();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
#pragma warning disable ASP0014
IApplicationBuilder applicationBuilder = app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Dashboard1}/{id?}");

app.Run();
