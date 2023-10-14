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

INSERT INTO [dbo].[C_CATEGORY] ([c_id],[c_label]) VALUES

-- CATEGORY
(10000,'System'),
    (11000,'Operating System'),
(20000,'Application'),
    (21000,'Graphical Software'),
        (21100,'Video Game'),
            (21101,'Action'),
            (21102,'Adventure'),
            (21103,'RPG'),
            (21104,'Strategy'),
            (21105,'Simulation'),
            (21106,'Sport'),
            (21107,'Racing'),
            (21108,'FPS'),
            (21109,'TPS'),
            (21110,'Shooter'),
            (21111,'Management'),
            (21112,'MMO'),
            (21113,'Coop'),
            (21114,'Solo'),
        (21200,'Game Engine'),
    (22000,'Database Management'),
        (22100, 'Relational Database'),
        (22200, 'NoSQL Database'),
        (22300, 'Object Relational Mapping'),
        (22400, 'Database Administration'),
    (23000,'Web'),
        (23100,'One-Page'),
        (23200,'Multi-Page'),
        (23300,'E-Commerce'),
    (24000,'Word Processors'),
    (25000,'Development Tools'),
    (26000,'Communication Platforms'),
        (26100,'Social Network'),
        (26200,'Crypted Network'),
    (27000,'Cyber-Security'),
        (27100,'Anti-Malware'),
        (27200,'Virtual Private Network'),
        (27300,'Password Manager'),
    (28000,'Media Editors'),
        (28100,'Image Editor'),
        (28200,'Video Editor'),

-- LANGUAGE
(10,'C++'),
(20,'C'),
(30,'Assemble'),
(40,'C#'),
(50,'.NET Core'),
    (51,'Console'),
    (52,'ASP.NET Core'),
    (53,'Entity Framework'),
    (54,'UWP'),
    (55,'Windows Form'),
    (56,'WPF'),
(60,'Typescript'),
    (61,'Angular'),
(70,'Javascript'),
    (71,'Node.js'),
(80,'HTML'),
(90,'CSS'),
(100,'SQL'),
(110,'NoSQL'),

-- STAGE
(200,'Developement'),
    (210,'Alpha'),
(300,'Testing'),
    (310,'Beta'),
(400,'Released'),
    (410,'Release Candidate'),
    (420,'Release'),
    (430,'Post-release fixes');