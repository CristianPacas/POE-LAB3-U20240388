CREATE TABLE [dbo].[Usuarios]
(
	IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Usuario VARCHAR(50) NOT NULL UNIQUE,
    PasswordHash CHAR(64) NOT NULL

)
