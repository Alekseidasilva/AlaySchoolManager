CREATE PROCEDURE [dbo].[uspMatriculaEfectuar]
--------------Pessoa---------------------
@PESSOANOMECOMPLETO varchar(300),
@PessoaContribuinte varchar(15),
@PessoaDataNascimento date,
@PessoaGeneroId TINYINT,
@PessoaEstadoCivilId TINYINT,
@PessoaDataCadastro datetime,
@PessoaEstado BIT,
-------------Matricula--------------------
@MatriculaModuloId  TINYINT,
@MatriculaAnoAcademicoId int,
------------Pagamentos-------------------
@PagamentoEmolumentoId TINYINT,
@PagamentoValorTotal MONEY,


-------Usuario Cadastrador---------------
@Usuariocadastrador VARCHAR(20)



AS
BEGIN TRY
      BEGIN TRANSACTION
      ----------------Variaveis------------------------
        DECLARE @@matricula VARCHAR(30);
        DECLARE @@TotalAlunoExistentes INT;
        DECLARE @@IdAuto INT=0;
        DECLARE @@PessoaId INT=0;
        
        
        ----------------Criar numero de Matricula--------
        SELECT @@TotalAlunoExistentes=COUNT(aluno.AlunoPessoaId) FROM TBAlunos aluno
        if @@TotalAlunoExistentes >=0 begin 
             set @@TotalAlunoExistentes=@@TotalAlunoExistentes+1;
        end        
        SET @@matricula= dbo.uspGerarNMatricula(@@TotalAlunoExistentes);
        ----------------Criar Id da Pessoa---------------
        SELECT @@PessoaId=count(PessoaId) FROM dbo.TBPessoas
        if @@PessoaId >=0 begin 
             set @@PessoaId=@@PessoaId+1;
        end     
        --------------Inserindo Pessoa---------------
          INSERT INTO dbo.TBPessoas (PessoaId,PessoaNomeCompleto, PessoaContribuinte, PessoaDataNascimento, PessoaGeneroId, PessoaEstadoCivilId, PessoaDataCadastro, PessoaEstado)
          VALUES (@@PessoaId,@PESSOANOMECOMPLETO, @PessoaContribuinte,@PessoaDataNascimento, @PessoaGeneroId, @PessoaEstadoCivilId,@PessoaDataCadastro, @PessoaEstado);   
        	INSERT INTO TBMatriculas (MatriculaPessoaId, MatriculaModuloId, MatriculaAnoAcademicoId, MatriculaDataHora, MatriculaUsuarioId)
          VALUES (@@PessoaId, @MatriculaModuloId, @MatriculaAnoAcademicoId, @PessoaDataCadastro, @Usuariocadastrador);
          INSERT into TBAlunos (AlunoPessoaId, AlunoNMatricula)  VALUES (@@PessoaId, @@matricula);        
          INSERT INTO TBMatriculaConfirmacao (AlunoNMatricula, AnoAcademicoId,DataHora,UsuarioCadastrador)
          VALUES (@@matricula, @MatriculaAnoAcademicoId,@PessoaDataCadastro,@Usuariocadastrador);

         INSERT INTO TBPagamentos (PagamentoAlunoNMatricula, PagamentoEmolumentoId, PagamentoAnoAcademicoId, PagamentoValorTotal, PagamentoDataHora, PagamentoUsuarioId)
  VALUES (@@matricula, @PagamentoEmolumentoId, @MatriculaAnoAcademicoId, @PagamentoValorTotal, @PessoaDataCadastro, @Usuariocadastrador);
              COMMIT TRANSACTION
			      SELECT @@matricula AS RETORNO;
    END TRY
    BEGIN CATCH
      ROLLBACK TRANSACTION
      SELECT ERROR_MESSAGE() AS RETORNO;
    END CATCH

