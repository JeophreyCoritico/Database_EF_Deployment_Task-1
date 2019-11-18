CREATE TABLE [dbo].[102575814Treatment]
(
	[Date] DATE NOT NULL, 
    [Notes] NVARCHAR(50) NOT NULL, 
    [Price] INT NOT NULL, 
    [OwnerID] INT NOT NULL, 
    [PetName] NVARCHAR(50) NOT NULL, 
    PRIMARY KEY ([Date], [OwnerID], [PetName]),
	FOREIGN KEY ([PetName], [OwnerID]) references [dbo].[102575814Pet]
)
