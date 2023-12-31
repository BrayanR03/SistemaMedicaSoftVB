USE [Win_MedicaSoft]
GO
/****** Object:  Table [dbo].[Cita]    Script Date: 17/07/2023 22:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cita](
	[IdCita] [int] IDENTITY(1,1) NOT NULL,
	[MontoTotal] [decimal](18, 0) NOT NULL,
	[IdHorarioAtencion] [int] NOT NULL,
	[IdPaciente] [int] NOT NULL,
 CONSTRAINT [PK_Cita] PRIMARY KEY CLUSTERED 
(
	[IdCita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HorarioAtencion]    Script Date: 17/07/2023 22:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HorarioAtencion](
	[IdHorarioAtencion] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [varchar](50) NOT NULL,
	[FechaRegistro] [date] NOT NULL,
	[HoraInicio] [varchar](50) NOT NULL,
	[HoraFin] [varchar](50) NOT NULL,
	[IdOdontologo] [int] NOT NULL,
 CONSTRAINT [PK_HorarioAtencion] PRIMARY KEY CLUSTERED 
(
	[IdHorarioAtencion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Odontologo]    Script Date: 17/07/2023 22:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Odontologo](
	[IdOdontologo] [int] IDENTITY(1,1) NOT NULL,
	[Apellidos] [varchar](100) NOT NULL,
	[Nombres] [varchar](100) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Dni] [char](8) NOT NULL,
	[Telefono] [char](9) NOT NULL,
	[Correo] [varchar](100) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Odontologo] PRIMARY KEY CLUSTERED 
(
	[IdOdontologo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 17/07/2023 22:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente](
	[IdPaciente] [int] IDENTITY(1,1) NOT NULL,
	[Apellidos] [varchar](100) NOT NULL,
	[Nombres] [varchar](100) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Dni] [char](8) NOT NULL,
	[Telefono] [char](9) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Correo] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[IdPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 17/07/2023 22:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Contraseña] [varchar](10) NOT NULL,
	[IdAdministrador] [int] NOT NULL,
 CONSTRAINT [PK_USUARIO] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Odontologo] ON 

INSERT [dbo].[Odontologo] ([IdOdontologo], [Apellidos], [Nombres], [FechaNacimiento], [Dni], [Telefono], [Correo], [Direccion]) VALUES (4, N'JUAREZ ALFARO', N'OLIVER MAYER', CAST(N'1990-07-14' AS Date), N'78451202', N'987654321', N'malfaro@gmail.com', N'Av. Ejercito')
SET IDENTITY_INSERT [dbo].[Odontologo] OFF
GO
SET IDENTITY_INSERT [dbo].[USUARIO] ON 

INSERT [dbo].[USUARIO] ([IdUsuario], [Usuario], [Contraseña], [IdAdministrador]) VALUES (4, N'ADMIN', N'ADMIN', 4)
INSERT [dbo].[USUARIO] ([IdUsuario], [Usuario], [Contraseña], [IdAdministrador]) VALUES (5, N'user1321', N'pas15', 4)
SET IDENTITY_INSERT [dbo].[USUARIO] OFF
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_HorarioAtencion] FOREIGN KEY([IdHorarioAtencion])
REFERENCES [dbo].[HorarioAtencion] ([IdHorarioAtencion])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_HorarioAtencion]
GO
ALTER TABLE [dbo].[Cita]  WITH CHECK ADD  CONSTRAINT [FK_Cita_Paciente] FOREIGN KEY([IdPaciente])
REFERENCES [dbo].[Paciente] ([IdPaciente])
GO
ALTER TABLE [dbo].[Cita] CHECK CONSTRAINT [FK_Cita_Paciente]
GO
ALTER TABLE [dbo].[HorarioAtencion]  WITH CHECK ADD  CONSTRAINT [FK_HorarioAtencion_Odontologo] FOREIGN KEY([IdOdontologo])
REFERENCES [dbo].[Odontologo] ([IdOdontologo])
GO
ALTER TABLE [dbo].[HorarioAtencion] CHECK CONSTRAINT [FK_HorarioAtencion_Odontologo]
GO
ALTER TABLE [dbo].[USUARIO]  WITH CHECK ADD  CONSTRAINT [FK_USUARIO_Odontologo] FOREIGN KEY([IdAdministrador])
REFERENCES [dbo].[Odontologo] ([IdOdontologo])
GO
ALTER TABLE [dbo].[USUARIO] CHECK CONSTRAINT [FK_USUARIO_Odontologo]
GO
/****** Object:  StoredProcedure [dbo].[_grabaHorario]    Script Date: 17/07/2023 22:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[_grabaHorario]
@estado varchar(50),@fecha date,@horainicio varchar(50),@horafin varchar(50),@idodontologo int
as
INSERT INTO HorarioAtencion(estado,FechaRegistro,horainicio,horafin,IdOdontologo)
values(@estado,@fecha,@horainicio,@horafin,@idodontologo)
GO
/****** Object:  StoredProcedure [dbo].[_grabaOdontologo]    Script Date: 17/07/2023 22:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[_grabaOdontologo]
@apellidos varchar(50),@nombres varchar(50),@fecha date,@dni char(8),@telefono char(9),@direccion varchar(100),@correo varchar(100)
as
INSERT INTO Odontologo(apellidos,nombres,fechaNacimiento,dni,telefono,direccion,correo)
VALUES(@apellidos,@nombres,@fecha,@dni,@telefono,@direccion,@correo)

GO
/****** Object:  StoredProcedure [dbo].[_grabaPaciente]    Script Date: 17/07/2023 22:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[_grabaPaciente]
@apellidos varchar(50),@nombres varchar(50),@fecha date,@dni char(8),@telefono char(9),@direccion varchar(100),@correo varchar(100)
as
INSERT INTO Paciente(apellidos,nombres,fechaNacimiento,dni,telefono,direccion,correo)
VALUES(@apellidos,@nombres,@fecha,@dni,@telefono,@direccion,@correo)
GO
/****** Object:  StoredProcedure [dbo].[buscarOdontologo]    Script Date: 17/07/2023 22:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[buscarOdontologo]
@dni char(8)
as
SELECT apellidos+' '+','+nombres AS DATOS FROM Odontologo WHERE Dni=@dni
GO
/****** Object:  StoredProcedure [dbo].[buscarPaciente]    Script Date: 17/07/2023 22:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[buscarPaciente]
@dni char(8)
as
SELECT apellidos+','+nombres as PACIENTE,IdPaciente as ID FROM Paciente
WHERE dni=@dni
GO
/****** Object:  StoredProcedure [dbo].[EstadoHorario]    Script Date: 17/07/2023 22:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EstadoHorario]
@estado varchar(50),@fechainicio date,@fechafin date
as
if @estado='DISPONIBLE'
BEGIN 
SELECT hor.IdHorarioAtencion AS CODIGO_HORARIO,hor.estado as ESTADO,hor.FechaRegistro as FECHA,hor.horainicio as H_INICIO,hor.horafin as H_FIN,odo.apellidos+' '+odo.nombres as ODONTOGOLO,odo.IdOdontologo as COD_ODONTOLOGO,odo.Dni as DNI
                                  FROM HorarioAtencion hor INNER JOIN Odontologo odo
                                  ON odo.IdOdontologo=hor.IdOdontologo
                                  WHERE hor.estado=@estado and hor.FechaRegistro BETWEEN @fechainicio and @fechafin
END
IF @estado='NO DISPONIBLE'
BEGIN 

SELECT hor.IdHorarioAtencion AS CODIGO_HORARIO,hor.estado as ESTADO,hor.FechaRegistro as FECHA,hor.horainicio as H_INICIO,hor.horafin as H_FIN,odo.apellidos+' '+odo.nombres as ODONTOGOLO,odo.IdOdontologo as COD_ODONTOLOGO,odo.Dni as DNI
                                  FROM HorarioAtencion hor INNER JOIN Odontologo odo
                                  ON odo.IdOdontologo=hor.IdOdontologo
                                  WHERE hor.estado=@estado and hor.FechaRegistro BETWEEN @fechainicio and @fechafin

END
IF @estado='TODOS'
BEGIN 

SELECT hor.IdHorarioAtencion AS CODIGO_HORARIO,hor.estado as ESTADO,hor.FechaRegistro as FECHA,hor.horainicio as H_INICIO,hor.horafin as H_FIN,odo.apellidos+' '+odo.nombres as ODONTOGOLO,odo.IdOdontologo as COD_ODONTOLOGO,odo.Dni as DNI
                                  FROM HorarioAtencion hor INNER JOIN Odontologo odo
                                  ON odo.IdOdontologo=hor.IdOdontologo 
								  WHERE hor.FechaRegistro BETWEEN @fechainicio and @fechafin
END
GO
/****** Object:  StoredProcedure [dbo].[grabarCita]    Script Date: 17/07/2023 22:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[grabarCita]
@monto decimal(9,2),@idhorario int,@idpaciente int
as
INSERT INTO Cita(montototal,IdHorarioAtencion,IdPaciente)
VALUES(@monto,@idhorario,@idpaciente)
GO
/****** Object:  StoredProcedure [dbo].[InyecSQLPrueba]    Script Date: 17/07/2023 22:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InyecSQLPrueba]
@usuario varchar(50),@contraseña varchar(10)
as
SELECT *FROM USUARIO where Usuario=@usuario AND Contraseña=@contraseña
print 'TRUE'
GO
/****** Object:  StoredProcedure [dbo].[ListaCitasPorFecha]    Script Date: 17/07/2023 22:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ListaCitasPorFecha]
@fecha date
as
SELECT ci.IdCita as NRO_CITA,ci.MontoTotal as MONTO_CITA,pac.Dni as DNI,pac.Apellidos+' '+pac.Nombres as DATOS_PACIENTE,pac.IdPaciente as CODIGO_PACIENTE,
hor.IdHorarioAtencion as ID_HORARIO,hor.Estado as ESTADO,hor.FechaRegistro as FECHA_HORARIO,hor.HoraInicio as HORA_INICIO,hor.HoraFin as HORA_FIN,hor.IdOdontologo AS ODONTOLOGO
FROM Cita ci INNER JOIN Paciente pac 
ON pac.IdPaciente=ci.IdPaciente
INNER JOIN HorarioAtencion hor 
ON hor.IdHorarioAtencion=ci.IdHorarioAtencion
WHERE hor.FechaRegistro=@fecha
GO
/****** Object:  StoredProcedure [dbo].[totalCitas]    Script Date: 17/07/2023 22:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[totalCitas]
@fecha date
as
SELECT COUNT(hor.FechaRegistro) as Total 
FROM Cita ci INNER JOIN HorarioAtencion hor 
ON hor.IdHorarioAtencion=ci.IdHorarioAtencion
WHERE hor.FechaRegistro=@fecha
group by hor.FechaRegistro
GO
/****** Object:  StoredProcedure [dbo].[VERIFICA_USER]    Script Date: 17/07/2023 22:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[VERIFICA_USER]
@user varchar(50),@contra varchar(50)
AS
IF exists (SELECT Username=@user,Password=@contra FROM USUARIO where Usuario=@user and Contraseña=@contra) 
BEGIN
SELECT odo.Apellidos as ODONTOLOGO
FROM USUARIO us INNER JOIN Odontologo ODO
ON odo.IdOdontologo=us.IdAdministrador
where us.Usuario=@user
print 'EXISTE'

END
else 
BEGIN
print 'NO EXISTE, ERES ALGUIEN DENEGADO'

END
GO
/****** Object:  Trigger [dbo].[act_estado_horario_cita]    Script Date: 17/07/2023 22:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE trigger [dbo].[act_estado_horario_cita] ON [dbo].[Cita]
FOR UPDATE
as
SELECT *FROM inserted
SELECT *FROM deleted

UPDATE hor set Estado='NO DISPONIBLE' 
FROM HorarioAtencion hor INNER JOIN inserted ins
ON ins.IdHorarioAtencion=hor.IdHorarioAtencion

UPDATE hor set Estado='DISPONIBLE' 
FROM HorarioAtencion hor INNER JOIN deleted det
ON det.IdHorarioAtencion=hor.IdHorarioAtencion

GO
ALTER TABLE [dbo].[Cita] ENABLE TRIGGER [act_estado_horario_cita]
GO
/****** Object:  Trigger [dbo].[estado_horario_eliminar]    Script Date: 17/07/2023 22:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[estado_horario_eliminar] ON [dbo].[Cita]
FOR DELETE
AS
UPDATE HOR set Estado='DISPONIBLE'
FROM HorarioAtencion HOR INNER JOIN deleted CIT
ON hor.IdHorarioAtencion=cit.IdHorarioAtencion
WHERE hor.IdHorarioAtencion=cit.IdHorarioAtencion
GO
ALTER TABLE [dbo].[Cita] ENABLE TRIGGER [estado_horario_eliminar]
GO
/****** Object:  Trigger [dbo].[modifica_estado_horario]    Script Date: 17/07/2023 22:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[modifica_estado_horario] ON [dbo].[Cita]
FOR INSERT
AS
BEGIN
UPDATE hor set estado='NO DISPONIBLE'
FROM HorarioAtencion hor INNER JOIN inserted CI
on ci.IdHorarioAtencion=HOR.IdHorarioAtencion
where hor.IdHorarioAtencion=ci.IdHorarioAtencion
END
GO
ALTER TABLE [dbo].[Cita] ENABLE TRIGGER [modifica_estado_horario]
GO
