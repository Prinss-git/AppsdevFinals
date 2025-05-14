CREATE PROCEDURE GenerateNextEdpCode
AS
BEGIN
    DECLARE @LastCode NVARCHAR(8)
    DECLARE @NewCode NVARCHAR(8)
    DECLARE @Number INT

    -- Get the last EDP code
    SELECT TOP 1 @LastCode = SSFEDPCODE 
    FROM SubjectSchedFile
    ORDER BY SSFEDPCODE DESC

    -- If no records exist, start with "EDP00001"
    IF @LastCode IS NULL
    BEGIN
        SET @NewCode = 'EDP00001'
    END
    ELSE
    BEGIN
        -- Extract the numeric part, convert to integer, increment
        SET @Number = CAST(SUBSTRING(@LastCode, 4, 5) AS INT) + 1
        SET @NewCode = 'EDP' + RIGHT('00000' + CAST(@Number AS NVARCHAR(5)), 5)
    END

    -- Return the new code
    SELECT @NewCode AS NextEdpCode
END
