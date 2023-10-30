CREATE PROCEDURE [dbo].[uspMastriculadosListar]
AS
BEGIN
	SELECT tm.MatriculaId,
  t.AlunoNMatricula,
  t2.PessoaNomeCompleto,
  t2.PessoaContribuinte,
  t2.PessoaDataNascimento,
  ta.AnoAcademicoDesignacao,
  t1.ModuloId,
  t1.ModuloDesignacao, 
  tm.MatriculaDataHora, 
  tm.MatriculaUsuarioId   
  FROM TBMatriculas tm
  JOIN TBAlunos t ON tm.MatriculaPessoaId = t.AlunoPessoaId
  JOIN TBPessoas t2 ON t.AlunoPessoaId = t2.PessoaId
  JOIN TBModulos t1 ON tm.MatriculaModuloId = t1.ModuloId
  JOIN TBAnoAcademico ta ON tm.MatriculaAnoAcademicoId = ta.AnoAcademicoId
END
