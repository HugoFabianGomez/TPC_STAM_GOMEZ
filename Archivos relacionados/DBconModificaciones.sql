drop StokDepot_StammGomez
go
create database StokDepot_StammGomez
use StokDepot_StammGomez
go
create table Marca(
	ID int not null primary key identity(1,1),
	NOMBRE varchar (30) NOT NULL
)
go

create table Categoria(
	ID int not null primary key identity(1,1),
	NOMBRECATEGORIA varchar (30)
)
go
create table Presentacion(
	ID int not null primary key identity(1,1),
	DESCRIPCION varchar(50)
)
go
create table Productos(
	ID int not null primary key identity(1,1),
	IDMarca int foreign key references Marca(ID),
	IDCategoria int foreign key references Categoria(ID),
	IDPresentacion int foreign key references Presentacion(ID),
	DESCRIPCION varchar(50) not null,
	PESO int not null check(PESO > 0),
	PRECIO_UNITARIO money not null check(PRECIO_UNITARIO > 0.00),
	FECHA_VTO date not null check(FECHA_VTO > GETDATE()),
	URL_IMAGEN varchar(200) null,
	ESTADO bit not null
)
go

create table Pedidos(
	IDPedido int not null primary key identity(1,1),
	IDProductos int not null foreign key references Productos(ID),
	Cantidad int not null check(Cantidad >=1)
)
go

create table Clientes(
	CUIT_CUIL varchar(14) not null primary key,
	RAZON_SOCIAL varchar(50) not null,
	CONTACTO varchar(30) not null,
	DOMICILIO varchar(50) not null,
	LOCALIDAD varchar(30) not null,
)
go

create table Remito(
	ID int not null primary key identity(1,1),
	CUIT_CUIL varchar(14) not null foreign key references Clientes(CUIT_CUIL),
	IDPEDIDOS int not null foreign key references Pedidos(IDPedido),
	FECHA_RTO date not null check(FECHA_RTO > GETDATE())
)
go
--datos insertos
INSERT INTO Marca(TIPOCLIENTE) VALUES('Cliente muy importante')
UPDATE Productos set URL_IMAGEN = null where id = @id
go

--ELIMINAR LA COLUMNA FECHA_VTO
ALTER TABLE Productos alter column FECHA_VTO date null
UPDATE Productos set FECHA_VTO = null
ALTER TABLE Productos drop CONSTRAINT CK__Productos__FECHA__412EB0B6
ALTER TABLE Productos drop column FECHA_VTO
go

--MODIFICO LA COLUMNA URLIMAGEN
ALTER TABLE Productos alter column URL_IMAGEN varchar(700) null
go

--AGREGO LA NUEVA TABLA
create table StockProductos(
	ID int primary key not null identity(1,1),
	IDProducto int not null foreign key references Productos(ID),
	Fecha_Ingreso date not null,
	Cantidad int not null check(CANTIDAD > 0),
	Stock int NOT NULL CHECK(Stock>=0)
)

--Agrego la columna stock que da la cantidad que desde ahi se saca el stock real 
ALTER TABLE StockProductos add Stock int not null 

drop TABLE StockProductos
select * from StockProductos
go
GO

SELECT * from stockProductos
INSERT INTO StockProductos (IDProducto,FECHA_Ingreso,CANTIDAD,Stock)
VALUES (5,'2021/07/01',500,500)
INSERT INTO StockProductos (IDProducto,FECHA_Ingreso,CANTIDAD,Stock)
VALUES (7,'2021/07/01',250,250)
INSERT INTO StockProductos (IDProducto,FECHA_Ingreso,CANTIDAD,Stock)
VALUES (7,'2021/07/01',100,100)
INSERT INTO StockProductos (IDProducto,FECHA_Ingreso,CANTIDAD,Stock)
VALUES (5,'2021/07/01',1500,1500)
INSERT INTO StockProductos (IDProducto,FECHA_Ingreso,CANTIDAD,Stock)
VALUES (5,'2021/07/01',20,20)
INSERT INTO StockProductos (IDProducto,FECHA_Ingreso,CANTIDAD,Stock)
VALUES (7,'2021/07/01',200,200)
INSERT INTO StockProductos (IDProducto,FECHA_Ingreso,CANTIDAD,Stock)
VALUES (5,'2021/07/02',100,100)
INSERT INTO StockProductos (IDProducto,FECHA_Ingreso,CANTIDAD,Stock)
VALUES (7,'2021/07/01',50,50)


SELECT * from stockProductos

SELECT M.NOMBRE Marca,P.ID CodigoProducto,S.ID CodigoIngreso, from stockProductos S
inner join Productos P on P.ID=S.IDProducto
INNER JOIN Marca M on P.IDMarca=M.ID
