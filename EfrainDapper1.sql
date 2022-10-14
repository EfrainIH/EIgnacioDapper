CREATE DATABASE EIgnacioDapper1
Go
Use EIgnacioDapper1
GO

CREATE TABLE Usuario(
	IdUsuario INT IDENTITY (1,1) PRIMARY KEY,
	Nombre VARCHAR(50) NOT NULL,
	ApellidoP VARCHAR(50) NOT NULL,
	ApellidoM VARCHAR(50) NOT NULL,
	Email VARCHAR(100),
	Sexo CHAR(2),
	Edad TINYINT 
)

GO
CREATE PROCEDURE UsuarioGetAll
AS
	SELECT *FROM Usuario 
GO
EXEC UsuarioGetAll
GO


CREATE PROCEDURE UsuarioAdd
@Nombre VARCHAR(50),
@ApellidoP VARCHAR(50),
@ApellidoM VARCHAR(50),
@Email VARCHAR(100),
@Sexo CHAR(2),
@Edad TINYINT
AS
	INSERT INTO [Usuario]
				([Nombre],[ApellidoP],[ApellidoM],[Email],[Sexo],[Edad]
				) 
	VALUES (
		@Nombre,@ApellidoP,@ApellidoM,@Email,@Sexo,@Edad
	)
GO
EXEC UsuarioAdd 'Efrain','Ignacio','Hernandez','efrain@gmail.com','H',22
EXEC UsuarioAdd 'Luis','Sanchez','Hernandez','luis@gmail.com','H',20
EXEC UsuarioAdd 'Mariana','Gonzalez','Garcia','mariana@gmail.com','M',25
EXEC UsuarioAdd 'Juan','Martinez','Guitierrez','juan@gmail.com','H',22
EXEC UsuarioAdd 'Jose','Garcia','Lopez','jose@gmail.com','H',21
EXEC UsuarioAdd 'Laura','Nunez','Perez','laura@gmail.com','M',18




ALTER TABLE Usuario ADD IdRol INT
ALTER TABLE Usuario ADD FOREIGN KEY (IdRol) REFERENCES Rol(IdRol)

GO
UPDATE Usuario SET IdRol=1 WHERE IdUsuario=3
GO





--TABLA ROL
CREATE TABLE Rol(
	IdRol INT IDENTITY (1,1)PRIMARY KEY,
	Descripcion VARCHAR(50)
)
GO

CREATE PROCEDURE RolAdd
@Descripcion VARCHAR(50)
AS
	INSERT INTO [Rol] ([Descripcion]) 
	VALUES (@Descripcion)
GO
EXEC RolAdd 'Administrador'
EXEC RolAdd 'Usuario'
EXEC RolAdd 'Proveedor'



SELECT * FROM Usuario
SELECT * FROM Rol

SELECT U.IdUsuario, U.Nombre,U.ApellidoP,U.ApellidoM,U.Email,U.Sexo,u.Edad, R.IdRol,R.Descripcion
FROM Usuario U
INNER JOIN Rol R ON U.IdRol=R.IdRol
GO


CREATE PROCEDURE UsuarioUpdate--ACTUAZIZAR
@IdUsuario INT,
@Nombre VARCHAR(50),
@ApellidoP VARCHAR(50),
@ApellidoM VARCHAR(50),
@Email VARCHAR(100),
@Sexo CHAR(2),
@Edad TINYINT,
@IdRol INT
AS 
UPDATE Usuario SET  
       [Nombre] = @nombre,
       [ApellidoP] = @ApellidoP,
	   [ApellidoM]=@ApellidoM,
	   [Email]=@Email,
	   [Sexo]=@Sexo,
	   [Edad]=@Edad,
	   [IdRol]=@IdRol
       WHERE IdUsuario= @IdUsuario
GO
EXEC UsuarioUpdate 4,'Manuel','Ignacio','Martinez','manuel@gmail.com','H',30,2
GO


CREATE PROCEDURE UsuarioDelete --ELIMINAR
@IdUsuario INT
AS 
DELETE FROM Usuario WHERE IdUsuario = @IdUsuario
GO
EXEC UsuarioDelete 6;
GO

CREATE PROCEDURE UsuarioGetAll
AS
	SELECT [IdUsuario]
		  ,[Nombre]
		  ,[ApellidoP]
		  ,[ApellidoM]
		  ,[Email]
		  ,[Sexo]
		  ,[Edad]
	  FROM [Nombre] 
GO
EXEC UsuarioGetAll