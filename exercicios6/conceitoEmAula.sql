create database aula1;

DROP TABLE Contatos;
CREATE TABLE Pessoas
(
	idPessoa integer UNIQUE NOT NULL PRIMARY KEY, 
	nome varchar(40),
	cpf varchar(12),
	email varchar(30),
	dataNasc date,
	celular varchar(15)
)

INSERT INTO PESSOAS(idPessoa, nome, cpf, email, dataNasc, celular) VALUES (1, 'eduardo', '012345678912', 'e.pavani@ufn.edu.br', '1995-10-19', '55996151995');
INSERT INTO PESSOAS(idPessoa, nome, cpf, email, dataNasc, celular) VALUES (2, 'fulano', '219876543210', 'fulano@gmail.com.br', '1965-02-05', '55987634176');

SELECT * FROM Pessoas;

CREATE TABLE Veiculos
(
	idVeiculo integer UNIQUE NOT NULL PRIMARY KEY,
	marca varchar(30),
	modelo varchar(30),
	versao varchar(30),
	ano char(4),
	placa varchar(8),
	chassi varchar(30),
	cor varchar(20),
	tipo varchar(30),
	fk_idPessoa integer,
	FOREIGN KEY (fk_idPessoa) REFERENCES PESSOAS(idPessoa)
)

INSERT INTO VEICULOS(idVeiculo, marca, modelo, versao, ano, placa, chassi, cor, tipo, fk_idPessoa) 
VALUES (1, 'NISSAN', 'MARCH', 'SL 1.6 AT', '2017', 'BBH7H27', '123456789HB9900', 'CINZA', 'PASSEIO-HATCHBACK', 1);

SELECT * FROM Veiculos;

CREATE TABLE Seguro
(
	idSeguro SERIAL CONSTRAINT pk_idSeguro PRIMARY KEY, /*Auto-increment do ID. Esse comando identifica automaticamente 
	quando é inteiro e inclusive que vai ser um valor unico*/
	nApolice bigint,
	data date,
	fipe decimal(10,2),
	tipo varchar(10), /*TOTAL, PARCIAL, TERCEIROS*/
	usoVeiculo varchar(15),
	valorPremio decimal(10,2), /*VALOR DO SEGURO COM TODOS OS ITENS DE UMA APÓLICE*/
	valorFranquia decimal(10,2), /*VALOR PARA REPARO, CASO SEJA ESCOLHIDO TIPO:TOTAL*/
	/*descontoBonus decimal(10,2) CLASSE BONUS */
	duracaoMeses integer,
	cpfCondutor varchar(12), /*PESSOA QUE IRÁ FAZER O SEGURO, NÃO NECESSARIAMENTE É O PROPRIETÁRIO DO VEÍCULO */
	cep varchar(8), /*LOCALIZAÇÃO DO VEÍCULO/CONDUTOR*/
	fk_idVeiculo integer,
	FOREIGN KEY (fk_idVeiculo) REFERENCES VEICULOS(idVeiculo)
)

DROP TABLE Seguro;
ALTER TABLE Seguro ADD descontoBonus decimal(10,2);

INSERT INTO SEGURO (nApolice, data, fipe, tipo, usoVeiculo, valorPremio, valorFranquia, descontoBonus, duracaoMeses, cpfCondutor, cep, fk_idVeiculo)
VALUES (20221111001, '2022-11-11', 55500, 'TOTAL', 'PARTICULAR', 3200, 3800, 0, 12, '012345678912', '97010033', 1 );

SELECT * FROM Seguro;

CREATE TABLE Endereco
(
	idEndereco Serial Constraint pk_idEndereo Primary Key,
	cep integer,
	rua varchar(40),
	bairro varchar(40),
	numero integer,
	complemento varchar(40),
	descricao varchar(40),
	fk_idPessoa integer,
	FOREIGN KEY (fk_idPessoa) REFERENCES PESSOAS(idPessoa)
)

CREATE TABLE RG
(
	idRg Serial Constraint pk_idRg Primary Key,
	numero bigint,
	uf char(2)
)

INSERT INTO RG(numero, uf) VALUES (1122334455, 'RS');
INSERT INTO RG(numero, uf) VALUES (5544332211, 'SC');

SELECT * FROM RG;

/*EXISTE A POSSIBILIDADE DE EM ALGUM MOMENTO EM ALGUM SISTEMA UMA PESSOA TER O MESMO RG QUE OUTRA*/
CREATE TABLE RG_PESSOA
(
	fk_idRg integer,
	fk_idPessoa integer,
	FOREIGN KEY (fk_idRg) REFERENCES RG(idRg),
	FOREIGN KEY (fk_idPessoa) REFERENCES PESSOAS(idPessoa)
)

SELECT *FROM RG_PESSOA;

INSERT INTO RG_PESSOA(fk_idPessoa, fk_idRg) VALUES(1,1);
INSERT INTO RG_PESSOA(fk_idPessoa, fk_idRg) VALUES(1,2);
INSERT INTO RG_PESSOA(fk_idPessoa, fk_idRg) VALUES(2,2);