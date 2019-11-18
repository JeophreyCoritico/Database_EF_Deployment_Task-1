CREATE TABLE [dbo].[102575814Treatment]
(
	[Date] DATE NOT NULL, 
    [Notes] NVARCHAR(100) NOT NULL, 
    [Price] INT NOT NULL, 
    [OwnerID] INT NOT NULL, 
    [PetName] NVARCHAR(50) NOT NULL, 
	[ProcedureID] INT NOT NULL,
    PRIMARY KEY ([Date], [OwnerID], [PetName], [ProcedureID]),
	FOREIGN KEY ([PetName], [OwnerID]) references [dbo].[102575814Pet],
	FOREIGN KEY ([ProcedureID]) references [dbo].[102575814Procedure]
)
