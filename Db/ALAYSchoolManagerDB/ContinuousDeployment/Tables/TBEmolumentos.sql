CREATE TABLE [dbo].[TBEmolumentos]
(
	EmolumentoId TINYINT NOT NULL identity(1,1), 
    EmolumentoDesignacao VARCHAR(50) NOT NULL
   

    constraint PK_EmolumentoId primary key (EmolumentoId)
	

)
