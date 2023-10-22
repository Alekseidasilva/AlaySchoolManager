CREATE TABLE [dbo].[TBGeneros]
(
	[GeneroId] SMALLINT NOT NULL identity(1,1),
	[GeneroDesignacao] varchar(20)not null

	constraint PK_GeneroId primary key (GeneroId) 

)
