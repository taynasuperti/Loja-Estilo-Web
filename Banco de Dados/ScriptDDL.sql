--Criar banco
CREATE DATABASE lojinha; --cria o banco de dados
go

use lojinha; --coloca o banco em uso
go

CREATE TABLE Categoria --cria as tabelas
(
	Id			int not null identity primary key, --faz o id ser automatico
	Nome		varchar(50) not null, --nome da categoria
	Foto		varchar(200), 
	ExibirHome	bit 
);

CREATE TABLE Produto
(
	Id			int not null identity primary key,
	Nome		varchar(200) not null, 
	Descricao	varchar(1000),
	CategoriaId	int not null,
	ValorCusto	numeric(10,2),
	ValorVenda	numeric(10,2) not null,
	QTdeEstoque	int not null default 0,
	Destaque	bit default 0,
	foreign key	(CategoriaId) references Categoria(Id)
);

CREATE TABLE  ProdutoFoto
(
	Id			int not null identity primary key,
	ProdutoId	int not null,
	Foto		varchar(200) not null,
	Descricao	varchar(100),
	foreign key (ProdutoId) references Produto(Id)
);