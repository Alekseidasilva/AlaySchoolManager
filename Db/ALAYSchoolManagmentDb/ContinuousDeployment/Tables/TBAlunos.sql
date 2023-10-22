CREATE TABLE [dbo].[TBAlunos]
(
    AlunoPessoaId int,
	AlunoNMatricula VARCHAR(30)not  NULL

	
	constraint PK_TBAlunos_AlunoNMatricula primary key (AlunoPessoaId)
	constraint FK_TBAlunos_AlunoPessoaId foreign key (AlunoPessoaId) references dbo.TBPessoas
	constraint UN_TBAlunos_AlunoNMatricula UNIQUE (AlunoNMatricula)
	
	
)


