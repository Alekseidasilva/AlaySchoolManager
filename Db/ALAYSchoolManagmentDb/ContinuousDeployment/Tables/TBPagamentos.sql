CREATE TABLE [dbo].[TBPagamentos]
(
	PagamentoId INT NOT NULL identity(1,1), 
    PagamentoAlunoNMatricula varchar(30) NOT NULL, 
    PagamentoEmolumentoId TINYINT NOT NULL ,
    PagamentoAnoAcademicoId INT  NOT NULL,
    PagamentoValorTotal MONEY NOT NULL, 
    PagamentoDataHora DATETIME NOT NULL, 
    PagamentoUsuarioId VARCHAR(10) NOT NULL

    constraint PK_TBPagamentos_PagamentoId primary key (PagamentoId)
	constraint FK_TBPagamentos_PagamentoAlunoNMatricula foreign key (PagamentoAlunoNMatricula) references dbo.TBAlunos(AlunoNMatricula)
    CONSTRAINT FK_TBPagamentos_PagamentoEmolumentoId FOREIGN KEY (PagamentoEmolumentoId)REFERENCES dbo.TBEmolumentos
	 CONSTRAINT FK_TBPagamentos_PagamentoAnoAcademicoId FOREIGN KEY (PagamentoAnoAcademicoId)REFERENCES dbo.TBAnoAcademico
	

)
