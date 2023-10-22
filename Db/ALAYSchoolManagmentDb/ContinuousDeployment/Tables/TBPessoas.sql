CREATE TABLE [dbo].[TBPessoas]
(
	[PessoaId] int, 
    [PessoaNomeCompleto] VARCHAR(300) NULL, 
    [PessoaContribuinte] VARCHAR(15) NULL, 
    [PessoaDataNascimento] DATE NULL, 
    [PessoaGeneroId] SMALLINT NULL, 
    [PessoaEstadoCivilId] SMALLINT NULL, 
    [PessoaDataCadastro] DATETIME NULL, 
    [PessoaEstado] BIT NULL

	constraint PK_PessoaId primary key (PessoaId)
	constraint FK_PessoaGeneroId foreign key (PessoaGeneroId) references dbo.TBGeneros
    constraint FK_PessoaEstadoCivilId foreign key (PessoaEstadoCivilId) references dbo.TBEstadoCivil, 
    [PessoaObservacao] VARCHAR(MAX) NULL
)
