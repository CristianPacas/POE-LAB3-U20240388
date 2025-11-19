/*
Script de implementación para BD_LAB3

Una herramienta generó este código.
Los cambios realizados en este archivo podrían generar un comportamiento incorrecto y se perderán si
se vuelve a generar el código.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "BD_LAB3"
:setvar DefaultFilePrefix "BD_LAB3"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detectar el modo SQLCMD y deshabilitar la ejecución del script si no se admite el modo SQLCMD.
Para volver a habilitar el script después de habilitar el modo SQLCMD, ejecute lo siguiente:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'El modo SQLCMD debe estar habilitado para ejecutar correctamente este script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Creando Tabla [dbo].[Productos]...';


GO
CREATE TABLE [dbo].[Productos] (
    [IdProducto]     INT             IDENTITY (1, 1) NOT NULL,
    [Nombre]         NVARCHAR (100)  NOT NULL,
    [Codigo]         NVARCHAR (100)  NOT NULL,
    [Categoria]      NVARCHAR (100)  NOT NULL,
    [PrecioUnitario] DECIMAL (18, 2) NOT NULL,
    [Cantidad]       INT             NOT NULL,
    [StockMinimo]    INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([IdProducto] ASC)
);


GO
PRINT N'Creando Tabla [dbo].[Usuarios]...';


GO
CREATE TABLE [dbo].[Usuarios] (
    [IdUsuario]    INT          IDENTITY (1, 1) NOT NULL,
    [Usuario]      VARCHAR (50) NOT NULL,
    [PasswordHash] CHAR (64)    NOT NULL,
    PRIMARY KEY CLUSTERED ([IdUsuario] ASC),
    UNIQUE NONCLUSTERED ([Usuario] ASC)
);


GO
PRINT N'Actualización completada.';


GO
