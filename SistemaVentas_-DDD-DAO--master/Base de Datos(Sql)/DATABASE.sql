drop DATABASE SIVET
GO

CREATE DATABASE SIVET
GO

USE SIVET
GO


IF(NOT EXISTS(SELECT 1 FROM SYS.TABLES WHERE NAME='Usuarios'))
CREATE TABLE Usuarios
(
	Id_Usuario INT IDENTITY(1,1) PRIMARY KEY,
	DNI VARCHAR(8) NOT NULL,
	Nombres VARCHAR(128) NOT NULL,
	Apellidos VARCHAR(128) NOT NULL,
	DireccioN VARCHAR(128) NOT NULL,
	EMAIL VARCHAR(128) NOT NULL,
	Celular VARCHAR(9) NOT NULL,
	Contrasena VARCHAR(32) NOT NULL
)
GO

IF(NOT EXISTS(SELECT 1 FROM SYS.TABLES WHERE NAME='Clientes'))
CREATE TABLE Clientes
(
	Id_Cliente INT IDENTITY(1,1) PRIMARY KEY,
	Id_Usuario INT,
	CONSTRAINT FK_Clientes_Id_Usuario
	FOREIGN KEY(Id_Usuario) REFERENCES Usuarios(Id_Usuario)
)
GO
--D
IF(NOT EXISTS(SELECT 1 FROM SYS.TABLES WHERE NAME='Empleados'))
CREATE TABLE Empleados
(
	Id_Empleado INT IDENTITY(1,1) PRIMARY KEY,
	Id_Usuario INT NOT NULL,
	Area VARCHAR(64) NOT NULL,
	Cargo VARCHAR(64) NOT NULL,
	EstadoActivo BIT NOT NULL,
	CONSTRAINT FK_Empleados_Id_Usuario
	FOREIGN KEY(Id_Usuario) REFERENCES Usuarios(Id_Usuario)
)
GO

IF(NOT EXISTS(SELECT 1 FROM SYS.TABLES WHERE NAME='Facturas'))
CREATE TABLE Facturas
(
	Nrofactura SMALLINT IDENTITY(1,1),
	SerieFactura SMALLINT,
	Id_Cliente INT,
	Id_Empleado INT,
	Fecha DATETIME default null,
	Subtotal NUMERIC(5,2) default null,
	Descuento NUMERIC(5,2) default null,
	IGV Numeric(5,2) default null,
	CostoTotal NUMERIC(6,2) default null,
	CONSTRAINT FK_Facturas_Id_Cliente
	FOREIGN KEY(Id_Cliente) REFERENCES Clientes(Id_Cliente),
	CONSTRAINT FK_Facturas_Id_Empleados
	FOREIGN KEY(Id_Empleado) REFERENCES Empleados(Id_Empleado)
	,PRIMARY KEY(Nrofactura)
)
GO



IF(NOT EXISTS(SELECT 1 FROM SYS.TABLES WHERE NAME='EstadoPedido'))
CREATE TABLE EstadoPedido
(
	Id_Estado_Pedido SMALLINT IDENTITY(1,1),
	Nombre VARCHAR(16) NOT NULL,
	DESCRIPCION VARCHAR(64) NOT NULL,
	PRIMARY KEY(Id_Estado_Pedido)
)
GO

IF(NOT EXISTS(SELECT 1 FROM SYS.TABLES WHERE NAME='Pedidos'))
CREATE TABLE Pedidos
(
	Id_Pedido INT IDENTITY(1,1) PRIMARY KEY,
	Id_Cliente INT NOT NULL,
	Id_Estado_Pedido SMALLINT,
	EsPedidoGrande BIT,
	FechaEstimada DATETIME,
	TotalEstimado NUMERIC(6,2),
	CONSTRAINT FK_Pedidos_Id_Estado
	FOREIGN KEY(Id_Estado_Pedido) REFERENCES EstadoPedido(Id_Estado_Pedido)
)
GO

IF(NOT EXISTS(SELECT 1 FROM SYS.TABLES WHERE NAME='LimitesVenta'))
CREATE TABLE LimitesVenta
(
	Id_LimitesVenta SMALLINT IDENTITY(1,1),
	Porcentaje NUMERIC(5,2),
	DescPorcentaje NUMERIC(5,2),
	FechaUltimoCambio DATETIME,
	PRIMARY KEY(Id_LimitesVenta)
)
GO



IF(NOT EXISTS(SELECT 1 FROM SYS.TABLES WHERE NAME='Materiales'))
CREATE TABLE Materiales
(
	Id_Material INT IDENTITY(1,1) PRIMARY KEY,
	Id_LimitesVenta SMALLINT NOT NULL,
	Nombre VARCHAR(32) NOT NULL,
	Descripcion VARCHAR(128) NOT NULL,
	PrecioUnit NUMERIC(5,2) NOT NULL,
	Unidad VARCHAR(16) NOT NULL,
	Stock INT NOT NULL,
	CONSTRAINT FK_Materiales_Id_LimiteVenta
	FOREIGN KEY(Id_LimitesVenta) REFERENCES LimitesVenta(Id_LimitesVenta)
)
GO

IF(NOT EXISTS(SELECT 1 FROM SYS.TABLES WHERE NAME='Detalles_Pedido'))
CREATE TABLE Detalles_Pedido
(
	Id_Pedido INT NOT NULL,
	Id_Material INT NOT NULL,
	Cantidad SMALLINT NOT NULL,
	PrecioUnit NUMERIC(5,2),
	Subtotal NUMERIC(5,2),
	PRIMARY KEY(Id_Pedido,Id_Material),
	CONSTRAINT FK_Detalles_Pedido_Materiales
	FOREIGN KEY(Id_Material) REFERENCES Materiales(Id_Material),
	CONSTRAINT FK_Detalles_Pedido_Pedidos
	FOREIGN KEY(Id_Pedido) REFERENCES Pedidos(Id_Pedido)
	

)
GO


IF(NOT EXISTS(SELECT 1 FROM SYS.TABLES WHERE NAME='Detalles_Factura'))
CREATE TABLE Detalles_Factura
(
	Nrofactura SMALLINT,
	Id_Material INT,
	Cantidad SMALLINT NOT NULL,
	PrecioUnit NUMERIC(5,2) NOT NULL,
	Subtotal NUMERIC(5,2) NOT NULL
	,CONSTRAINT FK_Detalle_Facturas 
	FOREIGN KEY (Nrofactura) REFERENCES Facturas(Nrofactura)
	,CONSTRAINT FK_Detalles_Materiales
	FOREIGN KEY (Id_Material) REFERENCES Materiales(Id_Material)
)
GO






