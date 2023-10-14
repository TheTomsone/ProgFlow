CREATE TABLE [dbo].[TU_TEAM_USER]
(
	[tu_team_id] INT NOT NULL,
	[tu_user_id] INT NOT NULL,
	[tu_role_id] INT NOT NULL,
	PRIMARY KEY ([tu_team_id], [tu_user_id]),
	FOREIGN KEY ([tu_team_id]) REFERENCES [dbo].[T_TEAM]([t_id]),
	FOREIGN KEY ([tu_user_id]) REFERENCES [dbo].[U_USER]([u_id]),
	FOREIGN KEY ([tu_role_id]) REFERENCES [dbo].[TR_TEAM_ROLE]([tr_id]),
)
