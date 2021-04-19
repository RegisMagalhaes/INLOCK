create database inlock_games_tarde;

use inlock_games_tarde;

-- Banco de dados criado por Regis Leandro 

-- criação das tabelas estudio, jogos, tipoUsuario e usuarios conforme solicitado no storytelling
create table estudios
(
	idEstudio	int primary key identity,
	nomeEstudio varchar(200) unique not null,
		
);

create table jogos 
(

	idJogo int primary key identity,
	nomeJogo varchar(200) unique not null,
	descricao varchar(400),
	dataLancamento date not null,
	valor varchar (100), 
	idEstudio int foreign key  references estudios(idEstudio)
);

create table tiposUsuario
(
	idTipoUsuario int primary key identity,
	titulo varchar (200)

);

create table usuarios
(
	idUsuario int primary key identity,
	email varchar (200),
	senha varchar (50),
	idTipoUsuario int foreign key references tiposUsuario(idTipoUsuario)

);