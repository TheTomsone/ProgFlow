﻿CREATE TABLE [dbo].[D_DATA]
(
	[d_id]		INT				NOT NULL PRIMARY KEY IDENTITY,
	[d_name]	VARCHAR(50)		NOT NULL UNIQUE,
	[d_resume]	VARCHAR(MAX)	NULL,
    [d_created] DATETIME2		NOT NULL,
	[d_updated] DATETIME2		NOT NULL,
)
