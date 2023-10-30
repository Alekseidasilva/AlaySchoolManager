CREATE FUNCTION dbo.uspGerarNMatricula
(
	@NumeroTotalAlunos int	
)
RETURNS VARCHAR(30)
AS
BEGIN
DECLARE @@nMatricula VARCHAR(30);

SELECT  @@nMatricula=CASE 
WHEN @NumeroTotalAlunos BETWEEN 0 AND 9 THEN '0000'
WHEN @NumeroTotalAlunos BETWEEN 10 AND 99 THEN '000'
WHEN @NumeroTotalAlunos BETWEEN 100 AND 999 THEN '00'
WHEN @NumeroTotalAlunos BETWEEN 1000 AND 9999 THEN '0'
WHEN @NumeroTotalAlunos > 10000 THEN ''

--00000
--00010
--00100
--01000
--10000


--    WHEN @NumeroTotalAlunos > 0 AND @NumeroTotalAlunos < 10 THEN '0000'             
--    WHEN @NumeroTotalAlunos > 10 AND @NumeroTotalAlunos < 100 THEN '000'         
--    WHEN @NumeroTotalAlunos > 100 AND @NumeroTotalAlunos < 1000 THEN '00'
--    WHEN @NumeroTotalAlunos > 1000 AND @NumeroTotalAlunos < 10000 THEN '0'
--    WHEN @NumeroTotalAlunos > 10000  THEN ''
    
END
	RETURN CONCAT(@@nMatricula,@NumeroTotalAlunos)
END