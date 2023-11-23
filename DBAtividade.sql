create database DBatividade
go


create table Cadclientes(
idClientes int identity primary key,
Nome varchar (max),
Sobrenome varchar (max),
CPF varchar (max),
);

create table CadMaquinas(
idMaquinas int identity primary key,
Maquina varchar (max),
);

create table Inventario(
idInvt int identity primary key,
idClientes int,
idMaquinas int,
Qtd varchar (max),
);
