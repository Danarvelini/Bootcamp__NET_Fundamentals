select * from clientes

alter table clientes drop constraint pk_cliente
alter table clientes drop column codigo

alter table clientes add code int identity(1,1) primary key
