CREATE TABLE [dbo].[TBDocumentosPessoais]
(
	[DocumentosPessoaisId]  TINYINT NOT NULL identity(1,1),
    [DocumentosPessoaisPessoaId] int not NULL, 
	[DocumentosPessoaisDesignacao] VARCHAR(50) NULL,
    [DocumentosPessoaisTipoId] TINYINT NULL

    constraint PK_DocumentoId primary key (DocumentosPessoaisId)
	constraint FK_DocumentoPessoaId foreign key (DocumentosPessoaisPessoaId)references dbo.TBPessoas
	constraint FK_DocumentoTipoI foreign key (DocumentosPessoaisTipoId) references dbo.TBDocumentosTipos

   

)
