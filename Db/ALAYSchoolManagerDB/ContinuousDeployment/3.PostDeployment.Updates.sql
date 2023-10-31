/*
This will be executed during the post-deployment phase.
Use it to apply scripts which are supposed to modify the 
data after the schema update took place.

!!!Make sure your scripts are idempotent(repeatable)!!!

Example invocation:
EXEC sp_execute_script @sql = 'UPDATE Table....', @author = 'Your Name'
*/


---------------------------ESTADO CIVIL----------------------------------------
IF NOT EXISTS(	SELECT 1	FROM dbo.TBEstadoCivil) BEGIN
INSERT dbo.TBEstadoCivil (EstadoCivilDesignacao)
  VALUES ('Solteiro'),('Casado'),('Divorciado'),('Viúvo');
END

GO
---------------------------GENEROS----------------------------------------
IF NOT EXISTS(	SELECT 1	FROM dbo.TBGeneros)BEGIN
INSERT dbo.TBGeneros (GeneroDesignacao)
  VALUES ('MASCULINO'),('FEMENINO');
END

GO
---------------------------MODULOS----------------------------------------
IF NOT EXISTS(SELECT 1	FROM dbo.TBModulos tm) BEGIN
INSERT dbo.TBModulos (ModuloDesignacao)
  VALUES ('CRECHE'),('COLÉGIO');
END

GO
---------------------------MESES----------------------------------------
IF NOT EXISTS(	SELECT 1	FROM dbo.TBMeses tm) BEGIN
INSERT dbo.TBMeses (MesDesignacao)  VALUES 
('JANEIRO'),('FEVEREIRO'),('MARÇO'),('ABRIL'),('MAIO'),('JUNHO'),
('JULHO'),('AGOSTO'),('SETEMBRO'),('OUTUBRO'),('NOVEMBRO'),('DEZEMBRO');
END

go
---------------------------EMOLUMENTOS FACTORES----------------------------------------

IF NOT EXISTS(	SELECT 1	FROM dbo.TBEmolumentosFactores) BEGIN
	INSERT dbo.TBEmolumentosFactores (EmolumentoFactorDesignacao)
  VALUES ('OBRIGATÓRIO'),('OPCIONAL');
END

GO

---------------------------DOCUMENTOS TIPOS----------------------------------------

IF NOT EXISTS(	SELECT 1	FROM dbo.TBDocumentosTipos) BEGIN	
INSERT dbo.TBDocumentosTipos (DocumentosTiposDesigncao)
  VALUES ('Cédula Pessoal'),('Bilhete de Identidade'),('PassaPorte');
END

GO
-------------------------CONTACTOS TIPOS----------------------------------------

IF NOT EXISTS(	SELECT 1	FROM dbo.TBContactosTipo) BEGIN
INSERT dbo.TBContactosTipo (TBContactosTipoDesignacao)
  VALUES ('Telefone'),('Email');
END

GO
---------------------------EMOLUMENTOS----------------------------------------

IF NOT EXISTS(	SELECT 1	FROM dbo.TBEmolumentos) BEGIN
INSERT dbo.TBEmolumentos (EmolumentoDesignacao)
  VALUES ('MATRICULA'),('RECONFIRMAÇÃO MATRICULA'),('PROPINA'),('ALIMENTACAO'),('TRANSPORTE');
END

GO
---------------------------Formas de Pagamento----------------------------------------
IF NOT EXISTS(	SELECT 1	FROM dbo.TBFormasPagamento) BEGIN
INSERT INTO dbo.TBFormasPagamento (FormasPagamentoDesignacao)
  VALUES ('NUMERÁRIO'),('DEPÓSITO'),('TRANSFERÊNCIA');
END

GO
---------------------------ANO ACADEMICO----------------------------------------
IF NOT EXISTS(	SELECT 1	FROM dbo.TBAnoAcademico) BEGIN
INSERT dbo.TBAnoAcademico (AnoAcademicoId,AnoAcademicoDesignacao)
  VALUES (2023,'2023-2024');
END

