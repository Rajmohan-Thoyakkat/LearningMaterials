  
CREATE PROCEDURE StringSearchInSQLObject  
(  
 @TextToSearch VARCHAR(2000)  
)  
AS  
/****************************************************************************************  
DESCRIPTION: Generic Procedure to check for the text within the database  
*****************************************************************************************/  
BEGIN  
 SET NOCOUNT ON  
 --EXEC StringSearchInSQLObject 'boh'  
  
 -- Adding WILDCARD if not passed already  
 IF (CHARINDEX('%', @TextToSearch) = 0)  
  SET @TextToSearch = '%' + @TextToSearch + '%'  
   
 SELECT DISTINCT   
  sc.id AS 'OBJECT ID'  
  , OBJECT_NAME(sc.id) AS 'OBJECT NAME'  
  , USER_NAME(so.uid) AS 'OBJECT OWNER'  
  , CASE   
   WHEN so.xtype  = 'C'  THEN 'CHECK constraint'  
   WHEN so.xtype  = 'D'  THEN 'DEFAULT or DEFAULT constraint'  
   WHEN so.xtype  = 'F'  THEN 'FOREIGN KEY constraint'  
   WHEN so.xtype  = 'L'  THEN 'Log'  
   WHEN so.xtype  = 'FN' THEN 'Scalar function'  
   WHEN so.xtype  = 'IF'  THEN 'Inlined table-function'  
   WHEN so.xtype  = 'P'  THEN 'Stored procedure'  
   WHEN so.xtype  = 'PK'  THEN 'PRIMARY KEY constraint (type is K)'  
   WHEN so.xtype  = 'RF'  THEN 'Replication filter stored procedure'  
   WHEN so.xtype  = 'S'  THEN 'System table'  
   WHEN so.xtype  = 'TF'  THEN 'Table function'  
   WHEN so.xtype  = 'TR'  THEN 'Trigger'  
   WHEN so.xtype  = 'U'  THEN 'User table'  
   WHEN so.xtype  = 'UQ'  THEN 'UNIQUE constraint (type is K)'  
   WHEN so.xtype  = 'V'  THEN 'View'  
   WHEN so.xtype  = 'X'  THEN 'Extended stored procedure'  
  END AS 'OBJECT TYPE'  
  , CASE   
   WHEN sc.encrypted  = 0 THEN 'Not encrypted'  
   WHEN sc.encrypted  = 1 THEN 'Encrypted'  
  END AS 'ENCRYPTED'  
  , CASE   
   WHEN sc.compressed  = 0 THEN 'Not compressed'  
   WHEN sc.compressed  = 1 THEN 'Compressed'  
  END AS 'COMPRESSED'  
  , so.crdate AS 'CREATE DATE'  
  , sc.id AS 'OBJECT ID'  
 FROM syscomments sc   
 INNER JOIN sysobjects so   
  ON sc.id = so.id  
 WHERE   
  sc.text LIKE @TextToSearch  
 ORDER BY   
  'OBJECT TYPE'  
  , 'OBJECT NAME'  
  
 SET NOCOUNT ON  
END  