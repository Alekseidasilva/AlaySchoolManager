CREATE TABLE [dbo].[TBMatriculas]
(
	MatriculaId INT NOT NULL IDENTITY(1,1), 
    MatriculaPessoaId int not null,
    MatriculaModuloId smallint not NULL,    
    MatriculaAnoAcademicoId int not null,
    MatriculaDataHora DATETIME not NULL, 
    MatriculaUsuarioId VARCHAR(20) not NULL

    constraint PK_TBMatriculas_MatriculaId primary key (MatriculaId)
	constraint FK_TBMatriculas_MatriculaPessoaId foreign key (MatriculaPessoaId) references dbo.TBPessoas	
	constraint PK_TBMatriculas_MatriculaModuloId foreign key (MatriculaModuloId)references dbo.TBModulos
	constraint PK_TBMatriculas_MatriculaAnoAcademicoId foreign key (MatriculaAnoAcademicoId)references dbo.TBAnoAcademico
)
