USE CBUSPass
GO

--DROP TABLE dbo.RunTimeVariable

CREATE TABLE dbo.RunTimeVariable
       (
        RuntimeValue VARCHAR(100)
      , LastUpdatedBy AS SYSTEM_USER
      , LastUpdatedDate DATETIME DEFAULT GETDATE()
       )

INSERT  INTO dbo.RunTimeVariable
        (RuntimeValue)
VALUES  ('Initial Value'  -- RuntimeValue - varchar(100)
         )

SELECT  *
FROM    dbo.RunTimeVariable rtv


