CREATE PROCEDURE [dbo].[uspMatriculaConfirmadosListar]
AS
begin
SELECT tc.AlunoNMatricula, t1.PessoaNomeCompleto, ta.AnoAcademicoDesignacao,tc.DataHora, tc.UsuarioCadastrador FROM TBMatriculaConfirmacao tc
JOIN TBAnoAcademico ta ON tc.AnoAcademicoId = ta.AnoAcademicoId
JOIN TBAlunos t ON tc.AlunoNMatricula = t.AlunoNMatricula
JOIN TBPessoas t1 ON t.AlunoPessoaId = t1.PessoaId
end
