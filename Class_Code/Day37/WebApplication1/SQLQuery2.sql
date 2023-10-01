Create database DbFirstDb

use DbFirstDb

CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Age] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[DepartmentId] [int] NULL,
 CONSTRAINT [PK_dbo.Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

select * from Employees

CREATE TABLE [dbo].[Department](	[DepartmentId] [int] IDENTITY(1,1) NOT NULL,	[DepartmentName] [varchar](50) NOT NULL, CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED (	[DepartmentId] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]) ON [PRIMARY]

select * from Department

ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Department] FOREIGN KEY([DepartmentId])REFERENCES [dbo].[Department] ([DepartmentId])

