select * from Categoria
delete from Categoria
--carga de datos en tabla de categorias
INSERT INTO Categoria(NOMBRECATEGORIA)
VALUES('Bebidas')
INSERT INTO Categoria(NOMBRECATEGORIA)
VALUES('Frescos')
INSERT INTO Categoria(NOMBRECATEGORIA)
VALUES('Secos')
INSERT INTO Categoria(NOMBRECATEGORIA)
VALUES('Bebidas Alcoholicas')
INSERT INTO Categoria(NOMBRECATEGORIA)
VALUES('Congelados')


--Marcas

INSERT INTO Marca(NOMBRE)
VALUES('CocaCola')
INSERT INTO Marca(NOMBRE)
VALUES('Don Vicente')
INSERT INTO Marca(NOMBRE)
VALUES('Manaos')
INSERT INTO Marca(NOMBRE)
VALUES('Fargo')
INSERT INTO Marca(NOMBRE)
VALUES('Bimbo')
INSERT INTO Marca(NOMBRE)
VALUES('Frigor')
INSERT INTO Marca(NOMBRE)
VALUES('Arcor')
INSERT INTO Marca(NOMBRE)
VALUES('La Serenisima')
INSERT INTO Marca(NOMBRE)
VALUES('Sancor')

--Presentacion
INSERT INTO Presentacion(DESCRIPCION)
VALUES('500grs')
INSERT INTO Presentacion(DESCRIPCION)
VALUES('250grs')
INSERT INTO Presentacion(DESCRIPCION)
VALUES('2.25lts')
INSERT INTO Presentacion(DESCRIPCION)
VALUES('1kg')
INSERT INTO Presentacion(DESCRIPCION)
VALUES('1.5Lts')
INSERT INTO Presentacion(DESCRIPCION)
VALUES('500cc')

select * from Marca
--insert de Productos

INSERT into Productos (IDMarca,IDCategoria,IDPresentacion,DESCRIPCION,PESO,PRECIO_UNITARIO,FECHA_VTO,URL_IMAGEN,ESTADO)
VALUES(1,2,3,'La vieja y confiable Coca',2,150,'2022/06/29','https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSdltKUUpvXeWE6UhrGWsLDqw--9mZoUeEDdA&usqp=CAU',1)

INSERT into Productos (IDMarca,IDCategoria,IDPresentacion,DESCRIPCION,PESO,PRECIO_UNITARIO,FECHA_VTO,URL_IMAGEN,ESTADO)
VALUES(5,3,1,'El pancito del osito',1,80,'2021/08/01','https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1RDyscZlNk-1VYV0X9altvgU1avsMuCdR6w&usqp=CAU',1)


INSERT INTO StockProductos(IDProducto, FECHA_Ingreso, CANTIDAD, Stock)
VALUES(2, GETDATE(), 100, 100),
values(1, '2021-07-04', 500	,500),
values(2, '2021-07-01', 250	,250),
values(1, '2021-07-01', 100	,100),
values(2, '2021-07-01', 1500,1500),
values(1, '2021-07-01', 20	,20),
values(2, '2021-07-01', 200	,200),
values(1, '2021-07-02', 100	,100),
values(2, '2021-07-01', 50	,50	),
values(2, '2021-07-08', 100	,100)

USE StokDepot_StammGomez
SELECT * FROM StockProductos
