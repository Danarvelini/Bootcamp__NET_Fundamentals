select * from clientes

insert into clientes (Codigo, Nome, TipoPessoa) values (1, 'Dan', 'F');
insert clientes (Codigo, Nome, TipoPessoa) values (2, 'Dan', 'F'); -- Podemos emitir o comando "into"
insert clientes (Nome, Codigo, TipoPessoa) values ('Dan', 3, 'F');
insert clientes values (4, 'Dan', 'F'); -- Ao emitir quais são as colunas, a linguagem encara que estamos inserindo na ordem que foi definida na criação
insert clientes values (5, 'Ana', 'F'), (1, 'Mon', 'J');