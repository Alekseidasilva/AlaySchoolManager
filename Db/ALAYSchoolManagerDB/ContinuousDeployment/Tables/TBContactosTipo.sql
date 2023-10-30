CREATE TABLE [dbo].[TBContactosTipo]
(
	[TBContactosTipoId] TINYINT NOT NULL IDENTITY(1,1), 
    [TBContactosTipoDesignacao] VARCHAR(20) NULL

	constraint PK_TBContactosTipoId primary key (TBContactosTipoId)
)
