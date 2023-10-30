CREATE TABLE [dbo].[TBEmolumentosFactores]
(
	[EmolumentoFactorId] TINYINT NOT NULL identity(1,1), 
    [EmolumentoFactorDesignacao] VARCHAR(20) NOT NULL

	constraint PK_EmolumentoFactorId primary key ([EmolumentoFactorId])
)
