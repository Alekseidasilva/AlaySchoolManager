CREATE TABLE [dbo].[TBEmolumentoModulo]
(
 EmolumentoModuloModuloId smallint NOT NULL,
 EmolumentoModuloEmolumentoId TINYINT NOT NULL,
 EmolumentoModuloFactorId TINYINT NOT NULL,
 EmolumentoModuloPreco MONEY NOT NULL 

 CONSTRAINT PK_TBEmolumentoModulo_ModuloId_EmolumentoId Primary KEY ([EmolumentoModuloModuloId],[EmolumentoModuloEmolumentoId])
 CONSTRAINT FK_TBEmolumentoModulo_EmolumentoId FOREIGN KEY ([EmolumentoModuloEmolumentoId]) REFERENCES dbo.TBEmolumentos (EmolumentoId)
 CONSTRAINT FK_TBEmolumentoModulo_EmolumentoModulo_FactorId FOREIGN KEY ([EmolumentoModuloFactorId]) REFERENCES dbo.TBEmolumentosFactores ([EmolumentoFactorId])
 CONSTRAINT FK_TBEmolumentoModulo_ModuloId FOREIGN KEY ([EmolumentoModuloModuloId]) REFERENCES dbo.TBModulos ([ModuloId]), 
    [EmolumentoModuloUsuarioCadastrador] VARCHAR(50) NULL, 
    [EmolumentoModuloEstado] BIT NULL



)
