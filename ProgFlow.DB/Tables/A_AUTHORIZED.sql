CREATE TABLE [dbo].[A_AUTHORIZED]
(
	[a_id]			INT NOT NULL PRIMARY KEY IDENTITY,
	[a_modifiable]	BIT NOT NULL,
	[a_creatable]	BIT NOT NULL,
	UNIQUE ([a_modifiable], [a_creatable]),
)
