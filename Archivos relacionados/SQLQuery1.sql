accesoModificar.setearConsulta("update stockproductos set idproducto = @idproducto, fecha_ingreso = @fecha_ingreso, cantidad = @cantidad, stock = @stock")
accesoModificar.setearParametro(@nombre, modificostock.idproducto);
accesoModificar.setearParametro(@fecha_ingreso, modificostock.fecha_ingreso);
accesoModificar.setearParametro(@cantidad, modificostock.cantidad);
accesoModificar.setearParametro(@stock, modificostock.stock);

use stokdepot_stammgomez

ALTER TABLE STOCKPRODUCTOS COLUMN Estado bit
alter table stockproductos
  add Estado bit not null default 1

select ID, NOMBRE from Marca
select * from Productos
insert into stockproductos(idproducto, FECHA_Ingreso, CANTIDAD, Stock)
values(2, getdate(), 100,100)
select S.ID ID, P.DESCRIPCION Descripcion, S.FECHA_Ingreso Fecha, S.CANTIDAD Cantidad,
M.NOMBRE Marca  from StockProductos S inner join Productos P on S.idproducto = P.ID 
inner join Marca M on M.ID = P.IDMarca

update stockproductos set estado = 1 where id = 43
select ID, IDPRODUCTO, FECHA_INGRESO, CANTIDAD, STOCK, Estado from stockproductos where id = 46

select s.ID, p.DESCRIPCION, s.FECHA_INGRESO, s.CANTIDAD, s.STOCK, s.ESTADO from stockproductos s inner join Productos p on s.IDProducto=p.ID 