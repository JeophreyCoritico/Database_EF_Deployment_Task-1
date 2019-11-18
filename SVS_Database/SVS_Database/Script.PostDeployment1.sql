/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

Insert into [102575814Owner] ([OwnerID], [Surname], [Firstname], [Phone]) values 
(1, 'Sinatra', 'Frank', 400111222),
(2, 'Ellington', 'Duke', 400222333),
(1, 'Fitzgerald', 'Ella', 400333444);

Insert into [102575814Pet] ([PetName], [Type], [OwnerID]) values 
('Buster', 'Dog', 1),
('Fluffy', 'Cat', 1),
('Stew', 'Rabbit', 2),
('Pooper', 'Dog', 3),
('Buster', 'Dog', 3);
