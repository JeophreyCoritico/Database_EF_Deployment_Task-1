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

DELETE FROM [102575814Treatment];
DELETE FROM [102575814Pet];
DELETE FROM [102575814Owner];
DELETE FROM [102575814Procedure];


Insert into [102575814Owner] ([OwnerID], [Surname], [Firstname], [Phone]) values 
(1, 'Sinatra', 'Frank', 400111222),
(2, 'Ellington', 'Duke', 400222333),
(3, 'Fitzgerald', 'Ella', 400333444);

Insert into [102575814Pet] ([PetName], [Type], [OwnerID]) values 
('Buster', 'Dog', 1),
('Fluffy', 'Cat', 1),
('Stew', 'Rabbit', 2),
('Pooper', 'Dog', 3),
('Buster', 'Dog', 3);

Insert into [102575814Procedure] ([ProcedureID], [Description], [Price]) values
(1, 'Rabies Vaccination', 24),
(5, 'Heart Worm Test', 25),
(8, 'Tetnus Vaccination', 17),
(10, 'Examine and Treat Wound', 30);

Insert into [102575814Treatment] ([Date], [Notes], [Price], [OwnerID], [PetName], [ProcedureID]) values
('2017-6-20', 'Routine Vaccination', 22, 1, 'Buster', 1),
('2018-5-15', 'Booster Shot', 24, 1, 'Buster', 1),
('2018-5-10', 'Wounds sustained in a apparent cat fight', 30, 1, 'Fluffy', 10),
('2017-6-20', 'Routine Vaccination', 24, 1, 'Fluffy', 1),
('2018-5-10', 'Wounds sustained during attempt to cook the stew', 30, 2, 'Stew', 10),
('2018-5-15', 'Routine Vaccination', 24, 2, 'Stew', 1),
('2018-5-18', 'Routine Test', 25, 3, 'Pooper', 5),
('2017-6-20', 'Stepped on a Rusty Nail', 17, 3, 'Buster', 8),
('2017-6-20', 'Routine Vaccination', 24, 3, 'Buster', 1);