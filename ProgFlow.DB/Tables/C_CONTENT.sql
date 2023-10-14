CREATE TABLE [dbo].[C_CONTENT]
(
	[c_id]			INT NOT NULL PRIMARY KEY,
	[c_stage_id]	INT NOT NULL,
	FOREIGN KEY ([c_id])		REFERENCES [dbo].[D_DATA]([d_id]),
	FOREIGN KEY ([c_stage_id])	REFERENCES [dbo].[S_STAGE]([s_id]),
)
