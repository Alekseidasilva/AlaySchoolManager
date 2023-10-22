CREATE TABLE [dbo].[TBDocumentosTipos]
(
	[DocumentosTiposId]  TINYINT NOT NULL identity(1,1),
    [DocumentosTiposDesigncao] VARCHAR(30) NULL

	constraint PK_DocumentosTiposId primary key (DocumentosTiposId)
)
