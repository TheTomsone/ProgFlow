CREATE TABLE [dbo].[U_USER]
(
	[u_id]				INT				NOT NULL PRIMARY KEY,
	[u_firstname]		VARCHAR(50)		NOT NULL,
	[u_lastname]		VARCHAR(50)		NOT NULL,
	[u_email]			VARCHAR(100)	NOT NULL UNIQUE,
	[u_password_hash]	VARBINARY(64)	NOT NULL,
	[u_salt]			VARCHAR(100)	NOT NULL,
)
