CREATE TABLE [dbo].[TBContactos]
(
	[ContactosId] int not NULL identity(1,1), 
    [ContactosDesignacao] VARCHAR(100)  NULL, 
    [ContactosPessoaId] int  NULL, 
    [ContactoTipoId] TINYINT NULL, 
    [ContactoParenteId] TINYINT NULL

    constraint PK_ContactosId primary key (ContactosId)
	constraint FK_ContactosPessoaId foreign key (ContactosPessoaId) references dbo.TBPessoas
	constraint FK_ContactoTipoId foreign key (ContactoTipoId) references dbo.TBContactosTipo
	constraint FK_ContactoParenteId foreign key (ContactoParenteId) references dbo.TBContactoParentes
)
