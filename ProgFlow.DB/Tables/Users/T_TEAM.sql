CREATE TABLE [dbo].[T_TEAM]
(
	[t_id]			INT NOT NULL PRIMARY KEY,
	[t_genre_id]	INT NOT NULL,
	FOREIGN KEY ([t_id]) REFERENCES [dbo].[D_DATA]([d_id]),
	FOREIGN KEY ([t_genre_id]) REFERENCES [dbo].[C_CATEGORY]([c_id])
)
