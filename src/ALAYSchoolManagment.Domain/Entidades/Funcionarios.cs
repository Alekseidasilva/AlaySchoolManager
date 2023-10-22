using ALAYSchoolManagment.Domain.Entidades.Shared;

namespace ALAYSchoolManagment.Domain.Entidades
{
    public class Funcionarios : Pessoa
    {
        #region Contrutor

        public Funcionarios()
        {
            FuncionarioDepartamentosId = new Departamentos();
        }
        #endregion
        #region Propriedades


        public string FuncionarioNomeDoPai { get; set; }
        public string FuncionarioNomeDaMae { get; set; }

        public Departamentos FuncionarioDepartamentosId { get; set; }

        public double FuncionarioSalarioLiquido { get; set; }
        public string FuncionarioObservacoes { get; set; }

        #endregion
        #region Metodos
        //public override bool EstaConsistente()
        //{
        //    NomeDeveSerPreenchido();
        //    NomeDeveTerTamanhoMinimo(50);
        //    NomeCompletoDeveTerTamanhoMaximo(20);
        //    //RuaDeveSerPreenchida();
        //    //RuaDeveTerTamanhoMinimo(20);
        //    //RuaDeveTerTamanhoMaximo(20);
        //    //BairroDeveSerPreenchida();
        //    return !ListaErros.Any();
        //}
        #endregion


    }
}
