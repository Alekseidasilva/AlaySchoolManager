CREATE TABLE [dbo].[TBEstadoCivil]
(
	[EstadoCivilId] SMALLINT NOT NULL identity(1,1),
	[EstadoCivilDesignacao] varchar(20) not null 

	constraint PK_EstadoCivilId primary key (EstadoCivilId)
)
