﻿using ALAYSchoolManager.Domain.Entidades.Shared;

namespace ALAYSchoolManager.Domain.Entidades
{
    public class PagamentoMensalidade : EntidadeBase
    {
        public PagamentoMensalidade()
        {
            PagamentosId = new Pagamentos();
            Meses = new Meses();

        }
        public Pagamentos PagamentosId { get; set; }

        public Meses Meses { get; set; }
        public override bool EstaConsistente()
        {
            throw new NotImplementedException();
        }
    }
}
