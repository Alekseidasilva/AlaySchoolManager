CREATE PROCEDURE [dbo].[uspEmolumentosModulosListar]
AS
BEGIN
SELECT
Emol.EmolumentoId, 
Emol.EmolumentoDesignacao, 

EmolFact.EmolumentoFactorId, 
EmolFact.EmolumentoFactorDesignacao, 

EmoMod.EmolumentoModuloPreco, 
EmoMod.EmolumentoModuloUsuarioCadastrador, 
EmoMod.EmolumentoModuloEstado, 
mod.ModuloId, 
mod.ModuloDesignacao

FROM TBEmolumentoModulo EmoMod
JOIN TBEmolumentos Emol ON EmoMod.EmolumentoModuloEmolumentoId = Emol.EmolumentoId
JOIN TBModulos mod ON EmoMod.EmolumentoModuloModuloId = mod.ModuloId
JOIN TBEmolumentosFactores EmolFact ON EmoMod.EmolumentoModuloFactorId = EmolFact.EmolumentoFactorId
END
