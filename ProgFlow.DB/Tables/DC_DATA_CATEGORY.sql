CREATE TABLE [dbo].[DC_DATA_CATEGORY]
(
	[dc_data_id]		INT NOT NULL,
	[dc_category_id]	INT NOT NULL,
	PRIMARY KEY ([dc_data_id], [dc_category_id]),
	FOREIGN KEY ([dc_data_id])		REFERENCES [dbo].[D_DATA]([d_id]),
	FOREIGN KEY ([dc_category_id])	REFERENCES [dbo].[C_CATEGORY]([c_id]),
)
