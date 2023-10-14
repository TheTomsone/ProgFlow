CREATE TABLE [dbo].[TR_TEAM_ROLE]
(
	[tr_id]				INT NOT NULL PRIMARY KEY,
	[tr_authorized_id]	INT NULL,
	FOREIGN KEY ([tr_id]) REFERENCES [dbo].[G_GENRE]([g_id]),
	FOREIGN KEY ([tr_authorized_id]) REFERENCES [dbo].[A_AUTHORIZED]([a_id]),
)
