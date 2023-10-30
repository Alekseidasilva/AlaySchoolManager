CREATE TABLE dbo.TBMatriculaConfirmacao (
  AlunoNMatricula VARCHAR(30) NOT NULL,
  AnoAcademicoId INT NOT NULL,
  DataHora datetime not null,
  UsuarioCadastrador varchar(20) not null


 CONSTRAINT FK_TBMatriculaConfirmacao_AlunoNMatricula FOREIGN KEY (AlunoNMatricula) REFERENCES dbo.TBAlunos (AlunoNMatricula)
 CONSTRAINT FK_TBMatriculaConfirmacao_AnoAcademico FOREIGN KEY (AnoAcademicoId) REFERENCES dbo.TBAnoAcademico (AnoAcademicoId)
 CONSTRAINT PK_TBMatriculaConfirmacao PRIMARY KEY CLUSTERED (AlunoNMatricula, AnoAcademicoId)
) 

