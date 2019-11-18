CREATE TABLE [dbo].[102575814Pet]
(
	[PetName] NVARCHAR(50) NOT NULL, 
    [Type] NVARCHAR(50) NOT NULL, 
    [OwnerID] INT NOT NULL Foreign Key references [dbo].[102575814Owner]
	PRIMARY KEY ([PetName], [OwnerID])
)
