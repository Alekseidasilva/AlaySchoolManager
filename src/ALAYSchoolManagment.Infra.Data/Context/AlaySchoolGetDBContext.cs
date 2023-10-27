using ALAYSchoolManager.Domain.Entidades;
using ALAYSchoolManager.Domain.Entidades.Oldest.Identity;
using ALAYSchoolManager.Domain.Entidades.Oldest.Shared;
using ALAYSchoolManager.Domain.Entidades.Shared;
using ALAYSchoolManager.Domain.Entidades.Vo;
using ALAYSchoolManager.Infra.Data.Mappings.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ALAYSchoolManager.Infra.Data.Context
{
    public class AlaySchoolGetDbContext : IdentityDbContext<IdentityUser>
    {
        public AlaySchoolGetDbContext(DbContextOptions options) : base(options) { }
        #region DbSets
        #region DBSets Domain
        //public DbSet<MatriculaConfirmar> MatriculaConfirmar { get; set; }










        public DbSet<Aluno> Aluno { get; set; }
        //public DbSet<AlunoEmolumentos> AlunoEmolumentos { get; set; }
        public DbSet<Funcionarios> Funcionarios { get; set; }
        public DbSet<DocumentosPessoais> Documentos { get; set; }
        public DbSet<Contactos> Contactos { get; set; }
        public DbSet<Pagamentos> Pagamentos { get; set; }
        public DbSet<PagamentoMensalidade> PagamentoMensalidade { get; set; }
        public DbSet<Emolumentos> Emolumentos { get; set; }
        public DbSet<PerfilAcesso> Role { get; set; }
        public DbSet<Usuario> User { get; set; }
        public DbSet<Matriculas> Matriculas { get; set; }
        #endregion
        #region DBSet Shared
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Modulos> Modulos { get; set; }
        public DbSet<GenerosVo> Generos { get; set; }
        public DbSet<DocumentoPessoaisTipos> DocumentoTipos { get; set; }
        public DbSet<ContactoParente> ContactoParente { get; set; }
        public DbSet<EmolumentosFatores> EmolumentosFatores { get; set; }
        public DbSet<Meses> Meses { get; set; }
        public DbSet<EstadoCivilVo> EstadoCivil { get; set; }
        public DbSet<AnoAcademico> AnoAcademicos { get; set; }
        public DbSet<Departamentos> Departamentos { get; set; }
        public DbSet<AlunoEmolumentos> AlunoEmomentos { get; set; }
        public DbSet<FormasPagamentos> FormasPagamento { get; set; }
        #endregion
        #endregion
        #region OnModelCreating
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            #region Domain
            builder.ApplyConfiguration(new FormasPagamentoMapping());
            //builder.ApplyConfiguration(new MatriculaConfirmarMapping());






            builder.Ignore<Aluno>();
            builder.Ignore<Contactos>();
            builder.Ignore<Departamentos>();
            builder.Ignore<DocumentosPessoais>();
            builder.Ignore<Emolumentos>();
            builder.Ignore<Funcionarios>();
            builder.Ignore<Matriculas>();
            builder.Ignore<PagamentoMensalidade>();
            builder.Ignore<Pagamentos>();
            #endregion
            #region Shared
            builder.ApplyConfiguration(new GenerosVoMapping());
            builder.ApplyConfiguration(new EstadoCivilVoMapping());
            builder.ApplyConfiguration(new ModulosMapping());
            builder.ApplyConfiguration(new MesesMapping());



            builder.Ignore<AlunoEmolumentos>();
            builder.Ignore<AnoAcademico>();
            builder.Ignore<Bairro>();
            builder.Ignore<Comunas>();
            builder.Ignore<ContactoParente>();
            builder.Ignore<ContactosTipos>();
            builder.Ignore<DocumentoPessoaisTipos>();
            builder.Ignore<EmolumentosFatores>();






            builder.Ignore<Municipios>();
            builder.Ignore<Pessoa>();
            builder.Ignore<Provincias>();
            #endregion

            #region Ignorando
            builder.Ignore<EntidadeBase>();


            #endregion
            ////modelBuilder.Entity<IdentityUser>().ToTable("TBUsers");
            //modelBuilder.Entity<IdentityRole>().ToTable("TBRoles");
            //modelBuilder.Entity<IdentityUserRole<string>>().ToTable("TBUserRole");
            //modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("TBUserClaim");
            //modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("TBUserLogins");
            //modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("TBRoleClaims");
            //modelBuilder.Entity<IdentityUserToken<string>>().ToTable("TBUserTokens");
        }
        #endregion
        #region OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("SQLServerConnectionStrings"));
            //optionsBuilder.UseMySql(ServerVersion.AutoDetect(config.GetConnectionString("MySQLConnectionStrings")));
        }


        #endregion

    }
}
