CREATE TABLE [dbo].[Subcomenzi]
(
	[id_subcomanda] INT NOT NULL PRIMARY KEY, 
    [id_comanda] CHAR(10) NOT NULL, 
    [id_produs] INT NOT NULL, 
    [cantitate] INT NOT NULL
)
