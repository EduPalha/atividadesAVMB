create table bebe
(
	idBebe Serial Constraint pk_idBebe Primary Key,
	nomeBebe varchar(80),
	data_nascimento date,
	hora_nascimento time,
	fk_idMedicao integer,
	fk_idMae integer,
	FOREIGN KEY (fk_idMedicao) REFERENCES MEDICAO(idMedicao),
	FOREIGN KEY (fk_idMae) REFERENCES MAE(idMae)
)

create table mae
(
	idMae Serial Constraint pk_idMae Primary Key,
	nomeMae varchar(80),
	data_nascimento date,
	endereco varchar(80),
	cep integer,
	telefone bigint
)

create table medico
(
	idMedico Serial Constraint pk_idMedico Primary Key,
	nome varchar(80),
	crm varchar(12),
	telefone bigint,
	especialidade varchar(30)
)

create table medicao
(
	idMedicao Serial Constraint pk_idMedicao Primary Key,
	peso decimal(5,2),
	altura integer,
	dataMedicao date,
	descricao varchar(140)
)

create table bebe_medico
(
	fk_idBebe integer,
	fk_idMedico integer,
	FOREIGN KEY (fk_idBebe) REFERENCES BEBE(idBebe),
	FOREIGN KEY (fk_idMedico) REFERENCES MEDICO(idMedico)
)



