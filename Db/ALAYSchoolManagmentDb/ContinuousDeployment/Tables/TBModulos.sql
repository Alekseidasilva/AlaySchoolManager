CREATE TABLE [dbo].[TBModulos]
(
	[ModuloId] SMALLINT NOT NULL identity(1,1), 
    [ModuloDesignacao] VARCHAR(20) NULL

	constraint PK_ModuloId primary key ([ModuloId])
)
