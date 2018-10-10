Database name: DockerDb

Table_1:

CREATE TABLE [dbo].[Table_1](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Timestamp] [datetime] NULL,
	[Message] [nvarchar](200) NOT NULL,

Table_2:

CREATE TABLE [dbo].[Table_2](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Message1] [nvarchar](50) NOT NULL,
	[Message2] [nvarchar](50) NOT NULL,

Data in table 2:

Message1 = "This is message 1"
Message2 = "This is message 2"
