﻿CREATE TABLE [dbo].[P_PROGRAM]
(
	[p_id]	INT			NOT NULL PRIMARY KEY,
	[p_eta] DATETIME2	NULL,
	FOREIGN KEY ([p_id]) REFERENCES [dbo].[D_DATA]([d_id]),
)
