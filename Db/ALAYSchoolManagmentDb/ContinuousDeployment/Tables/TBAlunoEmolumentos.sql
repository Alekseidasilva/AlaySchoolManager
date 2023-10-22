CREATE TABLE [dbo].[TBAlunoEmolumentos]
(
	AlunoNMatricula varchar(30) NOT NULL,
	EmolumentoId tinyint

	constraint PK_TBAlunoEmolumentos_AlunoNMatricula_EmolumentoId primary key (AlunoNMatricula,EmolumentoId)
	constraint FK_TBAlunoEmolumentos_AlunoNMatricula foreign key (AlunoNMatricula) references dbo.TBAlunos(AlunoNMatricula)
	constraint FK_TBAlunoEmolumentos_EmolumentoId foreign key (EmolumentoId)references dbo.TBEmolumentos

)
