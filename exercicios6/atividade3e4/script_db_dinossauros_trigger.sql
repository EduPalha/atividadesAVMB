CREATE TABLE DESCOBRIDOR
(
	idDescobridor Serial Constraint pk_idDescobridor Primary Key,
	nomeDescobridor varchar(50)
)


CREATE TABLE PAIS
(
	idPais Serial Constraint pk_idPais Primary Key,
	nomePais varchar(30)
)


CREATE TABLE PAIS_DESCOBRIDOR
(
	idPD Serial Constraint pk_idPD Primary Key,
	fk_idPais integer,
	fk_idDescobridor integer,
	foreign key (fk_idPais) references PAIS(idPais),
	foreign key (fk_idDescobridor) references DESCOBRIDOR(idDescobridor)
)


CREATE TABLE DIETA(
      idDietaDinos Serial Constraint pk_idDietaDinos Primary Key,
      nomeDieta varchar(10)
)


CREATE TABLE ERA
(
      idEra Serial Constraint pk_idEra Primary Key,
      anoInicio integer,
      anoFim integer
)


CREATE TABLE GRUPO
(
	idGrupo Serial Constraint pk_idGrupo Primary Key,
	nomeGrupo varchar(25),
	fk_idDietaDinos integer,
	foreign key (fk_idDietaDinos) references DIETA(idDietaDinos)
)


CREATE TABLE ERA_GRUPO(
      fk_idEra integer,
      fk_idGrupo integer,
      foreign key (fk_idEra) references ERA(idEra),
      foreign key (fk_idGrupo) references GRUPO(idGrupo)
)


CREATE TABLE DINOSSAURO
(
	idDino Serial Constraint pk_idDino Primary Key,
	nomeDino varchar(25),
	toneladas decimal(3,1),
	anoDescoberta integer,
	anoInicio integer,
	anoFim integer,
	fk_idDescobridor integer,
	fk_idGrupo integer,
	FOREIGN KEY (fk_idDescobridor) REFERENCES DESCOBRIDOR(idDescobridor),
	FOREIGN KEY (fk_idGrupo) REFERENCES GRUPO(idGrupo)
)



INSERT INTO DIETA (nomeDieta) VALUES ('Herbívoros');
INSERT INTO DIETA (nomeDieta) VALUES ('Carnívoros');
	  

INSERT INTO GRUPO(nomeGrupo, fk_idDieta) VALUES ('Anquilossauros', 1);
INSERT INTO GRUPO(nomeGrupo, fk_idDieta) VALUES ('Ceratopsídeos', 1);
INSERT INTO GRUPO(nomeGrupo, fk_idDieta) VALUES ('Estegossauros', 1);
INSERT INTO GRUPO(nomeGrupo, fk_idDieta) VALUES ('Terápodes', 2);


INSERT INTO ERA(nomeEra, anoInicio, anoFim) VALUES ('Cretáceo', 145,65);
INSERT INTO ERA(nomeEra, anoInicio, anoFim) VALUES ('Jurássico', 201,145);
INSERT INTO ERA(nomeEra, anoInicio, anoFim) VALUES ('Triássico', 252,63);


INSERT INTO ERA_GRUPO(fk_idEra, fk_idGrupo) VALUES (1,1);
INSERT INTO ERA_GRUPO(fk_idEra, fk_idGrupo) VALUES (1,2);
INSERT INTO ERA_GRUPO(fk_idEra, fk_idGrupo) VALUES (2,3);
INSERT INTO ERA_GRUPO(fk_idEra, fk_idGrupo) VALUES (3,1);
INSERT INTO ERA_GRUPO(fk_idEra, fk_idGrupo) VALUES (2,4);
INSERT INTO ERA_GRUPO(fk_idEra, fk_idGrupo) VALUES (1,2);
INSERT INTO ERA_GRUPO(fk_idEra, fk_idGrupo) VALUES (3,1);


INSERT INTO DESCOBRIDOR(nomeDescobridor) VALUES ('Maryanska');
INSERT INTO DESCOBRIDOR(nomeDescobridor) VALUES ('John Bell Hatcher');
INSERT INTO DESCOBRIDOR(nomeDescobridor) VALUES ('Cientistas Alemães');
INSERT INTO DESCOBRIDOR(nomeDescobridor) VALUES ('Museu Americano de História Natural');
INSERT INTO DESCOBRIDOR(nomeDescobridor) VALUES ('Othniel Charles Marsh');
INSERT INTO DESCOBRIDOR(nomeDescobridor) VALUES ('Barnum Brown');


