CREATE TABLE [dbo].[TU_TEAM_USER]
(
	[tu_team_id] INT NOT NULL,
	[tu_user_id] INT NOT NULL,
	[tu_role_id] INT NOT NULL,
	PRIMARY KEY ([tu_team_id], [tu_user_id]),
)
