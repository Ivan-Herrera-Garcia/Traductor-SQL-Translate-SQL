USE [Escuela]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 07/10/2020 21:26:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[nombre_completo] [varchar](30) NULL,
	[edad] [int] NULL,
	[sexo] [char](3) NULL,
	[id] [char](8) NOT NULL,
	[carrera] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Alumno] ADD  DEFAULT ('M') FOR [sexo]
GO
