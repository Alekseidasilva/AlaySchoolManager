CREATE TABLE [dbo].[TBFormasPagamento]
(
		FormasPagamentoId SMALLINT identity(1,1),
        FormasPagamentoDesignacao varchar(30) NOT NULL

       	CONSTRAINT PK_TBFormasPagamento_FormasPagamentoId PRIMARY KEY (FormasPagamentoId)
)