GO
---------------------------EMOLUMENTOS MODULOS----------------------------------------
--IF NOT EXISTS(	SELECT 1	FROM dbo.TBEmolumentoModulo) BEGIN
--INSERT ALAYSchoolManagmentDb.dbo.TBEmolumentoModulo(EmolumentoModuloModuloId, EmolumentoModuloEmolumentoId, EmolumentoModuloFactorId, EmolumentoModuloPreco, EmolumentoModuloUsuarioCadastrador, EmolumentoModuloEstado) VALUES (1, 1, 1, 500.00, '1', CONVERT(bit, 'True'))
--INSERT ALAYSchoolManagmentDb.dbo.TBEmolumentoModulo(EmolumentoModuloModuloId, EmolumentoModuloEmolumentoId, EmolumentoModuloFactorId, EmolumentoModuloPreco, EmolumentoModuloUsuarioCadastrador, EmolumentoModuloEstado) VALUES (1, 2, 2, 250.00, '1', CONVERT(bit, 'True'))
--INSERT ALAYSchoolManagmentDb.dbo.TBEmolumentoModulo(EmolumentoModuloModuloId, EmolumentoModuloEmolumentoId, EmolumentoModuloFactorId, EmolumentoModuloPreco, EmolumentoModuloUsuarioCadastrador, EmolumentoModuloEstado) VALUES (1, 3, 1, 10000.45, '1', CONVERT(bit, 'True'))
--INSERT ALAYSchoolManagmentDb.dbo.TBEmolumentoModulo(EmolumentoModuloModuloId, EmolumentoModuloEmolumentoId, EmolumentoModuloFactorId, EmolumentoModuloPreco, EmolumentoModuloUsuarioCadastrador, EmolumentoModuloEstado) VALUES (1, 4, 2, 152.74, '1', CONVERT(bit, 'True'))
--INSERT ALAYSchoolManagmentDb.dbo.TBEmolumentoModulo(EmolumentoModuloModuloId, EmolumentoModuloEmolumentoId, EmolumentoModuloFactorId, EmolumentoModuloPreco, EmolumentoModuloUsuarioCadastrador, EmolumentoModuloEstado) VALUES (1, 5, 2, 123.81, '1', CONVERT(bit, 'True'))
--INSERT ALAYSchoolManagmentDb.dbo.TBEmolumentoModulo(EmolumentoModuloModuloId, EmolumentoModuloEmolumentoId, EmolumentoModuloFactorId, EmolumentoModuloPreco, EmolumentoModuloUsuarioCadastrador, EmolumentoModuloEstado) VALUES (2, 1, 1, 100.80, '2', CONVERT(bit, 'True'))
--INSERT ALAYSchoolManagmentDb.dbo.TBEmolumentoModulo(EmolumentoModuloModuloId, EmolumentoModuloEmolumentoId, EmolumentoModuloFactorId, EmolumentoModuloPreco, EmolumentoModuloUsuarioCadastrador, EmolumentoModuloEstado) VALUES (2, 2, 2, 456.97, '2', CONVERT(bit, 'True'))
--INSERT ALAYSchoolManagmentDb.dbo.TBEmolumentoModulo(EmolumentoModuloModuloId, EmolumentoModuloEmolumentoId, EmolumentoModuloFactorId, EmolumentoModuloPreco, EmolumentoModuloUsuarioCadastrador, EmolumentoModuloEstado) VALUES (2, 3, 1, 2500.01, '2', CONVERT(bit, 'True'))
--INSERT ALAYSchoolManagmentDb.dbo.TBEmolumentoModulo(EmolumentoModuloModuloId, EmolumentoModuloEmolumentoId, EmolumentoModuloFactorId, EmolumentoModuloPreco, EmolumentoModuloUsuarioCadastrador, EmolumentoModuloEstado) VALUES (2, 4, 2, 100.31, '2', CONVERT(bit, 'True'))
--INSERT ALAYSchoolManagmentDb.dbo.TBEmolumentoModulo(EmolumentoModuloModuloId, EmolumentoModuloEmolumentoId, EmolumentoModuloFactorId, EmolumentoModuloPreco, EmolumentoModuloUsuarioCadastrador, EmolumentoModuloEstado) VALUES (2, 5, 2, 123.00, '2', CONVERT(bit, 'True'))
--END









--IF NOT EXISTS(	SELECT 1 FROM dbo.TBPessoas) BEGIN
--INSERT INTO TBPessoas (PessoaNomeCompleto, PessoaContribuinte, PessoaDataNascimento, PessoaGeneroId, PessoaEstadoCivilId, PessoaDataCadastro, PessoaEstado)
--  VALUES ('Aleksei Justino Mateus Dondo da Silva', '003013895ME035', GETDATE(), 1, 2, GETDATE(), 1),('Telma Maria Damiao da Costa da Silva', '003013895ME035', GETDATE(), 2, 2, GETDATE(), 1);
--	END


--  GO
--IF NOT EXISTS(SELECT 1	FROM dbo.TBAlunos) BEGIN
--INSERT TBAlunos (AlunoPessoaId, AlunoNMatricula)
--  VALUES (1,'0001'),(2,'0002');
--END