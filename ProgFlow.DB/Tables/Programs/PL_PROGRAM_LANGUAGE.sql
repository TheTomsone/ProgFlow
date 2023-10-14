CREATE TABLE [dbo].[PL_PROGRAM_LANGUAGE]
(
	[pl_program_id]		INT NOT NULL,
	[pl_language_id]	INT NOT NULL,
	PRIMARY KEY ([pl_program_id],[pl_language_id]),
	FOREIGN KEY ([pl_program_id])	REFERENCES [dbo].[P_PROGRAM]([p_id]),
	FOREIGN KEY ([pl_language_id])	REFERENCES [dbo].[L_LANGUAGE]([l_id]),
)
