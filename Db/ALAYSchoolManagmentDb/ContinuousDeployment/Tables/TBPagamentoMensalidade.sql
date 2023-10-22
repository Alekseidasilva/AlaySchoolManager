CREATE TABLE [dbo].[TBPagamentoMensalidade]
(
	PagamentoId INT NOT NULL,	
	MesId tinyint not NULL
		
   

	constraint FK_TBPagamentoMensalidade_PagamentoId foreign key (PagamentoId)references dbo.TBPagamentos
	constraint FK_TBPagamentoEmolumentoMensalidade_MesId foreign key (MesId)references dbo.TBMeses    
	CONSTRAINT PK_TBPagamentoEmolumentoMensalidade_PagamentoId_MesId_AnoAcademicoId primary key (PagamentoId,MesId)
)

	