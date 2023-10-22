using ALAYSchoolManagment.Domain.Entidades.Vo;

namespace ALAYSchoolManagment.Domain.Entidades.Shared
{
    public abstract class Pessoa : EntidadeBase
    {

        #region Construtores
        protected Pessoa()
        {
            PessoaGenero = new GenerosVo();
            PessoaEstadoCivil = new EstadoCivilVo();
        }
        #endregion
        #region Propriedades
        public string? PessoaNomeCompleto { get; set; }
        public string? PessoaContribuinte { get; set; }
        public DateTime PessoaDataNascimento { get; set; }
        public GenerosVo PessoaGenero { get; set; }
        public EstadoCivilVo PessoaEstadoCivil { get; set; }
        public DateTime PessoaDataCadastro { get; set; }
        public bool PessoaEstado { get; set; }
        public string Observacao { get; set; }
        #endregion
        #region Metodos

        #endregion
        public override bool EstaConsistente()
        {
            throw new NotImplementedException();
        }
    }
}


