CREATE DATABASE IF NOT EXISTS academico;

USE academico;

CREATE TABLE aluno(
	id				int				NOT NULL AUTO_INCREMENT,
	matricula		varchar(15)		NOT NULL,
    dt_nascimento	date		NOT NULL,
	nome			varchar(100)	NOT NULL,
	endereco		varchar(100)	NOT NULL,
	bairro			varchar(100)	NOT NULL,
	cidade			varchar(100)	NOT NULL,
	estado			varchar(100)	NOT NULL,
	senha			varchar(100)	NOT NULL,
	PRIMARY KEY(id)
);

CREATE TABLE curso(
	id		 int NOT NULL AUTO_INCREMENT,
	nome	varchar(100) NOT NULL,
	tipo	varchar(100)	NOT NULL,
	-- técnico, tecnólogo, bacharelado, licenciatura
	ano_criacao int NOT NULL,
	PRIMARY KEY(id)
);

CREATE TABLE professor(
	id int	NOT NULL AUTO_INCREMENT,
	matricula varchar(15) NOT NULL,
	dt_nascimento date NOT NULL,
	nome varchar(100) NOT NULL,
	titulacao varchar(100) NOT NULL,
	-- graduação, especialização, mestrado, doutorado
	area_formacao varchar(100) NOT NULL,
	endereco varchar(100) NOT NULL,
	bairro varchar(100) NOT NULL,
	cidade varchar(100) NOT NULL,
	estado varchar(100) NOT NULL,
	PRIMARY KEY(id)
)