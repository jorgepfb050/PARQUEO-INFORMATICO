USE [PARQUEO03_30122021]
GO
/****** Object:  StoredProcedure [dbo].[sp_insert_component_desasignado_historiaReg]    Script Date: 30/03/2022 12:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_insert_component_desasignado_historiaReg]
 @cod_equipo int
,@dni varchar(14)
AS

INSERT INTO dbo.Historico_registro_equipo(
	 [doc_entry_personal]
	,[cod_equipo]
	,[fecha_registro]
	,[fecha_sistema]
	,[observacion_registro] 
	,[c_usuario] 
	,[c_nombres] 
	,[c_ape_paterno] 
	,[c_ape_materno] 
	,[fecha_ingreso] 
	,[c_perfil] 
	,[estado_personal] 
	,[dni] 
	,[c_sede]
	,[c_instancia] 
	,[fecha_nacimiento]
	,[escalafon]
	,[fecha_ingreso_lab] 
	,[fecha_termino_lab]
	,[nombre_completo]
	,[unidad_organica]
	,[area]
	,[tipo_personal]
	,[equipoPadreCod] 
	,[equipo]
	,[ip_equipo] 
	,[marca] 
	,[modelo]
	,[procesador]
	,[nro_serie]
	,[nro_control_patrimonial]
	,[anio_adquisicion] 
	,[nro_orden_compra]
	,[activo]
	,[cod_categoria]
	,[observacion_equipo] 
	,[fecha_desactivacion] 
	,[estado_equipo]
	,[service_tag] 
	,[funcionamiento]
	,[movimiento] 
	,[fecha_registro_hhmm] 
)
SELECT  
	 [doc_entry_personal]=(SELECT T1.doc_entry_personal from Personal T1 where T1.dni=@dni)
	,T0.[cod_equipo]
	,[fecha_registro]=(SELECT FORMAT(GETDATE(),'dd/MM/yyyy'))
	,[fecha_sistema]=(SELECT FORMAT(GETDATE(),'dd/MM/yyyy'))
	,[observacion_registro]='' 
	,[c_usuario] =(SELECT T1.c_usuario from Personal T1 where T1.dni=@dni)
	,[c_nombres] =(SELECT T1.c_nombres from Personal T1 where T1.dni=@dni)
	,[c_ape_paterno] =(SELECT T1.c_ape_paterno from Personal T1 where T1.dni=@dni)
	,[c_ape_materno] =(SELECT T1.c_ape_materno from Personal T1 where T1.dni=@dni)
	,[fecha_ingreso] =(SELECT T1.fecha_ingreso from Personal T1 where T1.dni=@dni)
	,[c_perfil] =(SELECT T1.c_perfil from Personal T1 where T1.dni=@dni)
	,[estado_personal] =(SELECT T1.estado from Personal T1 where T1.dni=@dni)
	,[dni] =(SELECT T1.dni from Personal T1 where T1.dni=@dni)
	,c_sede=(select T1.nombre_sede from [dbo].[Personal] T0 inner join [dbo].[Sede] T1 on T0.c_sede=T1.c_sede where T0.dni=@dni)
	,[c_instancia] =(select T1.nombre_instancia from [dbo].[Personal] T0 inner join [dbo].[Instancia] T1 on T0.c_instancia=T1.c_instancia where T0.dni=@dni)
	,[fecha_nacimiento]=(SELECT T1.fecha_nacimiento from Personal T1 where T1.dni=@dni)
	,[escalafon]=(SELECT T1.escalafon from Personal T1 where T1.dni=@dni)
	,[fecha_ingreso_lab] =(SELECT T1.fecha_ingreso_lab from Personal T1 where T1.dni=@dni)
	,[fecha_termino_lab]=(SELECT T1.fecha_termino_lab from Personal T1 where T1.dni=@dni)
	,[nombre_completo]=(SELECT T1.nombre_completo from Personal T1 where T1.dni=@dni)
	,[unidad_organica]=(SELECT T1.unidad_organica from Personal T1 where T1.dni=@dni)
	,[area]=(SELECT T1.area from Personal T1 where T1.dni=@dni)
	,[tipo_personal]=(SELECT T1.tipo_personal from Personal T1 where T1.dni=@dni)
	,T0.[equipoPadreCod]
	,T0.[equipo]
	,T0.[ip_equipo] 
	,T0.[marca] 
	,T0.[modelo]
	,T0.[procesador]
	,T0.[nro_serie]
	,T0.[nro_control_patrimonial]
	,T0.[anio_adquisicion] 
	,T0.[nro_orden_compra]
	,T0.[activo]
	,T0.[cod_categoria]
	,[observacion_equipo] =T0.observacion
	,T0.[fecha_desactivacion] 
	,[estado_equipo]=T0.estado
	,T0.[service_tag] 
	,T0.[funcionamiento]
	,[movimiento] ='DESASIGNADO'
	,[fecha_registro_hhmm] =(SELECT FORMAT(GETDATE(),'dd/MM/yyyy hh:mm:ss'))
	FROM Equipo T0 WHERE T0.cod_equipo=@cod_equipo


GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 30/03/2022 12:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[cod_categoria] [int] IDENTITY(1,1) NOT NULL,
	[categoria] [varchar](100) NOT NULL,
	[activo] [varchar](3) NULL,
	[observacion] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Distrito]    Script Date: 30/03/2022 12:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Distrito](
	[c_distrito] [int] NOT NULL,
	[x_nom_distrito] [varchar](300) NULL,
PRIMARY KEY CLUSTERED 
(
	[c_distrito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Equipo]    Script Date: 30/03/2022 12:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Equipo](
	[cod_equipo] [int] NOT NULL,
	[equipoPadreCod] [int] NULL,
	[equipo] [varchar](200) NOT NULL,
	[ip_equipo] [varchar](100) NULL,
	[marca] [varchar](100) NOT NULL,
	[modelo] [varchar](100) NOT NULL,
	[procesador] [varchar](100) NULL,
	[nro_serie] [varchar](100) NOT NULL,
	[nro_control_patrimonial] [varchar](1000) NULL,
	[anio_adquisicion] [varchar](50) NULL,
	[nro_orden_compra] [varchar](100) NULL,
	[activo] [varchar](3) NOT NULL,
	[cod_categoria] [int] NOT NULL,
	[observacion] [varchar](200) NULL,
	[fecha_desactivacion] [varchar](50) NULL,
	[estado] [varchar](100) NULL,
	[service_tag] [varchar](200) NULL,
	[funcionamiento] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_equipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Constrai] UNIQUE NONCLUSTERED 
(
	[nro_serie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Equipo_software]    Script Date: 30/03/2022 12:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Equipo_software](
	[cod_equipo_software] [int] IDENTITY(1,1) NOT NULL,
	[cod_software] [int] NOT NULL,
	[cod_equipo] [int] NOT NULL,
	[fecha_instalacion] [varchar](45) NULL,
	[fecha_caducidad] [varchar](45) NULL,
	[observacion] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_equipo_software] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Historico_registro_equipo]    Script Date: 30/03/2022 12:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Historico_registro_equipo](
	[doc_entry_hist_Reg_Eq] [int] IDENTITY(1,1) NOT NULL,
	[cod_registro] [int] NULL,
	[doc_entry_personal] [int] NULL,
	[cod_equipo] [int] NULL,
	[fecha_registro] [varchar](50) NULL,
	[fecha_sistema] [varchar](50) NULL,
	[observacion_registro] [varchar](200) NULL,
	[c_usuario] [varchar](18) NULL,
	[c_nombres] [varchar](200) NULL,
	[c_ape_paterno] [varchar](200) NULL,
	[c_ape_materno] [varchar](200) NULL,
	[fecha_ingreso] [varchar](50) NULL,
	[c_perfil] [varchar](100) NOT NULL,
	[estado_personal] [varchar](10) NULL,
	[dni] [varchar](14) NULL,
	[c_sede] [varchar](300) NULL,
	[c_instancia] [varchar](200) NULL,
	[fecha_nacimiento] [varchar](50) NULL,
	[escalafon] [varchar](200) NULL,
	[fecha_ingreso_lab] [varchar](50) NULL,
	[fecha_termino_lab] [varchar](50) NULL,
	[nombre_completo] [varchar](400) NULL,
	[unidad_organica] [varchar](400) NULL,
	[area] [varchar](400) NULL,
	[tipo_personal] [varchar](3) NULL,
	[equipoPadreCod] [int] NULL,
	[equipo] [varchar](200) NULL,
	[ip_equipo] [varchar](20) NULL,
	[marca] [varchar](100) NULL,
	[modelo] [varchar](100) NULL,
	[procesador] [varchar](100) NULL,
	[nro_serie] [varchar](100) NULL,
	[nro_control_patrimonial] [varchar](1000) NULL,
	[anio_adquisicion] [varchar](50) NULL,
	[nro_orden_compra] [varchar](100) NULL,
	[activo] [varchar](3) NULL,
	[cod_categoria] [int] NULL,
	[observacion_equipo] [varchar](200) NULL,
	[fecha_desactivacion] [varchar](50) NULL,
	[estado_equipo] [varchar](100) NULL,
	[service_tag] [varchar](200) NULL,
	[funcionamiento] [varchar](200) NULL,
	[movimiento] [nchar](100) NULL,
	[fecha_registro_hhmm] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[doc_entry_hist_Reg_Eq] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Instancia]    Script Date: 30/03/2022 12:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Instancia](
	[c_instancia] [varchar](100) NOT NULL,
	[c_sede] [int] NOT NULL,
	[nombre_instancia] [varchar](200) NOT NULL,
	[x_ubicacion_fisica] [varchar](200) NULL,
	[activo] [varchar](3) NULL,
	[nro_instancia] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[c_instancia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 30/03/2022 12:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Perfil](
	[c_perfil] [varchar](100) NOT NULL,
	[perfil] [varchar](200) NULL,
	[observacion] [varchar](200) NULL,
	[activo] [varchar](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[c_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Personal]    Script Date: 30/03/2022 12:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Personal](
	[doc_entry_personal] [int] IDENTITY(1,1) NOT NULL,
	[c_usuario] [char](18) NULL,
	[c_nombres] [varchar](200) NULL,
	[c_ape_paterno] [varchar](200) NULL,
	[c_ape_materno] [varchar](200) NULL,
	[fecha_ingreso] [varchar](50) NULL,
	[c_perfil] [varchar](100) NOT NULL,
	[estado] [varchar](10) NOT NULL,
	[dni] [varchar](14) NOT NULL,
	[c_sede] [int] NULL,
	[c_instancia] [varchar](200) NULL,
	[fecha_nacimiento] [varchar](50) NULL,
	[escalafon] [varchar](200) NULL,
	[fecha_ingreso_lab] [varchar](50) NULL,
	[fecha_termino_lab] [varchar](50) NULL,
	[nombre_completo] [varchar](400) NULL,
	[unidad_organica] [varchar](400) NULL,
	[area] [varchar](400) NULL,
	[tipo_personal] [varchar](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[doc_entry_personal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Personal_historial]    Script Date: 30/03/2022 12:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Personal_historial](
	[doc_entry_personal] [int] NOT NULL,
	[c_usuario] [char](18) NULL,
	[c_nombres] [varchar](200) NULL,
	[c_ape_paterno] [varchar](200) NULL,
	[c_ape_materno] [varchar](200) NULL,
	[fecha_ingreso] [varchar](50) NULL,
	[c_perfil] [varchar](100) NOT NULL,
	[estado] [varchar](10) NOT NULL,
	[dni] [varchar](14) NOT NULL,
	[c_sede] [int] NULL,
	[c_instancia] [varchar](200) NULL,
	[fecha_nacimiento] [varchar](50) NULL,
	[escalafon] [varchar](200) NULL,
	[fecha_ingreso_lab] [varchar](50) NULL,
	[fecha_termino_lab] [varchar](50) NULL,
	[nombre_completo] [varchar](400) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 30/03/2022 12:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Provincia](
	[c_provincia] [int] NOT NULL,
	[c_distrito] [int] NOT NULL,
	[x_nom_provincia] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[c_provincia] ASC,
	[c_distrito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Registro]    Script Date: 30/03/2022 12:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Registro](
	[cod_registro] [int] IDENTITY(1,1) NOT NULL,
	[doc_entry_personal] [int] NOT NULL,
	[cod_equipo] [int] NOT NULL,
	[fecha_registro] [varchar](45) NOT NULL,
	[fecha_sistema] [varchar](45) NULL,
	[observacion] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_registro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sede]    Script Date: 30/03/2022 12:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sede](
	[c_sede] [int] NOT NULL,
	[nombre_sede] [varchar](200) NOT NULL,
	[direccion] [varchar](200) NOT NULL,
	[observacion] [varchar](200) NULL,
	[activo] [varchar](3) NULL,
	[c_distrito] [int] NULL,
	[c_provincia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[c_sede] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Software]    Script Date: 30/03/2022 12:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Software](
	[cod_software] [int] IDENTITY(1,1) NOT NULL,
	[software] [varchar](150) NOT NULL,
	[version] [varchar](100) NULL,
	[cantidad_usuarios] [int] NULL,
	[nro_orden_compra] [varchar](100) NULL,
	[anio_aquisicion] [varchar](45) NULL,
	[observacion] [varchar](200) NULL,
	[activo] [varchar](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_software] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TablaTemporal]    Script Date: 30/03/2022 12:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TablaTemporal](
	[cod_registro] [int] NULL,
	[doc_entry_personal] [int] NULL,
	[cod_equipo] [int] NULL,
	[fecha_registro] [varchar](45) NULL,
	[fecha_sistema] [varchar](45) NULL,
	[observacion] [varchar](200) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 30/03/2022 12:48:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](100) NOT NULL,
	[password] [nvarchar](100) NOT NULL,
	[firstName] [nvarchar](100) NOT NULL,
	[lastName] [nvarchar](100) NOT NULL,
	[position] [nvarchar](100) NOT NULL,
	[email] [nvarchar](100) NOT NULL,
	[profilePicture] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Equipo]  WITH CHECK ADD FOREIGN KEY([cod_categoria])
REFERENCES [dbo].[Categoria] ([cod_categoria])
GO
ALTER TABLE [dbo].[Equipo_software]  WITH CHECK ADD FOREIGN KEY([cod_equipo])
REFERENCES [dbo].[Equipo] ([cod_equipo])
GO
ALTER TABLE [dbo].[Equipo_software]  WITH CHECK ADD FOREIGN KEY([cod_software])
REFERENCES [dbo].[Software] ([cod_software])
GO
ALTER TABLE [dbo].[Instancia]  WITH CHECK ADD FOREIGN KEY([c_sede])
REFERENCES [dbo].[Sede] ([c_sede])
GO
ALTER TABLE [dbo].[Personal]  WITH CHECK ADD FOREIGN KEY([c_perfil])
REFERENCES [dbo].[Perfil] ([c_perfil])
GO
ALTER TABLE [dbo].[Provincia]  WITH CHECK ADD FOREIGN KEY([c_distrito])
REFERENCES [dbo].[Distrito] ([c_distrito])
GO
ALTER TABLE [dbo].[Registro]  WITH CHECK ADD FOREIGN KEY([cod_equipo])
REFERENCES [dbo].[Equipo] ([cod_equipo])
GO
ALTER TABLE [dbo].[Registro]  WITH CHECK ADD FOREIGN KEY([doc_entry_personal])
REFERENCES [dbo].[Personal] ([doc_entry_personal])
GO
