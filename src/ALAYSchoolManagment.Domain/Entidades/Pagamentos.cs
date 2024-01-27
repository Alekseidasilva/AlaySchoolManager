using ALAYSchoolManager.Domain.Entidades.Shared;

namespace ALAYSchoolManager.Domain.Entidades
{
    public class Pagamentos : EntidadeBase
    {
        #region Construtores
        public Pagamentos()
        {
            PagamentoAlunoNMatricula = new Aluno();
            PagamentoEmolumentoId = new Emolumentos();
            PagamentoModuloId = new Modulos();
            //PagamentoAnoAcademicoId = new AnoAcademico();



        }


        #endregion
        #region Propriedades

        public Aluno PagamentoAlunoNMatricula { get; set; }
        public Emolumentos PagamentoEmolumentoId { get; set; }
        public Modulos PagamentoModuloId { get; set; }
        public AnoAcademico PagamentoAnoAcademicoId { get; set; }
        public float PagamentoValorTotal { get; set; }
        public DateTime PagamentoDataHora { get; set; }
        public short PagamentoUsuarioId { get; set; }


        #endregion
        #region Validações
        #endregion
        public override bool EstaConsistente()
        {
            throw new NotImplementedException();
        }
    }
}



