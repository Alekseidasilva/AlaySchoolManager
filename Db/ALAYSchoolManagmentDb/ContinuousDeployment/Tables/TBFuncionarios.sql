CREATE TABLE [dbo].[TBFuncionarios]
(
	FuncionarioId int,
	FuncionarioDepartamentoId TINYINT NULL, 
    FuncionarioSalarioLiquido MONEY NULL, 
    FuncionarioObservacao VARCHAR(MAX) NULL



	constraint PK_FuncionarioId primary key (FuncionarioId)
	constraint FK_FuncionarioId foreign key (FuncionarioId) references dbo.TBPessoas
	constraint FK_FuncionarioDepartamentoId foreign key (FuncionarioDepartamentoId) references dbo.TBDepartamentos

)
