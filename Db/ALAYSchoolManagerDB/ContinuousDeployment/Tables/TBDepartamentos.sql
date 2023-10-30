CREATE TABLE [dbo].[TBDepartamentos]
(
	[DepartamentoId] TINYINT NOT NULL identity(1,1), 
    [DepartamentoDesignacao] VARCHAR(50) NULL

	constraint PK_DepartamentoId primary key (DepartamentoId)
)