INSERT INTO PAIS(nomePais) VALUES ('Mongólia');
INSERT INTO PAIS(nomePais) VALUES ('Canadá');
INSERT INTO PAIS(nomePais) VALUES ('Tanzânia');
INSERT INTO PAIS(nomePais) VALUES ('China');
INSERT INTO PAIS(nomePais) VALUES ('América do Norte');
INSERT INTO PAIS(nomePais) VALUES ('USA');


INSERT INTO PAIS_DESCOBRIDOR(fk_idDescobridor,fk_idPais) VALUES (1,1);
INSERT INTO PAIS_DESCOBRIDOR(fk_idDescobridor,fk_idPais) VALUES (2,2);
INSERT INTO PAIS_DESCOBRIDOR(fk_idDescobridor,fk_idPais) VALUES (3,3);
INSERT INTO PAIS_DESCOBRIDOR(fk_idDescobridor,fk_idPais) VALUES (4,4);
INSERT INTO PAIS_DESCOBRIDOR(fk_idDescobridor,fk_idPais) VALUES (5,5);
INSERT INTO PAIS_DESCOBRIDOR(fk_idDescobridor,fk_idPais) VALUES (2,6);
INSERT INTO PAIS_DESCOBRIDOR(fk_idDescobridor,fk_idPais) VALUES (6,5);


INSERT INTO DINOSSAURO(nomeDino,toneladas,anoDescoberta,anoInicio,anoFim,fk_idDescobridor,fk_idGrupo) VALUES ('Saichania',4,1977,145,66,1,1);
INSERT INTO DINOSSAURO(nomeDino,toneladas,anoDescoberta,anoInicio,anoFim,fk_idDescobridor,fk_idGrupo) VALUES ('Tricerátops',6,1887,70,66,2,2);
INSERT INTO DINOSSAURO(nomeDino,toneladas,anoDescoberta,anoInicio,anoFim,fk_idDescobridor,fk_idGrupo) VALUES ('Kentrossauro',2,1909,200,145,3,3);
INSERT INTO DINOSSAURO(nomeDino,toneladas,anoDescoberta,anoInicio,anoFim,fk_idDescobridor,fk_idGrupo) VALUES ('Pinacossauro',6,1999,85,75,4,1);
INSERT INTO DINOSSAURO(nomeDino,toneladas,anoDescoberta,anoInicio,anoFim,fk_idDescobridor,fk_idGrupo) VALUES ('Alossauro',3,1877,155,150,5,4);
INSERT INTO DINOSSAURO(nomeDino,toneladas,anoDescoberta,anoInicio,anoFim,fk_idDescobridor,fk_idGrupo) VALUES ('Torossauro',8,1891,67,65,2,2);
INSERT INTO DINOSSAURO(nomeDino,toneladas,anoDescoberta,anoInicio,anoFim,fk_idDescobridor,fk_idGrupo) VALUES ('Anquilossauro',8,1906,66,63,6,1);


select di.idDino, di.nomeDino, di.toneladas, di.anoDescoberta, gr.nomeGrupo, era.nomeEra, de.nomeDescobridor, pais.nomePais 
from dinossauro as di
inner join descobridor as de on di.fk_idDescobridor = de.idDescobridor
inner join grupo as gr on di.fk_idGrupo = gr.idGrupo
inner join era_grupo as eg on gr.idGrupo = eg.fk_idGrupo
inner join era on eg.fk_idEra = era.idEra
inner join dieta as die on gr.fk_idDieta = die.idDieta
inner join pais_descobridor as pd on de.idDescobridor = pd.fk_idDescobridor
inner join pais on pd.fk_idPais = pais.idPais
group by di.nomeDino, di.toneladas, di.anoDescoberta, gr.nomeGrupo, era.nomeEra, de.nomeDescobridor, pais.nomePais, di.idDino
order by di.nomeDino asc


create trigger trigger_idade
on DINOSSAURO
after insert, update
as
	declare @idade integer
	select @idade = (select(anoInicio - anoFim) from inserted)

	if(@idade >= 0)
		begin
		--print('Inserido com sucesso!');
		return;
		end
	else
		begin
		rollback;
		raiserror('Tempo de existência inválido!', 14, 1);
		return;
end



create trigger trigger_tempo
on DINOSSAURO
after insert, update
as
	declare @inicio integer
	declare @fim integer
	declare @era integer
	select @inicio = (select(anoInicio) from inserted)
	select @fim = (select(anoFim) from inserted)
	select @era = (select(idEra) from ERA)

	if(@inicio <= 145 and @fim >= 65 and @era = 1 )
		begin
		return;
		end
	else if
	(@inicio <= 201 and @fim >= 145 and @era = 2 )
		begin
		return;
		end
	else if(@inicio <= 252 and @fim >= 63 and @era = 3 )
		begin
		return;
		end
	else
		begin
		rollback;
		raiserror('Tempo de existência INVÁLIDO!', 14, 1);
		return;
end






